using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IServices<T> where T : class
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IDataResult<T> GetById(int id);

    }
}
