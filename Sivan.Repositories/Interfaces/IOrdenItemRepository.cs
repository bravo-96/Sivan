using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    interface IOrdenItemRepository
    {
        Task<OrdenItem> Insert(OrdenItem model);
        Task<OrdenItem> Update(OrdenItem model);
        Task Delete(int id);
        Task<IEnumerable<OrdenItem>> GetAll();
        Task<OrdenItem> GetById(int id);
    }
}
