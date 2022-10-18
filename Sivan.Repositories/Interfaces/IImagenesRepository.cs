using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IImagenesRepository
    {
        Task<Imagenes> Insert(Imagenes model);
        Task<Imagenes> Update(Imagenes model);
        Task Delete(int id);
        Task<IEnumerable<Imagenes>> GetAll();
        Task<Imagenes> GetById(int id);
    }
}
