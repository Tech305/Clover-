using CloverEditor;
using System;
using System.Windows.Forms;

namespace DockSample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.themeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSolutionExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPropertyWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolbox = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOutputWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLockLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowDocumentIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDockingMdi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDockingSdi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDockingWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSystemMdi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showRightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.AccountDetail = new System.Windows.Forms.ToolStripDropDownButton();
            this.themeMB = new System.Windows.Forms.ToolStripDropDownButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2013BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.vS2003Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2003Theme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.vS2013LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013LightTheme();
            this.vS2013DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme();
            this.vS2012LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            this.vS2012BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme();
            this.vS2012DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme();
            this.vsToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.editToolStripMenuItem,
            this.menuItemView,
            this.menuItemTools,
            this.menuItemWindow,
            this.menuItemHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.menuItemWindow;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(408, 24);
            this.mainMenu.TabIndex = 7;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemClose,
            this.preferenceToolStripMenuItem,
            this.menuItem4,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(180, 22);
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.menuItemOpen.Text = "&Open...";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(180, 22);
            this.menuItemClose.Text = "&Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferenceToolStripMenuItem.Text = "Preference";
            this.preferenceToolStripMenuItem.Click += new System.EventHandler(this.preferenceToolStripMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeMI,
            this.menuItem2,
            this.menuItemSolutionExplorer,
            this.menuItemPropertyWindow,
            this.menuItemToolbox,
            this.menuItemOutputWindow,
            this.menuItemTaskList});
            this.menuItemView.MergeIndex = 1;
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(44, 20);
            this.menuItemView.Text = "&View";
            // 
            // themeMI
            // 
            this.themeMI.Name = "themeMI";
            this.themeMI.Size = new System.Drawing.Size(185, 22);
            this.themeMI.Text = "Theme";
            // 
            // menuItem2
            // 
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // menuItemSolutionExplorer
            // 
            this.menuItemSolutionExplorer.Name = "menuItemSolutionExplorer";
            this.menuItemSolutionExplorer.Size = new System.Drawing.Size(185, 22);
            this.menuItemSolutionExplorer.Text = "&Project";
            // 
            // menuItemPropertyWindow
            // 
            this.menuItemPropertyWindow.Name = "menuItemPropertyWindow";
            this.menuItemPropertyWindow.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuItemPropertyWindow.Size = new System.Drawing.Size(185, 22);
            this.menuItemPropertyWindow.Text = "&Property Window";
            // 
            // menuItemToolbox
            // 
            this.menuItemToolbox.Name = "menuItemToolbox";
            this.menuItemToolbox.Size = new System.Drawing.Size(185, 22);
            this.menuItemToolbox.Text = "&Toolbox";
            // 
            // menuItemOutputWindow
            // 
            this.menuItemOutputWindow.Name = "menuItemOutputWindow";
            this.menuItemOutputWindow.Size = new System.Drawing.Size(185, 22);
            this.menuItemOutputWindow.Text = "&Output Window";
            // 
            // menuItemTaskList
            // 
            this.menuItemTaskList.Name = "menuItemTaskList";
            this.menuItemTaskList.Size = new System.Drawing.Size(185, 22);
            this.menuItemTaskList.Text = "Task &List";
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLockLayout,
            this.menuItemShowDocumentIcon,
            this.menuItem3,
            this.menuItemDockingMdi,
            this.menuItemDockingSdi,
            this.menuItemDockingWindow,
            this.menuItemSystemMdi,
            this.menuItem5,
            this.showRightToLeft});
            this.menuItemTools.MergeIndex = 2;
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(47, 20);
            this.menuItemTools.Text = "&Tools";
            this.menuItemTools.DropDownOpening += new System.EventHandler(this.menuItemTools_Popup);
            // 
            // menuItemLockLayout
            // 
            this.menuItemLockLayout.Name = "menuItemLockLayout";
            this.menuItemLockLayout.Size = new System.Drawing.Size(255, 22);
            this.menuItemLockLayout.Text = "&Lock Layout";
            this.menuItemLockLayout.Click += new System.EventHandler(this.menuItemLockLayout_Click);
            // 
            // menuItemShowDocumentIcon
            // 
            this.menuItemShowDocumentIcon.Name = "menuItemShowDocumentIcon";
            this.menuItemShowDocumentIcon.Size = new System.Drawing.Size(255, 22);
            this.menuItemShowDocumentIcon.Text = "&Show Document Icon";
            this.menuItemShowDocumentIcon.Click += new System.EventHandler(this.menuItemShowDocumentIcon_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(252, 6);
            // 
            // menuItemDockingMdi
            // 
            this.menuItemDockingMdi.Checked = true;
            this.menuItemDockingMdi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemDockingMdi.Name = "menuItemDockingMdi";
            this.menuItemDockingMdi.Size = new System.Drawing.Size(255, 22);
            this.menuItemDockingMdi.Text = "Document Style: Docking &MDI";
            this.menuItemDockingMdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemDockingSdi
            // 
            this.menuItemDockingSdi.Name = "menuItemDockingSdi";
            this.menuItemDockingSdi.Size = new System.Drawing.Size(255, 22);
            this.menuItemDockingSdi.Text = "Document Style: Docking &SDI";
            this.menuItemDockingSdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemDockingWindow
            // 
            this.menuItemDockingWindow.Name = "menuItemDockingWindow";
            this.menuItemDockingWindow.Size = new System.Drawing.Size(255, 22);
            this.menuItemDockingWindow.Text = "Document Style: Docking &Window";
            this.menuItemDockingWindow.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemSystemMdi
            // 
            this.menuItemSystemMdi.Name = "menuItemSystemMdi";
            this.menuItemSystemMdi.Size = new System.Drawing.Size(255, 22);
            this.menuItemSystemMdi.Text = "Document Style: S&ystem MDI";
            this.menuItemSystemMdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(252, 6);
            // 
            // showRightToLeft
            // 
            this.showRightToLeft.Name = "showRightToLeft";
            this.showRightToLeft.Size = new System.Drawing.Size(255, 22);
            this.showRightToLeft.Text = "Show &Right-To-Left";
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewWindow});
            this.menuItemWindow.MergeIndex = 2;
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemNewWindow
            // 
            this.menuItemNewWindow.Name = "menuItemNewWindow";
            this.menuItemNewWindow.Size = new System.Drawing.Size(145, 22);
            this.menuItemNewWindow.Text = "&New Window";
            this.menuItemNewWindow.Click += new System.EventHandler(this.menuItemNewWindow_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.MergeIndex = 3;
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(185, 22);
            this.menuItemAbout.Text = "&About DockSample...";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Black;
            this.statusBar.Location = new System.Drawing.Point(0, 421);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(952, 22);
            this.statusBar.TabIndex = 4;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            // 
            // toolBar
            // 
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageList = this.imageList;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountDetail,
            this.themeMB});
            this.toolBar.Location = new System.Drawing.Point(544, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(408, 25);
            this.toolBar.TabIndex = 6;
            // 
            // AccountDetail
            // 
            this.AccountDetail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AccountDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AccountDetail.Image = ((System.Drawing.Image)(resources.GetObject("AccountDetail.Image")));
            this.AccountDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccountDetail.Name = "AccountDetail";
            this.AccountDetail.Size = new System.Drawing.Size(29, 22);
            this.AccountDetail.Text = "toolStripDropDownButton1";
            // 
            // themeMB
            // 
            this.themeMB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.themeMB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.themeMB.Image = ((System.Drawing.Image)(resources.GetObject("themeMB.Image")));
            this.themeMB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeMB.Name = "themeMB";
            this.themeMB.Size = new System.Drawing.Size(57, 22);
            this.themeMB.Text = "Theme";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dockPanel.Location = new System.Drawing.Point(0, 27);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.ShowAutoHideContentOnHover = false;
            this.dockPanel.Size = new System.Drawing.Size(952, 394);
            this.dockPanel.TabIndex = 0;
            this.dockPanel.Theme = this.vS2013BlueTheme1;
            // 
            // vsToolStripExtender1
            // 
            this.vsToolStripExtender1.DefaultRenderer = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.mainMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolBar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 27);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(952, 443);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Clover™ Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        internal System.Windows.Forms.ImageList imageList;
        internal System.Windows.Forms.ToolStrip toolBar;
        internal System.Windows.Forms.MenuStrip mainMenu;
        internal System.Windows.Forms.ToolStripMenuItem menuItemFile;
        internal System.Windows.Forms.ToolStripMenuItem menuItemNew;
        internal System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        internal System.Windows.Forms.ToolStripSeparator menuItem4;
        internal System.Windows.Forms.ToolStripMenuItem menuItemExit;
        internal System.Windows.Forms.ToolStripMenuItem menuItemView;
        internal System.Windows.Forms.ToolStripMenuItem menuItemSolutionExplorer;
        internal System.Windows.Forms.ToolStripMenuItem menuItemPropertyWindow;
        internal System.Windows.Forms.ToolStripMenuItem menuItemToolbox;
        internal System.Windows.Forms.ToolStripMenuItem menuItemOutputWindow;
        internal System.Windows.Forms.ToolStripMenuItem menuItemTaskList;
        internal System.Windows.Forms.ToolStripSeparator menuItem2;
        internal System.Windows.Forms.ToolStripMenuItem menuItemTools;
        internal System.Windows.Forms.ToolStripMenuItem menuItemLockLayout;
        internal System.Windows.Forms.ToolStripSeparator menuItem3;
        internal System.Windows.Forms.ToolStripMenuItem menuItemDockingMdi;
        internal System.Windows.Forms.ToolStripMenuItem menuItemDockingSdi;
        internal System.Windows.Forms.ToolStripMenuItem menuItemDockingWindow;
        internal System.Windows.Forms.ToolStripMenuItem menuItemSystemMdi;
        internal System.Windows.Forms.ToolStripSeparator menuItem5;
        internal System.Windows.Forms.ToolStripMenuItem menuItemShowDocumentIcon;
        internal System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        internal System.Windows.Forms.ToolStripMenuItem menuItemNewWindow;
        internal System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        internal System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        internal System.Windows.Forms.StatusStrip statusBar;
        internal System.Windows.Forms.ToolStripMenuItem showRightToLeft;
        internal WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2013LightTheme vS2013LightTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme vS2013BlueTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme vS2013DarkTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2012LightTheme vS2012LightTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme vS2012BlueTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme vS2012DarkTheme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2003Theme vS2003Theme1;
        internal WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        internal WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender1;
        internal System.Windows.Forms.ToolStripMenuItem themeMI;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.ToolStripDropDownButton themeMB;
        private System.Windows.Forms.ToolStripDropDownButton AccountDetail;
        internal ToolStripMenuItem menuItemClose;
        private ToolStripMenuItem preferenceToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}