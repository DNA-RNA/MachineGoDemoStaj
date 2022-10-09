using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MachineTypeManager : IMachineTypeService
    {
        IMachineTypeDal _machineTypeDal;
        public MachineTypeManager(IMachineTypeDal machineTypeDal)
        {
            _machineTypeDal = machineTypeDal;
        }

        public IResult Add(MachineType entity)
        {
            _machineTypeDal.Add(entity);
            return new SuccessResult();
        }
        public IDataResult<List<MachineType>> GetAll()
        {
            return new SuccessDataResult<List<MachineType>>(_machineTypeDal.GetAll());
        }

        public IDataResult<MachineType> GetById(int id)
        {
            return new SuccessDataResult<MachineType>(_machineTypeDal.Get(m => m.Id == id));
        }
    }
}
