using BookService.Contracts.Dto;
using BookService.Domain.Dto;
using BookService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Contracts.Output
{
    [DataContract]
    public class CheckStockOutput
    {
        [DataMember]
        public string Isbn { get; set; }
        [DataMember]
        public bool ValidIsbn { get; set; }
        [DataMember]
        public Author Author { get; set; }
        [DataMember]
        public Publisher Publisher { get; set; }
        [DataMember]
        public Format Format { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        [DataMember]
        public string Version { get; set; }
        [DataMember]
        public string Preface { get; set; }
        [DataMember]
        public int QuantityLeft { get; set; }
        [DataMember]
        public int WareHouseLocation { get; set; }
        [DataMember]
        public DateTime NextStockDate { get; set; }
    }
}
