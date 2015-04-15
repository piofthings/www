using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Piofthings.Web.Models.Device
{
    public class Device
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Account { get; set; }
    }
}