using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IProductoCategoriaRepository
    {
        Task<ProductoCategoria> Insert(ProductoCategoria model);
        Task<ProductoCategoria> Update(ProductoCategoria model);
        Task Delete(int id);
        Task<IEnumerable<ProductoCategoria>> GetAll();
        Task<ProductoCategoria> GetById(int id);
    }
}
