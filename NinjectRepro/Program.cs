using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
        }
    }
}
