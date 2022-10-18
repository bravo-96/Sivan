using Sivan.Models.Entities;
using Sivan.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Implements
{
    public class CarritoItemRepository : ICarritoItemRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarritoItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItem> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItem> Insert(CarritoItem model)
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItem> Update(CarritoItem model)
        {
            throw new NotImplementedException();
        }
    }
}
