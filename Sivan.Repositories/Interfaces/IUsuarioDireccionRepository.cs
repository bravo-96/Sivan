using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
     public interface IUsuarioDireccionRepository
    {
        Task<UsuarioDireccion> Insert(UsuarioDireccion model);
        Task<UsuarioDireccion> Update(UsuarioDireccion model);
        Task Delete(int id);
        Task<IEnumerable<UsuarioDireccion>> GetAll();
        Task<UsuarioDireccion> GetById(int id);

    }
}
