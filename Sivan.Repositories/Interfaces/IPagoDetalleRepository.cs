using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IPagoDetalleRepository
    {
        Task<PagoDetalle> Insert(PagoDetalle model);
        Task<PagoDetalle> Update(PagoDetalle model);
        Task Delete(int id);
        Task<IEnumerable<PagoDetalle>> GetAll();
        Task<PagoDetalle> GetById(int id);
    }
}
