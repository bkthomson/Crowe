using System.Configuration;
using System;
using Crowe.HelloWorld;

namespace Crowe.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Crowe.HelloWorld.CroweHelloWorldSection crowleHelloWorldconfig = (Crowe.HelloWorld.CroweHelloWorldSection)System.Configuration.ConfigurationManager.GetSection("CroweHelloWorld");
                Crowe.HelloWorld.Output crowleHellowWorld = new Output(crowleHelloWorldconfig.OutputType.value);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            System.Console.ReadLine();
        }
    }
}
