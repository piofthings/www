using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Models
{
    public class EndPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("ParentDevice")]
        public int ParentDeviceId { get; set; }
        public Device ParentDevice { get; set; }
        public int EndPointType { get; set; }
    }
}
