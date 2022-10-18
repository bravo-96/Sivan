using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface ICarrito_itemsRepository
    {
        Task<Carrito_items> Insert(Carrito_items model);
        Task<Carrito_items> Update(Carrito_items model);
        Task Delete(int id);
        Task<IEnumerable<Carrito_items>> GetAll();
        Task<Carrito_items> GetById(int id);

    }
}
