using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrocaBolas.Domain.Services
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
