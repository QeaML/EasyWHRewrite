using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EasyWHRewrite
{
    static class Program
    {
        //[DllImport("kernel32", SetLastError = true)]
        //private static extern IntPtr LoadLibrary(string lpFileName);

        //private static bool CheckLibrary(string fileName)
        //{
        //    return LoadLibrary(fileName) == IntPtr.Zero;
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //if (!CheckLibrary("ServiceStack.Text.dll")
            //    || !CheckLibrary("System.Memory.dll"))
            //{
            //    MessageBox.Show(
            //        "A required DLL file is missing!",
            //        "EasyWH :: Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //    return;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm M = new MainForm(true);
            Application.Run(M);
        }
    }
}
