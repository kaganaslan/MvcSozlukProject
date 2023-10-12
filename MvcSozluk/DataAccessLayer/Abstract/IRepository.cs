using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //Burada bir sürü tablo olabileceği için bunu parametreli hale getirerek genel bi repository oluşturdum ve bunları parametreli şekilde çağırdım.
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void update(T p);

        List<T> List(Expression<Func<T, bool>> filter); //şartlı listeleme için adı osman olanları getir gibi..
    }
}
