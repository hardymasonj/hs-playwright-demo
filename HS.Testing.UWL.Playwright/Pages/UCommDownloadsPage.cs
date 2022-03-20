using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Playwright.Pages
{
    public class UCommDownloadsPage : UWLPageBase
    {
        public UCommDownloadsPage(IPage page) : base(page, "https://www.uwlax.edu/ucomm/downloads/")
        {

        }
        public async Task<string> ChangeTabAsync(string tabTriggerName)
        {
            await this.Page.ClickAsync($"#tab-trigger-{tabTriggerName}");
            return await this.Page.GetAttributeAsync($"tab-trigger-{tabTriggerName}", "href");
        }
        public async Task<string> GetVisibleTab(string tabsContainer)
        {
            return await this.Page.GetAttributeAsync($"{tabsContainer} .quickTabsContent:not(.hidden)", "id");
        }
    }
}
