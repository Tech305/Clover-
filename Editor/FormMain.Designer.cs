using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace CloverEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;


        private ElementHost dockingManagerHost = new ElementHost();
        private MenuStrip menuStrip1 = new MenuStrip();

        private ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem();

        private ToolStripMenuItem menuItemExit = new ToolStripMenuItem();
        private ToolStripMenuItem themeToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemVS2013Dark = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemVS2010 = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemGeneric = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemExpressionDark = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemMetro = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemExpressionLight = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemVs2013 = new ToolStripMenuItem();
        private ToolStripMenuItem menuItemAero = new ToolStripMenuItem();

        private ToolStripComboBox layoutToolStripMenuItem = new ToolStripComboBox();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            InitializeDockingManager();
            InitializeMenuStrip();
            InitializeFrom();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeMenuStrip()
        {
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.fileToolStripMenuItem,
                    this.themeToolStripMenuItem,
                    this.layoutToolStripMenuItem,
                });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1795, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuItemExit,
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(121, 48);
            this.fileToolStripMenuItem.Text = "File";
            // menuItemExit
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(396, 46);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);

            // themeToolStripMenuItem
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuItemVS2010,
                this.menuItemMetro,
                this.menuItemGeneric,
                this.menuItemExpressionDark,
                this.menuItemExpressionLight,
                this.menuItemVs2013,
                this.menuItemVS2013Dark,
                this.menuItemAero
            });
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(121, 48);
            this.themeToolStripMenuItem.Text = "Theme";
            // menuItemVS2010
            this.menuItemVS2010.Name = "menuItemVS2010";
            this.menuItemVS2010.Size = new System.Drawing.Size(396, 46);
            this.menuItemVS2010.Text = "VS2010";
            this.menuItemVS2010.Click += new System.EventHandler(this.menuItemVS2010_Click);
            // menuItemMetro
            this.menuItemMetro.Name = "menuItemMetro";
            this.menuItemMetro.Size = new System.Drawing.Size(396, 46);
            this.menuItemMetro.Text = "Metro";
            this.menuItemMetro.Click += new System.EventHandler(this.menuItemMetro_Click);
            // menuItemGeneric
            this.menuItemGeneric.Name = "menuItemGeneric";
            this.menuItemGeneric.Size = new System.Drawing.Size(396, 46);
            this.menuItemGeneric.Text = "Generic";
            this.menuItemGeneric.Click += new System.EventHandler(this.menuItemGeneric_Click);
            // menuItemExpressionDark
            this.menuItemExpressionDark.Name = "menuItemExpressionDark";
            this.menuItemExpressionDark.Size = new System.Drawing.Size(396, 46);
            this.menuItemExpressionDark.Text = "Expression Dark";
            this.menuItemExpressionDark.Click += new System.EventHandler(this.menuItemExpressionDark_Click);
            // menuItemExpressionLight
            this.menuItemExpressionLight.Name = "menuItemExpressionLight";
            this.menuItemExpressionLight.Size = new System.Drawing.Size(396, 46);
            this.menuItemExpressionLight.Text = "Expression Light";
            this.menuItemExpressionLight.Click += new System.EventHandler(this.menuItemExpressionLight_Click);
            // menuItemVs2013
            this.menuItemVs2013.Checked = true;
            this.menuItemVs2013.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemVs2013.Name = "menuItemVs2013";
            this.menuItemVs2013.Size = new System.Drawing.Size(396, 46);
            this.menuItemVs2013.Text = "VS2013";
            this.menuItemVs2013.Click += new System.EventHandler(this.vS2013ToolStripMenuItem_Click);
            // menuItemVS2013Dark
            this.menuItemVS2013Dark.Name = "menuItemVS2013Dark";
            this.menuItemVS2013Dark.Size = new System.Drawing.Size(396, 46);
            this.menuItemVS2013Dark.Text = "VS 2013 Dark";
            this.menuItemVS2013Dark.Click += new System.EventHandler(this.menuItemAero_Vs2013Dark);
            // menuItemAero
            this.menuItemAero.Name = "menuItemAero";
            this.menuItemAero.Size = new System.Drawing.Size(396, 46);
            this.menuItemAero.Text = "Aero";
            this.menuItemAero.Click += new System.EventHandler(this.menuItemAero_Click);

            // layoutToolStripMenuItem
            //this.layoutToolStripMenuItem.Items;
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(221, 48);
            this.layoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            this.layoutToolStripMenuItem.SelectedIndex = this.layoutToolStripMenuItem.Items.Count > 0 ? 0 : this.layoutToolStripMenuItem.SelectedIndex;
            this.layoutToolStripMenuItem.Text = $"Layout {this.layoutToolStripMenuItem.Items[this.layoutToolStripMenuItem.SelectedIndex]}";

        }


        private void InitializeFrom()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1066);
            this.Controls.Add(this.dockingManagerHost);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMain";
            this.Text = "Clover™ Editor";
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
        private void InitializeDockingManager()
        {
            this.dockingManagerHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockingManagerHost.Location = new System.Drawing.Point(0, 58);
            this.dockingManagerHost.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dockingManagerHost.Name = "dockingManagerHost";
            this.dockingManagerHost.Size = new System.Drawing.Size(1795, 1008);
            this.dockingManagerHost.TabIndex = 0;
            this.dockingManagerHost.Text = "elementHost1";
            this.dockingManagerHost.Child = null;
        }
        #endregion
    }
}

