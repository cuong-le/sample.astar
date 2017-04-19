using System;
using System.Windows.Forms;

namespace CGS.Sample.AStar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Start());
        }
    }
}
