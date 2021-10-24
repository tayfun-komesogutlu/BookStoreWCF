using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Contracts.Input
{
    public class GetPublisherBooksInput
    {
        public int PublisherId { get; set; }
    }
}
