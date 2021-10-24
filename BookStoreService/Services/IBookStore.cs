using BookService.Contracts.Input;
using BookService.Contracts.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookStoreService" in both code and config file together.
    [ServiceContract]
    public interface IBookStore
    {
        [OperationContract]
        CheckStockOutput CheckStock(CheckStockInput input);
        [OperationContract]
        List<GetAuthorsOutput> GetAuthors();
        [OperationContract]
        List<GetAuthorBooksOutput> GetAuthorsBooks(GetAuthorBooksInput input);
        [OperationContract]
        List<GetPublishersOutput> GetPublisher();
        [OperationContract]
        List<GetPublisherBooksOutput> GetPublisherBooks(GetPublisherBooksInput input);
        [OperationContract]
        IsValidIsbnOutput IsValidIsbn(IsValidIsbnInput input);
        [OperationContract]
        AddBookToStockOutput AddBookToStock(AddBookToStockInput input);
    }
}
