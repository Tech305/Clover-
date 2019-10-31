using System;

namespace DockSample
{
    public partial class Project : ToolWindow
    {
        public Project()
        {
            InitializeComponent();
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            treeView1.RightToLeftLayout = RightToLeftLayout;
        }
    }
}