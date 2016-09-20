using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requestor
{
    class Program
    {
        static void Main(string[] args)
        {
            Requestor Req = new Requestor(@".\Private$\ReqQueue", @".\Private$\RepQueue");
            Req.Send();
            Req.ReceiveSync();
            Console.ReadKey();

        }
    }
}
