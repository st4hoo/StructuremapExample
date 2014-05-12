using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using StructureMap;

namespace StructuremapAutomap
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory.Initialize(x => 
                { x.Scan(
                      scan =>
                      {
                          scan.AssembliesFromPath(Environment.CurrentDirectory + @"\Impl" );
                          scan.WithDefaultConventions();
                      }
                    );
                });
            
            Console.WriteLine(ObjectFactory.WhatDoIHave());

            Console.ReadLine();
        }
    }
}
