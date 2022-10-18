using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    interface IUsuarioPagosRepository
    {
        Task<UsuarioPagos> Insert(UsuarioPagos model);
        Task<UsuarioPagos> Update(UsuarioPagos model);
        Task Delete(int id);
        Task<IEnumerable<UsuarioPagos>> GetAll();
        Task<UsuarioPagos> GetById(int id);
    }
}
