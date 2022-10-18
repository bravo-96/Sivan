using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IOrdenDetalleRepository
    {
        Task<OrdenDetalle> Insert(OrdenDetalle model);
        Task<OrdenDetalle> Update(OrdenDetalle model);
        Task Delete(int id);
        Task<IEnumerable<OrdenDetalle>> GetAll();
        Task<OrdenDetalle> GetById(int id);
    }
}
