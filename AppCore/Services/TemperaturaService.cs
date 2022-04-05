using AppCore.Inter;
using Domai.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domai.Temperatura;

namespace AppCore.Services
{
   public  class TemperaturaService: ITemperaturaService
    {

        public IModel model;

        public TemperaturaService(IModel model)
        {
            this.model = model;
        }

        public root Get(string citi)
        {
            return model.Get(citi);
        }
    }
}
