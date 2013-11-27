using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Modeller mdlr = new Modeller();
            Console.WriteLine(mdlr.DefineNewSpecie("A"));

        }
    }
}
