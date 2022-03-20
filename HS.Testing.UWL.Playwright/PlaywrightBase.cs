using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Playwright
{
    public class PlaywrightBase
    {
        protected IPage Page { get; private set; }
        public PlaywrightBase(IPage page)
        {
            this.Page = page;
        }
    }
}
