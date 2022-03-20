using HS.Testing.Domain.Components;
using HS.Testing.Domain.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Tests.NavigationTests
{
    public class TwoColumnNavigationTest : ITestModule
    {
        protected INavTreeComponent NavTreeComponent { get; }
        protected string Department { get; }
        public TwoColumnNavigationTest(INavTreeComponent navTreeComponent, string department)
        {
            this.NavTreeComponent = navTreeComponent;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
