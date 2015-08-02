using PiOfThings.GpioUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Models
{
    public class GpioState
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public GpioId PinId { get; set; }
        public GpioPinState PinState  { get; set; }
    }
}
