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
        public Guid Key { get; set; }
        public string EmailAddress { get; set; }
        public bool Validated { get; set; }
        public bool Unsubscribed { get; set; }
    }
}
