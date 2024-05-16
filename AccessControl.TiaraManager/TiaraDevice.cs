using PalizTiara.Api;
using PalizTiara.Protocol;
using PalizTiara.Protocol.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessControl.TiaraManager
{
    public class TiaraDevice 
    {

        private readonly TiaraServerManager ServerManager;
        public List<OnlineDeviceDTO>  OnlineDeviceList {  get; private set; }= new List<OnlineDeviceDTO>();
        public TiaraDevice()
        {

            TiaraServerManager.Bootstrapper();
            TiaraSettings.Instance.Port = 1883;
            var tiaraUacManager = new TiaraUacManager();
            ServerManager = new TiaraServerManager(TiaraSettings.Instance, tiaraUacManager);
        }

        public async Task<List<OnlineDeviceDTO>>  Connect()
        {
            ServerManager.Start();
            var Devices = await ServerManager.GetStatusAsyncTask();

          
            Devices.Where(a => a.IsOnline).ToList().
                ForEach(a => {

                    OnlineDeviceList.Add(new OnlineDeviceDTO { DeviceName = a.TerminalName });   
               
                    });

            return OnlineDeviceList;
        }

        public void Disconnect(string ipAddress)
        {
            ServerManager.Stop();
        }


        public async Task  Get()
        {
            var Devices = await ServerManager.GetStatusAsyncTask();
        }
    }
}
