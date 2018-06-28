using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
    public enum response
    {
        ok, err
    }
    public class Response
    {
        public response status { get; set; }
        public string Message { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(status);
            if (status == response.ok)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(Message);
        }
    }
}
