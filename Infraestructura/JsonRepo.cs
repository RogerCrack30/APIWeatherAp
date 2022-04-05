using Domai.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Domai.Temperatura;

namespace Infraestructura
{
  public  class JsonRepo: IModel
    {
        public root info;
        private const string llave = "11e7dcb05514a41d68feb555953b8377";
        public root Get(string citi)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", citi, llave);

                    var json = web.DownloadString(url);

                    info = JsonConvert.DeserializeObject<root>(json);
                   


                    return info;

                }
                catch (Exception)
                {
                    return info = null;
                }



            }




        }
    }
}
