using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assigment.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommmitAsync();

        void Commit();
    }
}
