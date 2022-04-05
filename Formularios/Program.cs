using AppCore.Inter;
using AppCore.Services;
using Autofac;
using Domai.Interface;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<JsonRepo>().As<IModel>();
            builder.RegisterType<TemperaturaService>().As<ITemperaturaService>();
            var container = builder.Build();
            Application.Run(new Form1(container.Resolve<ITemperaturaService>()));
        }
    }
}
