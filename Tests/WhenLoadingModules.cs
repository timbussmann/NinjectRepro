using System.Runtime.Remoting.Messaging;
using Ninject;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WhenLoadingModules
    {
        [Test]
        public void ShouldNotThrow()
        {
            CallContext.LogicalSetData("someKey", new NonSerializableClass());

            INinjectSettings settings = new NinjectSettings()
            {
                LoadExtensions = true,
                ExtensionSearchPatterns = new[] { "*.dll" }
            };
            var kernel = new StandardKernel(settings);

            Assert.Pass();
        }
    }

    class NonSerializableClass
    {
    }
}