using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SailbotVSv3.Models;
namespace SailbotVSv3
{
    public static class ContextManager
    {
        private static string CONNECTION_STRING;

        public static void SetConnectionString(string connectionString)
        {
            CONNECTION_STRING = connectionString;
        }

        public static SailbotContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SailbotContext>();
            optionsBuilder.UseSqlServer(CONNECTION_STRING);

            var context = new SailbotContext(optionsBuilder.Options);
            return context;
        }
    }
}
