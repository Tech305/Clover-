using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Media;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Layout.Serialization;
using Xceed.Wpf.AvalonDock.Themes;

namespace CloverEditor
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DockingManager _dockingManager = new DockingManager();
        private bool loadedFromFile;
        protected override void OnLoad(EventArgs e)
        {
            _dockingManager.Theme = new Vs2013DarkTheme();
            var background_brush = (SolidColorBrush)_dockingManager.Background;
            var forground_brush = (SolidColorBrush)_dockingManager.Foreground;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(background_brush.Color.A, background_brush.Color.R, background_brush.Color.G, background_brush.Color.B);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            LoadLayout();
            dockingManagerHost.Child = _dockingManager;
            base.OnLoad(e);

            GetPanel();
        }        
        protected override void OnClosing(CancelEventArgs e)
        {
            SaveLayout();
            base.OnClosing(e);
        }


        /// <summary>
        /// Load layout from file. If this failes load default layout
        /// </summary>
        /// <returns></returns>
        private void LoadLayout()
        {
            try
            {
                var currentContentsList = _dockingManager.Layout.Descendents().OfType<LayoutContent>().Where(c => c.ContentId != null).ToArray();
                var serializer = new XmlLayoutSerializer(_dockingManager);
                serializer.LayoutSerializationCallback += (s, args) =>
                {
                    switch (args.Model.ContentId)
                    {
                        case "toolWindow1":
                            args.Content = new System.Windows.Controls.TextBlock() { Text = args.Model.ContentId };
                            break;
                        default:
                            args.Content = new System.Windows.Controls.TextBox() { Text = args.Model.ContentId };
                            break;
                    }

                };
                using (var stream = new StreamReader(@".\editor_user_layout.config"))
                serializer.Deserialize(stream);
                loadedFromFile = true;
            }
            catch
            {
                var serializer = new XmlLayoutSerializer(_dockingManager);
                serializer.LayoutSerializationCallback += (s, args) =>
                {
                    switch (args.Model.ContentId)
                    {
                        case "toolWindow1":
                            args.Content = new System.Windows.Controls.TextBlock() { Text = args.Model.ContentId };
                            break;
                        default:
                            args.Content = new System.Windows.Controls.TextBox() { Text = args.Model.ContentId };
                            break;
                    }

                };
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = $"{assembly.GetName().Name}.DefaultLayout.xml";
                string result = string.Empty;
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
                serializer.Deserialize(new StringReader(result));
                loadedFromFile = false;
            }
        }
        private void SaveLayout()
        {
            if (!loadedFromFile) return;
            try
            {
                var serializer = new XmlLayoutSerializer(_dockingManager);
                using (var stream = new StreamWriter(@".\editor_user_layout.config"))
                    serializer.Serialize(stream);
            }
            catch (Exception ex)
            {
                throw new IOException(ex.ToString());
            }
        }

        public void GetPanel()
        {
            var documents = new List<LayoutDocument>();
            var panels = new List<LayoutAnchorable>();
            foreach (var doc in _dockingManager.Layout.Descendents().OfType<LayoutDocument>()) documents.Add(doc);
            foreach (var pan in _dockingManager.Layout.Descendents().OfType<LayoutAnchorable>()) panels.Add(pan);


            Console.WriteLine($"Found {documents.Count} document(s).");
            Console.WriteLine($"Found {panels.Count} panels(s).");
        }

        #region Actions
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Theming
        private void menuItemVS2010_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.VS2010Theme();
            this.SetChecked(menuItemVS2010);
        }
        private void menuItemMetro_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.MetroTheme();
            this.SetChecked(menuItemMetro);
        }
        private void menuItemGeneric_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.GenericTheme();
            this.SetChecked(menuItemGeneric);
        }
        private void menuItemExpressionDark_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.ExpressionDarkTheme();
            this.SetChecked(menuItemExpressionDark);
        }
        private void menuItemExpressionLight_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.ExpressionLightTheme();
            this.SetChecked(menuItemExpressionLight);
        }
        private void vS2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.Vs2013LightTheme();
            this.SetChecked(menuItemVs2013);
        }
        private void menuItemAero_Vs2013Dark(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.Vs2013DarkTheme();
            this.SetChecked(menuItemVS2013Dark);
        }
        private void SetChecked(ToolStripMenuItem toCheck)
        {
            menuItemVS2013Dark.Checked = false;
            menuItemGeneric.Checked = false;
            menuItemVS2010.Checked = false;
            menuItemExpressionDark.Checked = false;
            menuItemMetro.Checked = false;

            toCheck.Checked = true;
        }
        private void menuItemAero_Click(object sender, EventArgs e)
        {
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.AeroTheme();
            this.SetChecked(menuItemAero);
        }
        #endregion
    }
}
