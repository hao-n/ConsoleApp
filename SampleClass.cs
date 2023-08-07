using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class SampleClass
    {

        // constructor
        public SampleClass()
        {
            
            SampleClassName = "Name of SampleClass";
        }

        public string SampleClassName { get; set; }

        public void SampleMethod()
        {
            Console.WriteLine(SampleClassName);
            SampleClassName = "SampleClass";

        }

    }
}
