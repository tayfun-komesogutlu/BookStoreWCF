﻿using BookService.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Contracts.Output
{
    [DataContract]
    public class GetPublishersOutput
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Info { get; set; }
    }
}
