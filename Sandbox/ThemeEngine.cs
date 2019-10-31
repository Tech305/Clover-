
namespace DockSample
{
    using CloverEditor;
    using System;
    using System.IO;
    using System.Windows.Forms;
    using WeifenLuo.WinFormsUI.Docking;

    public class ThemeEngine
    {
        public static void SetTheme(Themes theme, Action action = default)
        {
            var form = Program._mainWin;
            if (form == null) return;

            // Persist settings when rebuilding UI
            form.settings.Theme = theme;
            if(action != null) 
                form.CloseAllContents();
            // Change the theme
            switch (theme)
            {
                case Themes.VS2005:
                    form.dockPanel.Theme = form.vS2005Theme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2005, form.vS2005Theme1);
                    break;
                case Themes.VS2003:
                    form.dockPanel.Theme = form.vS2003Theme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2003, form.vS2003Theme1);
                    break;
                case Themes.Light2K12:
                    form.dockPanel.Theme = form.vS2012LightTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, form.vS2012LightTheme1);
                    break;
                case Themes.Blue2K12:
                    form.dockPanel.Theme = form.vS2012BlueTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, form.vS2012BlueTheme1);
                    break;
                case Themes.Dark2K12:
                    form.dockPanel.Theme = form.vS2012DarkTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, form.vS2012DarkTheme1);
                    break;
                case Themes.Light2K13:
                    form.dockPanel.Theme = form.vS2013LightTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, form.vS2013LightTheme1);
                    break;
                case Themes.Blue2K13:
                    form.dockPanel.Theme = form.vS2013BlueTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, form.vS2013BlueTheme1);
                    break;
                case Themes.Dark2K13:
                    form.dockPanel.Theme = form.vS2013DarkTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, form.vS2013DarkTheme1);
                    break;
                case Themes.Blue2K15:
                    form.dockPanel.Theme = form.vS2015BlueTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, form.vS2015BlueTheme1);
                    break;
                case Themes.Light2K15:
                    form.dockPanel.Theme = form.vS2015LightTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, form.vS2015LightTheme1);
                    break;
                case Themes.Dark2K15:
                    form.dockPanel.Theme = form.vS2015DarkTheme1;
                    form.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, form.vS2015DarkTheme1);
                    break;
            }

            // Update UI Buttons
            foreach (ToolStripMenuItem item in form.themeMI.DropDownItems)
            {
                if (theme.Equals((Themes)Enum.Parse(typeof(Themes), item.Text)))
                    item.Checked = true;
                else
                    item.Checked = false;
            }
            foreach (ToolStripMenuItem item in form.themeMB.DropDownItems)
            {
                if (theme.Equals((Themes)Enum.Parse(typeof(Themes), item.Text)))
                    item.Checked = true;
                else
                    item.Checked = false;
            }

            if (form.dockPanel.Theme.ColorPalette != null)
            {
                form.statusBar.BackColor = form.dockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background;
            }
            action?.Invoke();
        }
    }
}