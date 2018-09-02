using Microsoft.Extensions.Configuration;
using System.IO;

namespace Lendtick.Product.Common
{
    public static class AppConst
    {
        #region Get Configuration
        private static IConfiguration baseconfig;
        /// <summary>
        /// Get Application Settings Configuration File
        /// </summary>
        public static IConfiguration BaseConfiguration
        {
            get
            {
                if (baseconfig == null)
                {
                    IConfigurationBuilder configBuilder = new ConfigurationBuilder().
                                                              SetBasePath(Directory.GetCurrentDirectory()).
                                                              AddJsonFile("appsettings.json");
                    baseconfig = configBuilder.Build();
                }

                return baseconfig;
            }
        }
        #endregion

        #region String Constants
        public const string BEARER_AUTH_TYPE = "Bearer";
        public const string CLAIM_TYPE_USER_ID = "UserId";
        public const string CONTENT_TYPE_APP_JSON = "application/json";
        public const string LENDTICK_AUTH_HTTP_CLIENT = "LentickAuthClient";
        public const string LENDTICK_JWT_AUTH_SCHEME_OPTIONS = "Bearer";
        #endregion

        #region Connection String
        private static string lendtick_conn_string;
        /// <summary>
        /// Gets the lendtick connection string.
        /// </summary>
        /// <value>
        /// The lendtick connection string.
        /// </value>
        public static string LENDTICK_CONN_STRING
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lendtick_conn_string))
                {
                    string path = BaseConfiguration.GetSection("ConnectionStrings").GetSection("SourcePath").Value;
                    string name = BaseConfiguration.GetSection("ConnectionStrings").GetSection("SourceName").Value;
                    string connStrPath = Path.Combine(Directory.GetCurrentDirectory(), path);

                    IConfiguration config;
                    IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(connStrPath).AddJsonFile(name);

                    config = builder.Build();

                    if (config != null)
                    {
                        lendtick_conn_string = config.GetConnectionString("LENDTICK_CONN_STRING");
                    }
                }

                return lendtick_conn_string;
            }
        }

        private static string lendtick_mongodb_conn_string;
        /// <summary>
        /// Gets the lendtick MongoDb connection string.
        /// </summary>
        /// <value>
        /// The lendtick MongoDb connection string.
        /// </value>
        public static string LENDTICK_MONGODB_CONN_STRING
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lendtick_mongodb_conn_string))
                {
                    string path = BaseConfiguration.GetSection("ConnectionStrings").GetSection("SourcePath").Value;
                    string name = BaseConfiguration.GetSection("ConnectionStrings").GetSection("SourceName").Value;
                    string connStrPath = Path.Combine(Directory.GetCurrentDirectory(), path);

                    IConfiguration config;
                    IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(connStrPath).AddJsonFile(name);

                    config = builder.Build();

                    if (config != null)
                    {
                        lendtick_mongodb_conn_string = config.GetConnectionString("LENDTICK_MONGODB_CONN_STRING");
                    }
                }

                return lendtick_mongodb_conn_string;
            }
        }
        #endregion

        #region Mongo Database Name
        private static string lendtick_mongo_database_name;
        /// <summary>
        /// Gets the lendtick MongoDb database name.
        /// </summary>
        /// <value>
        /// The lendtick lendtick MongoDb database name.
        /// </value>
        public static string LENDTICK_MONGO_DATABASE_NAME
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lendtick_mongo_database_name))
                {
                    string path = BaseConfiguration.GetSection("AppConfigs").GetSection("SourcePath").Value;
                    string name = BaseConfiguration.GetSection("AppConfigs").GetSection("SourceName").Value;
                    string appConfPath = Path.Combine(Directory.GetCurrentDirectory(), path);

                    IConfiguration config;
                    IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(appConfPath).AddJsonFile(name);

                    config = builder.Build();

                    if (config != null)
                    {
                        lendtick_mongo_database_name = config["LENDTICK_MONGO_DATABASE_NAME"];
                    }
                }

                return lendtick_mongo_database_name;
            }
        }
        #endregion

        #region Application Config
        private static string lendtick_auth_check_uri;
        /// <summary>
        /// Gets the lendtick authentication check URI.
        /// </summary>
        /// <value>
        /// The lendtick authentication check URI.
        /// </value>
        public static string LENDTICK_AUTH_CHECK_URI
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lendtick_auth_check_uri))
                {
                    string path = BaseConfiguration.GetSection("AppConfigs").GetSection("SourcePath").Value;
                    string name = BaseConfiguration.GetSection("AppConfigs").GetSection("SourceName").Value;
                    string appConfPath = Path.Combine(Directory.GetCurrentDirectory(), path);

                    IConfiguration config;
                    IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(appConfPath).AddJsonFile(name);

                    config = builder.Build();

                    if (config != null)
                    {
                        lendtick_auth_check_uri = config["LENDTICK_AUTH_CHECK_URI"];
                    }
                }

                return lendtick_auth_check_uri;
            }
        }

        private static string lendtick_auth_uri;
        /// <summary>
        /// Gets the lendtick authentication URI.
        /// </summary>
        /// <value>
        /// The lendtick authentication URI.
        /// </value>
        public static string LENDTICK_AUTH_URI
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lendtick_auth_uri))
                {
                    string path = BaseConfiguration.GetSection("AppConfigs").GetSection("SourcePath").Value;
                    string name = BaseConfiguration.GetSection("AppConfigs").GetSection("SourceName").Value;
                    string appConfPath = Path.Combine(Directory.GetCurrentDirectory(), path);

                    IConfiguration config;
                    IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(appConfPath).AddJsonFile(name);

                    config = builder.Build();

                    if (config != null)
                    {
                        lendtick_auth_uri = config["LENDTICK_AUTH_URI"];
                    }
                }

                return lendtick_auth_uri;
            }
        }
        #endregion
    }
}
