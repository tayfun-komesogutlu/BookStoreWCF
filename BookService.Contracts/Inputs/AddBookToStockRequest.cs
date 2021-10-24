using BookService.Domain.Dto;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Contracts.Request
{
    public class AddBookToStockRequest
    {
        public string Isbn { get; set; }
        public bool ValidIsbn { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public Format Format { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Version { get; set; }
        public string Preface { get; set; }
        public int QuantityLeft { get; set; }
        public int WareHouseLocation { get; set; }
        public DateTime NextStockDate { get; set; }
    }
}
