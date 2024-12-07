using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RaskhodApp.utils
{
    public static class JsonLogger
    {
        static string file = "logs.txt";

        public static void LogError(Exception ex)
        {
            var log = new
            {
                Date = DateTime.Now,
                Message = ex.Message,
                StackTrace = ex.StackTrace
            };
            File.AppendAllText(file, JsonSerializer.Serialize(log) + Environment.NewLine);
        }
    }
}
