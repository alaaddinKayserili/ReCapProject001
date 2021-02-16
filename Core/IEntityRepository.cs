using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core
{
    public interface IEntityRepository<T>     
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //filter verilebilirde verilmeye bilinirde  null kaynaklı
        T Get(Expression<Func<T,bool>> filter); // fiter vermek zorunda
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
