using Org.Kevoree.Annotation;
using System;
using System.ComponentModel.Composition;
using Org.Kevoree.Log.Api;

namespace Org.Kevoree.Library.Comp.HelloWorld
{
    [ComponentType]
    [Serializable]
    [Export(typeof(DeployUnit))]
    public class HelloWorld : MarshalByRefObject, DeployUnit
    {

        [Param(Optional = false, DefaultValue = "Hello, world")]
        public String greetMessage;

        [KevoreeInject] private ILogger logger;

        [Start]
        public void Start()
        {
            logger.Info(this.greetMessage);
        }

        [Stop]
        public void Stop()
        {
            Console.WriteLine(this.greetMessage);
        }
    }
}
