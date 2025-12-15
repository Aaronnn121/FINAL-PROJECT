using System;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    //FINAL PROJECT: ESTANOCO, PASCUAL, BAUTISTA

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
