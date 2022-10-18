using Sivan.Models.Entities;
using Sivan.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Implements
{
    public class CarritoItemsRepository : ICarritoItemsRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarritoItems>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItems> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItems> Insert(CarritoItems model)
        {
            throw new NotImplementedException();
        }

        public Task<CarritoItems> Update(CarritoItems model)
        {
            throw new NotImplementedException();
        }
    }
}
