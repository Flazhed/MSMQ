using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Replier
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Replier Rep = new Replier(@".\Private$\ReqQueue", @".\Private$\InvQueue");
            Console.ReadKey();
        }
    }
}
