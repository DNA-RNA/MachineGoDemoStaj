using DataAccess.Abstract;
using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMachineTypeDal : EfEntityRepositoryBase<MachineType, MachinGoContext>, IMachineTypeDal
    {
    }
}
