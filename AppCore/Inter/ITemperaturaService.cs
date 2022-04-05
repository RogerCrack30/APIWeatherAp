using AppCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domai.Temperatura;

namespace AppCore.Inter
{
    public interface ITemperaturaService
    {
        root Get(string citi);


    }
}
