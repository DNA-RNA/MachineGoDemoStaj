using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using MachineGoDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MachineManager : IMachineService
    {
        IMachineDal _machineDal;
        public MachineManager(IMachineDal machineDal)
        {
            _machineDal = machineDal;
        }
       
        public IResult Add(Machine entity)
        {
         
            _machineDal.Add(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Machine>> GetAll()
        {
            return new SuccessDataResult<List<Machine>>(_machineDal.GetAll());
        }

        public IDataResult<Machine> GetById(int id)
        {
            return new SuccessDataResult<Machine>(_machineDal.Get(m => m.Id == id));
        }

        public IDataResult<List<MachineDetailDto>> GetMachineDetails()
        {
            return new SuccessDataResult<List<MachineDetailDto>>(_machineDal.GetMachineDetails());
        }
    }
}
