using DataAccess.Abstract;
using Entities.Concrete;
using MachineGoDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMachineDal : EfEntityRepositoryBase<Machine, MachinGoContext>, IMachineDal
    {
        public List<MachineDetailDto> GetMachineDetails()
        {
            using (MachinGoContext context = new MachinGoContext())
            {
                var result = from p in context.machines
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join b in context.Brands 
                             on p.BrandId equals b.Id
                             join t in context.MachineTypes
                             on p.TypeId equals t.Id
                             join cm in context.Companies
                             on p.CompanyId equals cm.Id
                         
                             select new MachineDetailDto
                             {
                                 Id = p.Id,
                                 CategoryName  = c.CategoryName,
                                 BrandName = b.BrandName,
                                 TypeName = t.TypeName,
                                 Model = p.Model,
                                 ModelYear = p.ModelYear,
                                 CompanyName = cm.CompanyName
                             };

                return result.ToList();
            }
        }
    }
}
