using BookService.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookService.Domain.Dto;

namespace BookService.Domain.Logger
{
    internal class DbLogger : ILogger
    {
        public void SaveLogs(List<Log> log, string logPath)
        {
            ///TODO
            throw new NotImplementedException();
        }
    }
}
