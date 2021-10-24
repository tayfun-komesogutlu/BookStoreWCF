using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Domain.Enums
{
    public enum Format
    {
        Digital = 1,
        Print = 2,
        [Description("Digital&Print")]
        Both = 3
    }
}
