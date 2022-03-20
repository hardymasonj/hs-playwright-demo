using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Testing.Domain.Models
{
    public interface INavTreeModel
    {
        string Text { get; }
        string Link { get; }
        IEnumerable<INavTreeModel> Children { get; }
    }
}
