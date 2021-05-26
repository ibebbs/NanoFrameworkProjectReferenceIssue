using nanoFramework.TestFramework;
using NanoFrameworkProjectReferenceIssue;
using System;

namespace NanoFrameworkProjectReferenceIssues.Tests
{

    public class Dependency : IDependency
    {

    }

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CorrectlyInstantiate()
        {
            var instance = new AClass(new Dependency());

            //var instance = new AClass();

            Assert.NotNull(instance);
        }
    }
}
