using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace DockSample
{
    public partial class Preference : ToolWindow
    {
        public Preference()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Preference_Load(object sender, EventArgs e)
        {
            pgv1.SelectedObject = Program._mainWin.settings;

        }

        private void pgv1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Program._mainWin.Reload();
        }
    }
}