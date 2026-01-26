using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H163_ext_test;

namespace ConsoleApp1asd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RenderClass ova = new RenderClass();
            ova.Start().Wait();
        }
    }
}
