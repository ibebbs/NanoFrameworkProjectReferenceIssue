using System;

namespace NanoFrameworkProjectReferenceIssue
{
    public class AClass
    {
        private readonly IDependency _dependency;

        public AClass(IDependency dependency)
        {
            _dependency = dependency;
        }
    }
}
