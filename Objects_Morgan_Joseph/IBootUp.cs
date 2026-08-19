using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Morgan_Joseph
{
    interface IBootUp
    {
        public bool IsOn { get; set; }
        public void PowerOnOff();
    }
}
