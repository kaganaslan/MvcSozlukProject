using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //Burada bir sürü tablo olabileceği için bunu parametreli hale getirerek genel bi repository oluşturdum ve bunları parametreli şekilde çağırdım.
        List<T> GetAll();
        void Insert(T p);
        void Delete(T p);
        void update(T p);
    }
}
