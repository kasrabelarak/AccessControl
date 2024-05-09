using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Contract.Devices
{
    public interface IDevice
    {
        bool Connect();
        void Disconnect(string ipAddress);
 
    }

}
