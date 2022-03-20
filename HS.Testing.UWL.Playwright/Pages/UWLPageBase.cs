using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Playwright.Pages
{
    public abstract class UWLPageBase : PlaywrightBase
    {
        protected string Url { get; }
        public UWLPageBase(IPage page, string url) : base(page)
        {
            this.Url = url;
            Page.GotoAsync(url);
        }
    }
}
