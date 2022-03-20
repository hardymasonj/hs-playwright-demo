using HS.Testing.Domain.Components;
using HS.Testing.Domain.Pages;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.UWL.Playwright.Pages
{
    public class UCommPage : UWLPageBase, INavigationPage
    {
        public UCommPage(IPage page) : base(page, "https://www.uwlax.edu/ucomm")
        {

        }

        public async Task<string> GetEmailAddressAsync()
        {
            return await this.Page.InnerTextAsync("#page-contact li.email a");
        }

        public async Task<string> GetLocationAsync()
        {
            return await this.Page.InnerTextAsync("#page-contact li.location a");
        }

        public async Task<string> GetPhoneNumberAsync()
        {
            return await this.Page.InnerTextAsync("#page-contact li.phone a");
        }
    }
}
