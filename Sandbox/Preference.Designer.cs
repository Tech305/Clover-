namespace DockSample
{
    partial class Preference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preference));
            this.contextMenuTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pgv1 = new System.Windows.Forms.PropertyGrid();
            this.contextMenuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuTabPage
            // 
            this.contextMenuTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            this.contextMenuTabPage.Name = "contextMenuTabPage";
            this.contextMenuTabPage.Size = new System.Drawing.Size(121, 70);
            // 
            // menuItem3
            // 
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(120, 22);
            this.menuItem3.Text = "Option &1";
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(120, 22);
            this.menuItem4.Text = "Option &2";
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(120, 22);
            this.menuItem5.Text = "Option &3";
            // 
            // pgv1
            // 
            this.pgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgv1.Location = new System.Drawing.Point(0, 4);
            this.pgv1.Name = "pgv1";
            this.pgv1.Size = new System.Drawing.Size(379, 389);
            this.pgv1.TabIndex = 1;
            this.pgv1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgv1_PropertyValueChanged);
            // 
            // Preference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(379, 393);
            this.Controls.Add(this.pgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preference";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabPageContextMenuStrip = this.contextMenuTabPage;
            this.TabText = "Preference";
            this.Text = "Preference";
            this.Load += new System.EventHandler(this.Preference_Load);
            this.contextMenuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuTabPage;
        private System.Windows.Forms.ToolStripMenuItem menuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItem5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PropertyGrid pgv1;
    }
}