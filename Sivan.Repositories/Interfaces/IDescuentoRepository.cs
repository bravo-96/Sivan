using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IDescuentoRepository
    {
        Task<Descuento> Insert(Descuento model);
        Task<Descuento> Update(Descuento model);
        Task Delete(int id);
        Task<IEnumerable<Descuento>> GetAll();
        Task<Descuento> GetById(int id);
    }
}
