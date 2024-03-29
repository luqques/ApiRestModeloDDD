﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);
        
        void Delete(TEntity obj);
        
        IEnumerable<TEntity> GetAll();
        
        TEntity GetById(int id);
    }
}
