using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Attachment : IEntity
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public string AttachmentName { get; set; }

    }
}
