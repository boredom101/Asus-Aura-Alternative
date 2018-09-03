using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AuraServiceLib;
using AsRogAuraServiceLib;

namespace aura
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = System.IO.File.ReadAllText(args[0]);
            Console.WriteLine(xml);

            var test = new AuraSdkManager();
            test.Effect();
            var test2 = new ServiceMediator();

            Console.WriteLine(test.Devices.Item[0].Name);

            Console.WriteLine(test.Devices.Count);

            test2.SetProfile["Group"] = xml;

            Console.WriteLine("Finished");
            Console.Read();
        }
    }
}
