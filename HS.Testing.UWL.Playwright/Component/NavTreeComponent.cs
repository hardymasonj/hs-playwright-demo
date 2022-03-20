using HS.Testing.Domain.Components;
using HS.Testing.Domain.Models;
using Microsoft.Playwright;

namespace HS.Testing.UWL.Playwright.Component
{
    public class NavTreeComponent : PlaywrightBase, INavTreeComponent
    {
        public NavTreeComponent(IPage page) : base(page)
        {
            this.Navigation = GetNavTreeComponents();
        }
        protected IEnumerable<INavTreeModel> GetNavTreeComponents()
        {
            return null;
        }
        protected INavTreeModel GetNavTreeComponent()
        {
            return null;
        }
        public IEnumerable<INavTreeModel> Navigation { get; }
    }
}
