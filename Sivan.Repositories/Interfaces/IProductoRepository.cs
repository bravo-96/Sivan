using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> Insert(Producto model);
        Task<Producto> Update(Producto model);
        Task Delete(int id);
        Task<IEnumerable<Producto>> GetAll();
        Task<Producto> GetById(int id);
    }
}
