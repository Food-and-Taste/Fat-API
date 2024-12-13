namespace FatApi.Helpers
{
    public class SecretesHelper
    {
        public class SecretsHelper
        {
            public static string GetDatabaseConnectionString(WebApplicationBuilder builder)
            {
                var host = builder.Configuration["ConnectionStrings:DefaultConnection:Host"];
                var port = builder.Configuration["ConnectionStrings:DefaultConnection:Port"];
                var dataBase = builder.Configuration["ConnectionStrings:DefaultConnection:Database"];
                var userName = builder.Configuration["ConnectionStrings:DefaultConnection:Username"];
                var password = builder.Configuration["ConnectionStrings:DefaultConnection:Password"];

                return $"Server={host};Port={port};Database={dataBase};Username={userName};Password={password};";
            }
        }
    }
}
