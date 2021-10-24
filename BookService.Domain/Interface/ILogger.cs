using BookService.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Domain.Interface
{
    public interface ILogger
    {
        void SaveLogs(List<Log> log, string logPath);
    }
}
