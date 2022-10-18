using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    interface IUsuarios_pagosRepository
    {
        Task<Usuarios_pagos> Insert(Usuarios_pagos model);
        Task<Usuarios_pagos> Update(Usuarios_pagos model);
        Task Delete(int id);
        Task<IEnumerable<Usuarios_pagos>> GetAll();
        Task<Usuarios_pagos> GetById(int id);
    }
}
