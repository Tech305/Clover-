using System;
using System.Windows.Forms;

namespace DockSample
{
    static class Program
    {
        internal static MainForm _mainWin;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _mainWin = new MainForm();
            Application.Run(_mainWin);
        }
    }
}