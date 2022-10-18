using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface ICarritoItemRepository
    {
        Task<CarritoItem> Insert(CarritoItem model);
        Task<CarritoItem> Update(CarritoItem model);
        Task Delete(int id);
        Task<IEnumerable<CarritoItem>> GetAll();
        Task<CarritoItem> GetById(int id);

    }
}
