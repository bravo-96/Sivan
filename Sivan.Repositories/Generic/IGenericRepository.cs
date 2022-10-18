﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sivan.Repositories.Implements
{
    public interface IGenericRepository<T>
    {
        Task<T> Delete( int id );
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById( int id );
        Task<T> Insert( T model );
        Task<T> Update( T model );
    }
}
