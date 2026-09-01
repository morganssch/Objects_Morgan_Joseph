using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Morgan_Joseph
{
    interface IBootUp // Define an interface named IBootUp
    {
        public bool IsOn { get; set; } // Declare a property named IsOn of type bool with get and set accessors
        public void PowerOnOff(); // Declare a method named PowerOnOff that returns void
    } 
}
