using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> Insert(Usuario model);
        Task<Usuario> Update(Usuario model);
        Task Delete(int id);
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> GetById(int id);
    }
}
