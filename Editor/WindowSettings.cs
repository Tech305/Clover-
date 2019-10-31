using System.Drawing;
using System.Windows.Forms;

namespace CloverEditor
{
    public class WindowSettings
    {
        public Point Location = new Point(500, 200);
        public Size Size  = new Size(900, 500);
        public FormWindowState WindowState = FormWindowState.Normal;
        public string XML = string.Empty;
        public FormStartPosition StartPosition = FormStartPosition.CenterScreen;
        public Themes Theme { get; set; } = Themes.Dark2K15;
    }
}
