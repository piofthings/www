using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Models
{
    /// <summary>
    /// Master for different types of EndPoints supported
    /// by PioT
    /// </summary>
    public class EndPointType<T>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DriverTypeName { get; set; }
        public T Value { get; set; }
    }
}
