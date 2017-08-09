using System;

namespace Crowe.HelloWorld.OutputType
{
    /// <summary>
    /// Console writing class.
    /// </summary>
    internal class Console : Text, IDisposable
    {
        public Console() { }

        public void Write()
        {
            try
            {
                System.Console.WriteLine(base.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose() {}
    }
}
