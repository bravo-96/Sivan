using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface ICompra_SessionRepository
    {
        Task<Compra_Session> Insert(Compra_Session model);
        Task<Compra_Session> Update(Compra_Session model);
        Task Delete(int id);
        Task<IEnumerable<Compra_Session>> GetAll();
        Task<Compra_Session> GetById(int id);
    }
}
