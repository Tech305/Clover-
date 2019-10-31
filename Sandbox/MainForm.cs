using CloverEditor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockSample
{
    public partial class MainForm : Form
    {
        private bool m_bSaveLayout = true;
        private DeserializeDockContent m_deserializeDockContent;
        private bool _showSplash;
        private SplashScreen _splashScreen;
        public WindowSettings settings;
        private Timer saveTimer;

        public MainForm()
        {
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            SetUpThemeList(Enum.GetNames(typeof(Themes)));

            SetSplashScreen(new Action(() => 
            { 
                settings = AssetDatabase.Load<WindowSettings>();
                if (settings != null)
                {
                    this.StartPosition = settings.StartPosition;
                    Location = settings.Location;
                    Size = settings.Size;
                    this.WindowState = settings.WindowState;
                }
                else
                {
                    settings = new WindowSettings();
                    this.StartPosition = settings.StartPosition;
                    this.WindowState = settings.WindowState;
                    Location = settings.Location;
                    Size = settings.Size;
                }

                ThemeEngine.SetTheme(settings.Theme, new Action(() =>
                {
                    if (File.Exists(settings.XML))
                        dockPanel.LoadFromXml(settings.XML, m_deserializeDockContent);
                    else LoadDefaultLayout();
                }));

                saveTimer = new Timer();
                saveTimer.Tick += SaveInterval;
                saveTimer.Interval = 1000;
                saveTimer.Start();
            }));
        }

        internal void Reload()
        {
            ThemeEngine.SetTheme(settings.Theme, new Action(() =>
            {
                if (File.Exists(settings.XML))
                    dockPanel.LoadFromXml(settings.XML, m_deserializeDockContent);
                else LoadDefaultLayout();
            }));
        }

        private void LoadDefaultLayout()
        {
            dockPanel.SuspendLayout(true);

            CloseAllContents();

            var scene = new Scene();
            scene.Show(dockPanel, DockState.Document);
            var game = new Game();
            game.Show(scene.Pane, DockAlignment.Right, 0.5);


            var p = new Project();
            p.Show(dockPanel, DockState.DockBottom);
            var o = new Output();
            o.Show(p.Pane, DockAlignment.Right, 0.5);


            var i = new Inspector();
            i.Show(dockPanel, DockState.DockRight);
            var h = new Hierarchy();
            h.Show(dockPanel, DockState.DockLeft);
           
            
            dockPanel.ResumeLayout(true, true);
        }

        public void SetUpThemeList(params string[] names)
        {
            foreach (var name in names)
            {
                var itme = themeMI.DropDownItems.Add(name);
                itme.Click += (a, b) =>
                {
                    ThemeEngine.SetTheme((Themes)Enum.Parse(typeof(Themes), itme.Text), new Action(() =>
                    {
                        if (File.Exists(settings.XML))
                            dockPanel.LoadFromXml(settings.XML, m_deserializeDockContent);
                    }));
                };
            }
            foreach (var name in names)
            {
                var itme = themeMB.DropDownItems.Add(name);
                itme.Click += (a, b) =>
                {
                    ThemeEngine.SetTheme((Themes)Enum.Parse(typeof(Themes), itme.Text), new Action(() =>
                    {
                        if (File.Exists(settings.XML))
                            dockPanel.LoadFromXml(settings.XML, m_deserializeDockContent);
                    }));
                };
            }
        }

        #region Methods

        private IDockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }

        private DummyDoc CreateNewDocument()
        {
            DummyDoc dummyDoc = new DummyDoc();

            int count = 1;
            string text = $"Document{count}";
            while (FindDocument(text) != null)
            {
                count++;
                text = $"Document{count}";
            }

            dummyDoc.Text = text;
            return dummyDoc;
        }
        
        private void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            Type type = Type.GetType(persistString);
            if (type != null) return (IDockContent)Activator.CreateInstance(type);
            else return default;
        }

        internal void CloseAllContents()
        {
            while(dockPanel.Panes.Count > 0)
                dockPanel.Panes[0].Dispose();
        
            // Close all other document windows
            CloseAllDocuments();

            // IMPORTANT: dispose all float windows.
            while(dockPanel.FloatWindows.Count > 0)
                dockPanel.FloatWindows[0].Dispose();

            Debug.Assert(dockPanel.Panes.Count == 0);
            Debug.Assert(dockPanel.Contents.Count == 0);
            Debug.Assert(dockPanel.FloatWindows.Count == 0);
        }

        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        
        internal void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            vsToolStripExtender1.SetStyle(mainMenu, version, theme);
            vsToolStripExtender1.SetStyle(toolBar, version, theme);
            vsToolStripExtender1.SetStyle(statusBar, version, theme);
        }

        private void SetDocumentStyle(object sender, System.EventArgs e)
        {
            DocumentStyle oldStyle = dockPanel.DocumentStyle;
            DocumentStyle newStyle;
            if (sender == menuItemDockingMdi)
                newStyle = DocumentStyle.DockingMdi;
            else if (sender == menuItemDockingWindow)
                newStyle = DocumentStyle.DockingWindow;
            else if (sender == menuItemDockingSdi)
                newStyle = DocumentStyle.DockingSdi;
            else
                newStyle = DocumentStyle.SystemMdi;

            if (oldStyle == newStyle)
                return;

            if (oldStyle == DocumentStyle.SystemMdi || newStyle == DocumentStyle.SystemMdi)
                CloseAllDocuments();

            dockPanel.DocumentStyle = newStyle;
            menuItemDockingMdi.Checked = (newStyle == DocumentStyle.DockingMdi);
            menuItemDockingWindow.Checked = (newStyle == DocumentStyle.DockingWindow);
            menuItemDockingSdi.Checked = (newStyle == DocumentStyle.DockingSdi);
            menuItemSystemMdi.Checked = (newStyle == DocumentStyle.SystemMdi);
        }

        #endregion

        #region Event Handlers
        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menuItemAbout_Click(object sender, System.EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog(this);
        }

        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
            DummyDoc dummyDoc = CreateNewDocument();
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                dummyDoc.MdiParent = this;
                dummyDoc.Show();
            }
            else
                dummyDoc.Show(dockPanel);
        }

        private void menuItemOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullName = openFile.FileName;
                string fileName = Path.GetFileName(fullName);

                if (FindDocument(fileName) != null)
                {
                    MessageBox.Show("The document: " + fileName + " has already opened!");
                    return;
                }

                DummyDoc dummyDoc = new DummyDoc();
                dummyDoc.Text = fileName;
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    dummyDoc.MdiParent = this;
                    dummyDoc.Show();
                }
                else
                    dummyDoc.Show(dockPanel);
                try
                {
                    dummyDoc.FileName = fullName;
                }
                catch (Exception exception)
                {
                    dummyDoc.Close();
                    MessageBox.Show(exception.Message);
                }

            }
        }
        
        private void menuItemClose_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                ActiveMdiChild.Close();
            else if (dockPanel.ActiveDocument != null)
                dockPanel.ActiveDocument.DockHandler.Close();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            if (m_bSaveLayout)
                dockPanel.SaveAsXml(configFile);
            else if (File.Exists(configFile))
                File.Delete(configFile);
        }

        private void menuItemNewWindow_Click(object sender, System.EventArgs e)
        {
            MainForm newWindow = new MainForm();
            newWindow.Text = newWindow.Text + " - New";
            newWindow.Show();
        }

        private void menuItemTools_Popup(object sender, System.EventArgs e)
        {
            menuItemLockLayout.Checked = !this.dockPanel.AllowEndUserDocking;
        }

        private void menuItemLockLayout_Click(object sender, System.EventArgs e)
        {
            dockPanel.AllowEndUserDocking = !dockPanel.AllowEndUserDocking;
        }
        
        private void SetSplashScreen(Action action = null)
        {
            _showSplash = true;
            _splashScreen = new SplashScreen();
            Hide();
            WindowState = FormWindowState.Minimized;
            _splashScreen.Visible = true;
            _splashScreen.TopMost = true;


            Timer _timer = new Timer();
            _timer.Tick += (sender, e) =>
            {
                _splashScreen.Visible = false;
                _timer.Enabled = false;
                _showSplash = false;
                if (action != null) action?.Invoke();
            };
            _timer.Interval = 4000;
            _timer.Enabled = true;
        }
        
        private void menuItemShowDocumentIcon_Click(object sender, System.EventArgs e)
        {
            dockPanel.ShowDocumentIcon = menuItemShowDocumentIcon.Checked = !menuItemShowDocumentIcon.Checked;
        }
        
        private void SaveInterval(object sender, EventArgs e)
        {
            settings.Location = Location;
            settings.Size = Size;
            settings.StartPosition = this.StartPosition;
            settings.WindowState = this.WindowState != FormWindowState.Minimized ? WindowState : FormWindowState.Normal;
            settings.XML = AssetDatabase.settingsLayoutFile;
            dockPanel.SaveAsXml(settings.XML);
            AssetDatabase.Save(settings);
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveInterval(null, null);
        }
        
        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = dockPanel.Panes.ToList().Find(x => x.ActiveContent.GetType().Equals(typeof(Preference)));
            if (o != null)
                o.Dispose();
            new Preference().Show(dockPanel, DockState.Float);
        }
    }
}