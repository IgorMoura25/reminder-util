using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace IgorMoura.Reminder.UtilTest
{
    public static class TestConfiguration
    {
        public static string ConnectionString
        {
            get
            {
                var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

                var defaultConnection = config["Data:DefaultConnection:ConnectionString"];

                if (string.IsNullOrEmpty(defaultConnection) || string.IsNullOrWhiteSpace(defaultConnection))
                {
                    defaultConnection = config["Data:TestPipelineConnection:ConnectionString"];
                }

                return defaultConnection;
            }
        }
    }
}
