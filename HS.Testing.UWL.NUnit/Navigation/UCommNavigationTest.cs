using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.Playwright.NUnit;
using HS.Testing.UWL.Playwright.Pages;

namespace HS.Testing.UWL.Playwright.Tests
{
    public class UCommNavigationTest : PageTest
    {
        [Test]
        public async Task CheckNavigation()
        {
            using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            var ucommPage = new UCommPage(page);
            Assert.AreEqual(await ucommPage.GetPhoneNumberAsync(), "608.785.8487");
            Assert.AreEqual(await ucommPage.GetEmailAddressAsync(), "ucomm@uwlax.edu");
            Assert.AreEqual(await ucommPage.GetLocationAsync(), "115 Graff Main Hall");
        }

        [Test]
        public async Task CheckTabs()
        {
            using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            var ucommPage = new UCommDownloadsPage(page);
            var strExpectedId = await ucommPage.ChangeTabAsync("templates");
            Assert.AreEqual(strExpectedId, await ucommPage.GetVisibleTab("#toggle-118961"));
        }
    }
}
