using ControlAppDesktop;
using ControlAppDesktop.Forms;

namespace ControlAppUI
{
    internal static class Program
    {
      


        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Application.Run(new Login());
        }
    }
}

