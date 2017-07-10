using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.DataAccess.DAL
{
    public interface IRepository
    {
        List<T> GetAll<T>() where T : class;
        
       
        bool Create<T>(T obj) where T : class;
        bool Update<T>(T obj) where T : class;
        bool Delete<T>(T obj) where T : class;
        bool Save();
    }
}
