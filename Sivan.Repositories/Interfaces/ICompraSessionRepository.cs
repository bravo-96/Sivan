using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface ICompraSessionRepository
    {
        Task<CompraSession> Insert(CompraSession model);
        Task<CompraSession> Update(CompraSession model);
        Task Delete(int id);
        Task<IEnumerable<CompraSession>> GetAll();
        Task<CompraSession> GetById(int id);
    }
}
