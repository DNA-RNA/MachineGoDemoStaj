using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
        public class AttachmentManager : IAttachmentService
        {
        IAttachmentDal _attachmentDal;
        public AttachmentManager(IAttachmentDal attachmentDal)
        {
            _attachmentDal = attachmentDal;
        }

        public IResult Add(Attachment entity)
        {

            _attachmentDal.Add(entity);
            return new SuccessResult();
        }
        public IDataResult<List<Attachment>> GetAll()
        {
            return new SuccessDataResult<List<Attachment>>(_attachmentDal.GetAll());
        }

        public IDataResult<Attachment> GetById(int id)
        {
            return new SuccessDataResult<Attachment>(_attachmentDal.Get(a => a.Id == id));
        }

     
    }
}
