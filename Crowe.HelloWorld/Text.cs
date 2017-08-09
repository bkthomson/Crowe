using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.HelloWorld
{
    /// <summary>
    /// Base Clase for the Hello World Text
    /// </summary>
    internal class Text
    {
        const string HelloWorld = "Hello World";

        public override string ToString()
        {
            return HelloWorld;
        }
    }
}
