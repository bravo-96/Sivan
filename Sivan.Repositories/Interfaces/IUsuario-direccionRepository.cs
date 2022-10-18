using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
     public interface IUsuario_direccionRepository
    {
        Task<Usuario_direccion> Insert(Usuario_direccion model);
        Task<Usuario_direccion> Update(Usuario_direccion model);
        Task Delete(int id);
        Task<IEnumerable<Usuario_direccion>> GetAll();
        Task<Usuario_direccion> GetById(int id);

    }
}
