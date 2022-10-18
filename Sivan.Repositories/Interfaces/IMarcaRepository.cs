using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IMarcaRepository
    {
        Task<Marca> Insert(Marca model);
        Task<Marca> Update(Marca model);
        Task Delete(int id);
        Task<IEnumerable<Marca>> GetAll();
        Task<Marca> GetById(int id);
    }
}
