﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace sharpSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Modeler mdlr = new Modeler();
            Console.WriteLine(mdlr.DefineNewSpecie("A"));

        }
    }
}
