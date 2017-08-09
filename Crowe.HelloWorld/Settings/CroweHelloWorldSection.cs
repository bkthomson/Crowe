using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Crowe.HelloWorld
{
    /// <summary>
    /// Configuration Class for Hello World.
    /// </summary>
    public class CroweHelloWorldSection : ConfigurationSection
    {
        // Create a "color element."
        [ConfigurationProperty("outputtype")]
        public OutputTypeElement OutputType
        {
            get
            {
                return (OutputTypeElement)this["outputtype"];
            }
            set
            { this["outputtype"] = value; }
        }

    }

    public class OutputTypeElement : ConfigurationElement
    {
        [ConfigurationProperty("value", IsRequired = true)]
        public String value
        {
            get
            {
                return (String)this["value"];
            }
            set
            {
                this["value"] = value;
            }
        }
    }
}
