using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Playwright.Tests
{
    public class UCommNavigationTest
    {
        public async Task RunAsync()
        {
            using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.uwlax.edu/ucomm");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = $"screenshots\\{DateTime.Now.Ticks}\\ucomm.png" });

        }
    }
}
