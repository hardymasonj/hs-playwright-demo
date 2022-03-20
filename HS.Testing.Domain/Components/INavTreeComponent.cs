using HS.Testing.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.Domain.Components
{
    public interface INavTreeComponent
    {
        public IEnumerable<INavTreeModel> Navigation { get; }
    }
}
