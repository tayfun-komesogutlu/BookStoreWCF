using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Contracts.Output
{
    [DataContract]
    public class AddBookToStockOutput
    {
        [DataMember]
        public string IsbnNo { get; set; }
    }
}
