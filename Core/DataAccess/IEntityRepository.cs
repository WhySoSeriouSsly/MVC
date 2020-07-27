using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess
{
   public  interface IEntityRepository<T> where T:class ,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);//Tek bir nesne istiyoruz
        List<T> GetList(Expression<Func<T, bool>> filter = null);//filtre olmazsa hepsini göster diye null
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
