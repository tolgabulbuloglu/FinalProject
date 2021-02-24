using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint T'yi kısıtlandırmak
    //class yazmak class olacak demek değildir, referans tip olmak zorunda demektir
    //new() yazarak newlenebilir olmalı şartı koyuyoruz. Böylece IEntity'nin kendisi T olamıyor
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //(Expression<Func<T,bool>> filter=null) ==> GetAll içerisine Linq ile filtreler yazabilmemizi sağlayan kod
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
