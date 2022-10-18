using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IDetallePagoRepository
    {
        Task<DetallePago> Insert(DetallePago model);
        Task<DetallePago> Update(DetallePago model);
        Task Delete(int id);
        Task<IEnumerable<DetallePago>> GetAll();
        Task<DetallePago> GetById(int id);
    }
}
