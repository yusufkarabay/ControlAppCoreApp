using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Repository;
using ControlApp.Repository.Repositories;
using ControlApp.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;

namespace ControlAppUI
{
    internal static class Program
    {
      


        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Application.Run(new Test());
        }
    }
}

