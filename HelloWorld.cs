using Org.Kevoree.Annotation;
using System;
using System.ComponentModel.Composition;

namespace Org.Kevoree.Library.Comp.HelloWorld
{
    [ComponentType]
    [Serializable]
    [Export(typeof(DeployUnit))]
    public class HelloWorld : MarshalByRefObject, DeployUnit
    {

        [Start]
        public void Start()
        {
            Console.WriteLine("Hello, world!");
        }

        [Stop]
        public void Stop()
        {
            Console.WriteLine("Bye, world!");
        }
    }
}
