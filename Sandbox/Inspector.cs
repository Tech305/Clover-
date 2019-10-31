using System.Windows.Forms;

namespace DockSample
{
    public partial class Inspector : ToolWindow
    {
        public Inspector()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            propertyGrid.SelectedObject = propertyGrid;
        }
    }
}