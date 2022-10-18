using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface ICarritoItemsRepository
    {
        Task<CarritoItems> Insert(CarritoItems model);
        Task<CarritoItems> Update(CarritoItems model);
        Task Delete(int id);
        Task<IEnumerable<CarritoItems>> GetAll();
        Task<CarritoItems> GetById(int id);

    }
}
