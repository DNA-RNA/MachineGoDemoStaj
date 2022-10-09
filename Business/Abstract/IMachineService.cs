using Core.Utilities;
using Entities.Concrete;
using MachineGoDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMachineService : IServices<Machine>
    {

        IDataResult<List<MachineDetailDto>> GetMachineDetails();
    }
}
