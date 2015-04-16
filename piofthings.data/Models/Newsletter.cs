using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Models
{
    public class Newsletter
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string Validated { get; set; }
        public string Unsubscribed { get; set; }
    }
}
