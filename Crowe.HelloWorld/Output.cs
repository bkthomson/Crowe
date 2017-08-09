using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.HelloWorld
{
    public class Output
    {
        private enumOutputType outputType;

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="OutputFor">the reqesting output action to take.</param>
        public Output(string OutputFor)
        {
            SetOutputType(OutputFor);
            preformOutput();
        }

        /// <summary>
        /// Determine which output action to takae.
        /// </summary>
        private void preformOutput()
        {
            switch (outputType)
            {
                case enumOutputType.Console:
                    outputForConsole();
                    break;
                default:
                    throw new Exception(outputType.ToString() + " is not avaliable in this version.");
            }
        }

        /// <summary>
        /// Determine if passed string is a valid value
        /// in the enumOutputType class.   
        /// </summary>
        /// <param name="OutputFor">Output Type</param>
        /// <returns></returns>
        private void SetOutputType(string OutputFor)
        {
            try
            {
                if (!Enum.IsDefined(typeof(enumOutputType), OutputFor))
                    throw new ArgumentException("Argument " + OutputFor + " could not be found as a valid output type.");

                outputType = (enumOutputType)Enum.Parse(typeof(enumOutputType), OutputFor);
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
        }

        /// <summary>
        /// Output action for Concole Base Application
        /// </summary>
        private void outputForConsole()
        {
            OutputType.Console consoleOutput;

            try
            {
                consoleOutput = new OutputType.Console();
                consoleOutput.Write();
                consoleOutput.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                consoleOutput = null;
            }
        }
    }
}
