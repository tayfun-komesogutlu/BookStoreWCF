using AutoMapper;
using BookService.Contracts.Dto;
using BookService.Contracts.Output;
using BookService.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CheckStockOutput, Book>().ReverseMap();
            CreateMap<GetAuthorBooksOutput, Book>().ReverseMap();
            CreateMap<GetPublisherBooksOutput, Book>().ReverseMap();
            CreateMap<GetPublishersOutput, Publisher>().ReverseMap();
            CreateMap<GetAuthorsOutput, Author>().ReverseMap();
        }
    }
}