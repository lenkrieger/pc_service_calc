using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pc_service_calc
{
    static class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
                Application.Run(new Form1(args[0]));
            else
                Application.Run(new Form1());
        }
    }
}
