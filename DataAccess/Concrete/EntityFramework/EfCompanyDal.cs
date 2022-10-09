using DataAccess.Abstract;
using MachineGoDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal :   EfEntityRepositoryBase<Company, MachinGoContext>, ICompanyDal
    {
    }
}
