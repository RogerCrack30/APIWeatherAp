using AppCore.Inter;
using AppCore.Services;
using Domai;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static Domai.Temperatura;

namespace Formularios
{
    public partial class Form1 : Form
    {

        ITemperaturaService temperaturaService;
        public Form1(ITemperaturaService temperaturaService)
        {

           this.temperaturaService = temperaturaService;
            InitializeComponent();
        }
        
        private void Txtmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                root rot = temperaturaService.Get(txtcity.Text);

                double temp = rot.main.Temp - 273.15;

                double presion = rot.main.pressure;
                double humedad = rot.main.humidity;

                long sunrise = rot.sys.sunrise;
                long sunset = rot.sys.sunset;
                double viento = rot.wind.speed;

                lbldetaye.Text = rot.weather[0].main;
                lblcondi.Text = rot.weather[0].description;

                lbltemperatura.Text = temp.ToString("0,0")+ "C°";
                lblpresion.Text = presion.ToString("0,0");
                lblhumedad.Text = humedad.ToString("0,0")+ " %";
                lblvelocidad.Text = viento.ToString("0,0") + " a km/h";
                lblamanecer.Text = sunrise.ToString("0,0");
                lblatardecer.Text = sunset.ToString("0,0");

            }
            catch (NullReferenceException)
            {
               MessageBox.Show ("no  se encopntrom la ciudad");
            }

        }

       






     
    }
}
