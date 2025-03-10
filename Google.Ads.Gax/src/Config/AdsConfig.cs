﻿// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using Google.Ads.Gax.Util;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Google.Ads.Gax.Config
{
    /// <summary>
    /// This class reads the configuration keys from App.config.
    /// </summary>
    public class AdsConfig : ConfigBase
    {
        /// <summary>
        /// The default user ID when creating a <see cref="GoogleAuthorizationCodeFlow"/> instance.
        /// </summary>
        private const string DEFAULT_USER_ID = "user";

        /// <summary>
        /// The default timeout for API calls in milliseconds (1 hour).
        /// </summary>
        private static readonly int DEFAULT_TIMEOUT = (int)new TimeSpan(1, 0, 0).TotalMilliseconds;

        /// <summary>
        /// Default value of the maximum size in bytes of the message that can be received by the
        /// service client (64 MB).
        /// </summary>
        private const int DEFAULT_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES = 64 * 1024 * 1024;

        /// <summary>
        /// Default value for the maximum size in bytes of the metadata that can be received by the
        /// service client (16 MB).
        /// </summary>
        private const int DEFAULT_MAX_METADATA_SIZE_IN_BYTES = 16 * 1024 * 1024;

        /// <summary>
        /// OAuth2 client ID.
        /// </summary>
        protected StringConfigSetting oAuth2ClientId =
            new StringConfigSetting("OAuth2ClientId", "");

        /// <summary>
        /// OAuth2 client secret.
        /// </summary>
        protected StringConfigSetting oAuth2ClientSecret = new StringConfigSetting(
            "OAuth2ClientSecret", "");

        /// <summary>
        /// OAuth2 refresh token.
        /// </summary>
        protected StringConfigSetting oAuth2RefreshToken = new StringConfigSetting(
            "OAuth2RefreshToken", "");

        /// <summary>
        /// OAuth2 prn email.
        /// </summary>
        protected StringConfigSetting oAuth2PrnEmail = new StringConfigSetting(
            "OAuth2PrnEmail", "");

        /// <summary>
        /// OAuth2 service account email loaded from secrets JSON file.
        /// </summary>
        private StringConfigSetting oAuth2ServiceAccountEmail = new StringConfigSetting(
            "client_email", null);

        /// <summary>
        /// OAuth2 private key loaded from secrets JSON file.
        /// </summary>
        private StringConfigSetting oAuth2PrivateKey = new StringConfigSetting(
            "private_key", "");

        /// <summary>
        /// OAuth2 secrets JSON file path.
        /// </summary>
        protected StringConfigSetting oAuth2SecretsJsonPath = new StringConfigSetting(
            "OAuth2SecretsJsonPath", "");

        /// <summary>
        /// OAuth2 mode.
        /// </summary>
        protected ConfigSetting<OAuth2Flow> oAuth2Mode = new ConfigSetting<OAuth2Flow>("OAuth2Mode",
            OAuth2Flow.APPLICATION);

        /// <summary>
        /// OAuth2 scope.
        /// </summary>
        protected StringConfigSetting oAuth2Scope = null;

        /// <summary>
        /// Authorization method.
        /// </summary>
        /// <remarks>
        /// This setting is only for testing purposes.
        /// </remarks>
        private ConfigSetting<AuthorizationMethod> authorizationMethod =
            new ConfigSetting<AuthorizationMethod>("AuthorizationMethod",
                AuthorizationMethod.OAuth);

        /// <summary>
        /// A flag to determine whether or not to enable profiling.
        /// </summary>
        /// <remarks>
        /// This setting is only for testing purposes.
        /// </remarks>
        private ConfigSetting<bool> enableProfiling =
            new ConfigSetting<bool>("EnableProfiling", false);

        /// <summary>
        /// A flag to determine whether or not to use channel caching.
        /// </summary>
        /// <remarks>
        /// This setting may be used to disable channel caching in advanced use cases
        /// where the library's default credential management is manually overridden.
        /// </remarks>
        private ConfigSetting<bool> useChannelCache =
            new ConfigSetting<bool>("UseChannelCache", true);

        /// <summary>
        /// The maximum message length in bytes that the client library can receive (64 MB).
        /// </summary>
        private ConfigSetting<int> maxReceiveMessageLengthInBytes =
            new ConfigSetting<int>("MaxReceiveMessageLengthInBytes",
                DEFAULT_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES);

        /// <summary>
        /// The maximum size in bytes of the metadata that can be received by the
        /// service client.
        /// </summary>
        private ConfigSetting<int> maxMetadataSizeInBytes =
            new ConfigSetting<int>("MaxMetadataSizeInBytes",
                DEFAULT_MAX_METADATA_SIZE_IN_BYTES);

        /// <summary>
        /// Web proxy to be used with the services.
        /// </summary>
        private ConfigSetting<WebProxy> proxy = new ConfigSetting<WebProxy>("Proxy", null);

        /// <summary>
        /// The timeout for individual API calls.
        /// </summary>
        private readonly ConfigSetting<int> timeout = new ConfigSetting<int>(
            "Timeout", DEFAULT_TIMEOUT);

        /// <summary>
        /// The library identifier override.
        /// </summary>
        private readonly StringConfigSetting libraryIdentifierOverride =
            new StringConfigSetting("LibraryIdentifierOverride", "");

        /// <summary>
        /// A map between the environment variable key names and configuration key names.
        /// </summary>
        protected ReadOnlyDictionary<string, string> ENV_VAR_TO_CONFIG_KEY_MAP;

        /// <summary>
        /// Gets or sets the timeout for individual API calls.
        /// </summary>
        public int Timeout
        {
            get => timeout.Value;
            set => SetPropertyAndNotify(timeout, value);
        }

        /// <summary>
        /// Gets or sets the maximum size in bytes of the message that can be received by the
        /// service client.
        /// </summary>
        public int MaxReceiveMessageSizeInBytes
        {
            get => maxReceiveMessageLengthInBytes.Value;
            set => SetPropertyAndNotify(maxReceiveMessageLengthInBytes, value);
        }

        /// <summary>
        /// Gets or sets the maximum size in bytes of the metadata that can be received by the
        /// service client.
        /// </summary>
        public int MaxMetadataSizeInBytes
        {
            get => maxMetadataSizeInBytes.Value;
            set => SetPropertyAndNotify(maxMetadataSizeInBytes, value);
        }

        /// <summary>
        /// Gets or sets the web proxy to be used with the services.
        /// </summary>
        public WebProxy Proxy
        {
            get => proxy.Value;
            set => SetPropertyAndNotify(proxy, value);
        }

        /// <summary>
        /// Gets or sets the library identifier override.
        /// </summary>
        /// <value>
        /// The library identifier override.
        /// </value>
        /// <remarks>This setting is only for testing purposes.</remarks>
        internal string LibraryIdentifierOverride
        {
            get => libraryIdentifierOverride.Value;
            set => SetPropertyAndNotify(libraryIdentifierOverride, value);
        }

        /// <summary>
        /// Gets or sets the OAuth2 client ID.
        /// </summary>
        public string OAuth2ClientId
        {
            get => oAuth2ClientId.Value;
            set
            {
                SetPropertyAndNotify(oAuth2ClientId, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 client secret.
        /// </summary>
        public string OAuth2ClientSecret
        {
            get => oAuth2ClientSecret.Value;
            set
            {
                SetPropertyAndNotify(oAuth2ClientSecret, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 access token.
        /// </summary>
        public string OAuth2AccessToken
        {
            get
            {
                Task<string> task = this.Credentials.GetAccessTokenForRequestAsync();
                task.Wait();
                return task.Result;
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 refresh token.
        /// </summary>
        /// <remarks>This setting is applicable only when using OAuth2 web / application
        /// flow in offline mode.</remarks>
        public string OAuth2RefreshToken
        {
            get => oAuth2RefreshToken.Value;
            set
            {
                SetPropertyAndNotify(oAuth2RefreshToken, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 mode.
        /// </summary>
        public OAuth2Flow OAuth2Mode
        {
            get => oAuth2Mode.Value;
            set
            {
                SetPropertyAndNotify(oAuth2Mode, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets or sets the authorization method.
        /// </summary>
        /// <remarks>This setting is only for testing purposes.</remarks>
        internal AuthorizationMethod AuthorizationMethod
        {
            get => authorizationMethod.Value;
            set => SetPropertyAndNotify(authorizationMethod, value);
        }

        /// <summary>
        /// A flag to determine whether or not to turn on profiling in the client library.
        /// </summary>
        /// <remarks>This setting is only for testing purposes.</remarks>
        public bool EnableProfiling
        {
            get => enableProfiling.Value;
            set => SetPropertyAndNotify(enableProfiling, value);
        }

        /// <summary>
        /// A flag to determine whether or not to enable channel cache in the client library.
        /// </summary>
        /// <remarks>
        /// This setting may be used to disable channel caching in advanced use cases
        /// where the library's default credential management is manually overridden.
        /// </remarks>
        public bool UseChannelCache
        {
            get => useChannelCache.Value;
            set => SetPropertyAndNotify(useChannelCache, value);
        }

        /// <summary>
        /// Gets or sets the OAuth2 prn email.
        /// </summary>
        /// <remarks>This setting is applicable only when using OAuth2 service accounts.
        /// </remarks>
        public string OAuth2PrnEmail
        {
            get => oAuth2PrnEmail.Value;
            set
            {
                SetPropertyAndNotify(oAuth2PrnEmail, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets the OAuth2 service account email.
        /// </summary>
        /// <remarks>
        /// This setting is applicable only when using OAuth2 service accounts.
        /// This setting is read directly from the file referred to in
        /// <see cref="OAuth2SecretsJsonPath"/> setting.
        /// </remarks>
        public string OAuth2ServiceAccountEmail
        {
            get => oAuth2ServiceAccountEmail.Value;
            private set
            {
                SetPropertyAndNotify(oAuth2ServiceAccountEmail, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets the OAuth2 private key for service account flow.
        /// </summary>
        /// <remarks>
        /// This setting is applicable only when using OAuth2 service accounts.
        /// This setting is read directly from the file referred to in
        /// <see cref="OAuth2SecretsJsonPath"/> setting.
        /// </remarks>
        public string OAuth2PrivateKey
        {
            get => oAuth2PrivateKey.Value;
            private set
            {
                SetPropertyAndNotify(oAuth2PrivateKey, value);
                credential = null;
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 secrets JSON file path.
        /// </summary>
        /// <remarks>
        /// This setting is applicable only when using OAuth2 service accounts.
        /// </remarks>
        public string OAuth2SecretsJsonPath
        {
            get => oAuth2SecretsJsonPath.Value;
            set
            {
                SetPropertyAndNotify(oAuth2SecretsJsonPath, value);
                LoadOAuth2SecretsFromFile();
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 scope. This is a comma separated string of
        /// all the scopes you want to use. This property has the default value
        /// <code>https://www.googleapis.com/auth/adwords</code>
        /// </summary>
        public string OAuth2Scope
        {
            get => oAuth2Scope.Value;
            set
            {
                SetPropertyAndNotify(oAuth2Scope, value);
                credential = null;
            }
        }

        /// <summary>
        /// Public constructor.
        /// </summary>
        public AdsConfig() : base()
        {
        }

        /// <summary>
        /// Public constructor. Loads the configuration from an <see cref="IConfigurationRoot"/>.
        /// </summary>
        /// <param name="configurationRoot">The configuration root.</param>
        public AdsConfig(IConfigurationRoot configurationRoot) : base(configurationRoot)
        {
        }

        /// <summary>
        /// Public constructor. Loads the configuration from a <see cref="IConfigurationSection"/>.
        /// </summary>
        /// <param name="configurationSection">The configuration section.</param>
        public AdsConfig(IConfigurationSection configurationSection)
            : base(configurationSection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsConfig"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public AdsConfig(Dictionary<string, string> settings) : base(settings) { }

        /// <summary>
        /// Read all settings from App.config.
        /// </summary>
        /// <param name="settings">The parsed App.config settings.</param>
        protected override void ReadSettings(Dictionary<string, string> settings)
        {
            base.ReadSettings(settings);
            ReadSetting(settings, timeout);
            ReadSetting(settings, maxReceiveMessageLengthInBytes);
            ReadSetting(settings, maxMetadataSizeInBytes);

            ReadSetting(settings, oAuth2Mode);
            ReadSetting(settings, oAuth2ClientId);
            ReadSetting(settings, oAuth2ClientSecret);
            ReadSetting(settings, oAuth2RefreshToken);
            ReadSetting(settings, oAuth2Scope);

            // Read and parse the OAuth2 JSON secrets file if applicable.
            ReadSetting(settings, oAuth2SecretsJsonPath);

            if (!string.IsNullOrEmpty(oAuth2SecretsJsonPath.Value))
            {
                LoadOAuth2SecretsFromFile();
            }

            ReadSetting(settings, oAuth2PrnEmail);
            ReadProxySettings(settings);
        }

        /// <summary>
        /// Loads the configuration from environment variables.
        /// </summary>
        public void LoadFromEnvironmentVariables()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            foreach (string key in ENV_VAR_TO_CONFIG_KEY_MAP.Keys)
            {
                string value = Environment.GetEnvironmentVariable(key);
                if (!string.IsNullOrEmpty(value))
                {
                    settings[ENV_VAR_TO_CONFIG_KEY_MAP[key]] = value;
                }
            }
            ReadSettings(settings);
        }

        /// <summary>
        /// Reads the proxy settings.
        /// </summary>
        /// <param name="settings">The parsed app.config settings.</param>
        private void ReadProxySettings(Dictionary<string, string> settings)
        {
            StringConfigSetting proxyServer = new StringConfigSetting("ProxyServer", null);
            StringConfigSetting proxyUser = new StringConfigSetting("ProxyUser", null);
            StringConfigSetting proxyPassword = new StringConfigSetting("ProxyPassword", null);
            StringConfigSetting proxyDomain = new StringConfigSetting("ProxyDomain", null);

            ReadSetting(settings, proxyServer);

            if (!string.IsNullOrEmpty(proxyServer.Value))
            {
                WebProxy proxy = new WebProxy()
                {
                    Address = new Uri(proxyServer.Value)
                };
                ReadSetting(settings, proxyUser);
                ReadSetting(settings, proxyPassword);
                ReadSetting(settings, proxyDomain);

                if (!string.IsNullOrEmpty(proxyUser.Value))
                {
                    proxy.Credentials = new NetworkCredential(proxyUser.Value,
                        proxyPassword.Value, proxyDomain.Value);
                }
                this.proxy.Value = proxy;
            }
            else
            {
                // System.Net.WebRequest will find a proxy if needed.
                this.proxy.Value = null;
            }
        }

        /// <summary>
        /// The credential object that was created from settings.
        /// </summary>
        private ICredential credential = null;

        /// <summary>
        /// Gets the credentials.
        /// </summary>
        public ICredential Credentials
        {
            get
            {
                if (credential == null)
                {
                    credential = CreateCredentials();
                }
                return credential;
            }
        }

        /// <summary>
        /// Creates a credentials object from settings.
        /// </summary>
        /// <returns>The configuration settings.</returns>
        protected virtual ICredential CreateCredentials()
        {
            ICredential retval = null;
            string[] scopes = OAuth2Scope.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToArray();

            switch (OAuth2Mode)
            {
                case OAuth2Flow.APPLICATION:
                    retval = new UserCredential(
                      new GoogleAuthorizationCodeFlow(
                        new GoogleAuthorizationCodeFlow.Initializer
                        {
                            ClientSecrets = new ClientSecrets()
                            {
                                ClientId = OAuth2ClientId,
                                ClientSecret = OAuth2ClientSecret,
                            },
                            Scopes = scopes,
                            HttpClientFactory = new AdsHttpClientFactory(this)
                        }),
                      DEFAULT_USER_ID,
                      new TokenResponse()
                      {
                          RefreshToken = OAuth2RefreshToken,
                      });
                    break;

                case OAuth2Flow.SERVICE_ACCOUNT:
                    retval = new ServiceAccountCredential(
                      new ServiceAccountCredential.Initializer(OAuth2ServiceAccountEmail)
                      {
                          User = OAuth2PrnEmail,
                          Scopes = new string[] { OAuth2Scope },
                          HttpClientFactory = new AdsHttpClientFactory(this)
                      }.FromPrivateKey(OAuth2PrivateKey));
                    break;

                default:
                    throw new ApplicationException("Unrecognized json file format.");
            }
            return retval;
        }

        /// <summary>
        /// Loads the OAuth2 private key and service account email settings from the
        /// secrets JSON file.
        /// </summary>
        private void LoadOAuth2SecretsFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(OAuth2SecretsJsonPath))
                {
                    string contents = reader.ReadToEnd();
                    Dictionary<string, string> config =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(contents);

                    ReadSetting(config, oAuth2ServiceAccountEmail);
                    if (string.IsNullOrEmpty(this.OAuth2ServiceAccountEmail))
                    {
                        throw new ApplicationException(ErrorMessages.ClientEmailIsMissingInJsonFile);
                    }

                    ReadSetting(config, oAuth2PrivateKey);
                    if (string.IsNullOrEmpty(this.OAuth2PrivateKey))
                    {
                        throw new ApplicationException(ErrorMessages.PrivateKeyIsMissingInJsonFile);
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(ErrorMessages.FailedToLoadJsonSecretsFile, e);
            }
        }
    }
}
