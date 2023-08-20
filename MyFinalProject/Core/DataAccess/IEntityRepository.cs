using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint T
    //where T : class ifadesi burdaki T generic yapının referans tipinin class olması için kısıtlanıyor. 
    //where T : class, IEntity   burda da bu T generik tipi class ve IEntity class' dan başkası olmasın. 
    //class : referans tip sınıf olmalı
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
