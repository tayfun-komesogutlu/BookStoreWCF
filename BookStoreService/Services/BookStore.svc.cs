using AutoMapper;
using BookService.Contracts.Dto;
using BookService.Contracts.Input;
using BookService.Contracts.Output;
using BookService.Domain.Context;
using BookService.Domain.Provider;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookStoreService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookStoreService.svc or BookStoreService.svc.cs at the Solution Explorer and start debugging.
    public class BookStoreService : IBookStore
    {
        private readonly IMapper _mapper;
        public BookStoreService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public AddBookToStockOutput AddBookToStock(AddBookToStockInput input)
        {
            try
            {
                var isbnProvider = new IsbnProvider();
                var output = new AddBookToStockOutput { IsbnNo = input.Isbn };
                var book = _mapper.Map<Book>(output);
                if (isbnProvider.CheckIsbn(book.Isbn))
                {
                    using (var context = new ApplicationContext())
                    {
                        context.Books.Add(book);
                        context.SaveChanges();
                        return output;
                    }
                }
                return output;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public CheckStockOutput CheckStock(CheckStockInput input)
        {
            try
            {
                var book = new CheckStockOutput();
                using (var context = new ApplicationContext())
                    return (CheckStockOutput)context.Books.Where(x => x.Isbn == input.IsbnNo);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public List<GetAuthorsOutput> GetAuthors()
        {
            try
            {
                var authors = new List<GetAuthorsOutput>();
                using (var context = new ApplicationContext())
                {
                    var authorList = context.Authors.ToList();
                    if (authorList != null)
                        foreach (var item in authorList)
                            authors.Add(new GetAuthorsOutput { Id = item.Id, Name = item.Name, BirthDate = item.BirthDate });
                }
                return authors;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public List<GetAuthorBooksOutput> GetAuthorsBooks(GetAuthorBooksInput input)
        {
            try
            {
                var books = new List<GetAuthorBooksOutput>();
                using (var context = new ApplicationContext())
                {
                    var bookList = context.Books.Where(x => x.Author.Id == input.AuthorId).ToList();
                    if (bookList != null)
                        foreach (var item in bookList)
                            books.Add(new GetAuthorBooksOutput { Author = item.Author, Format = item.Format, Isbn = item.Isbn, NextStockDate = item.NextStockDate, Preface = item.Preface, Publisher = item.Publisher, QuantityLeft = item.QuantityLeft, ReleaseDate = item.ReleaseDate, ValidIsbn = item.ValidIsbn, Version = item.Version, WareHouseLocation = item.WareHouseLocation });
                }
                return books;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public List<GetPublishersOutput> GetPublisher()
        {
            try
            {
                var publishers = new List<GetPublishersOutput>();
                using (var context = new ApplicationContext())
                {
                    var publisherList = context.Publishers.ToList();
                    if (publisherList != null)
                        foreach (var item in publisherList)
                            publishers.Add(new GetPublishersOutput { Id = item.Id, Name = item.Name, Info = item.Info });
                }
                return publishers;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public List<GetPublisherBooksOutput> GetPublisherBooks(GetPublisherBooksInput input)
        {
            try
            {
                var books = new List<GetPublisherBooksOutput>();
                using (var context = new ApplicationContext())
                {
                    var bookList = context.Books.Where(x => x.Publisher.Id == input.PublisherId).ToList();
                    if (bookList != null)
                        foreach (var item in bookList)
                            books.Add(new GetPublisherBooksOutput { Author = item.Author, Format = item.Format, Isbn = item.Isbn, NextStockDate = item.NextStockDate, Preface = item.Preface, Publisher = item.Publisher, QuantityLeft = item.QuantityLeft, ReleaseDate = item.ReleaseDate, ValidIsbn = item.ValidIsbn, Version = item.Version, WareHouseLocation = item.WareHouseLocation });
                }
                return books;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public IsValidIsbnOutput IsValidIsbn(IsValidIsbnInput input)
        {
            try
            {
                var isbnProvider = new IsbnProvider();
                var checkIsbnVal = new IsValidIsbnOutput { IsValid = isbnProvider.CheckIsbn(input.IsbnNo) };
                return checkIsbnVal;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
