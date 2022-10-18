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
        Task<CompraSesion> Insert(CompraSesion model);
        Task<CompraSesion> Update(CompraSesion model);
        Task Delete(int id);
        Task<IEnumerable<CompraSesion>> GetAll();
        Task<CompraSesion> GetById(int id);
    }
}
