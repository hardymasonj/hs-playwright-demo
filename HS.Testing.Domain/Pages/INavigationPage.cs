using HS.Testing.Domain.Components;
using HS.Testing.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.Domain.Pages
{
    public interface INavigationPage
    {
        Task<string> GetPhoneNumberAsync();
        Task<string> GetEmailAddressAsync();
        Task<string> GetLocationAsync();
    }
}
