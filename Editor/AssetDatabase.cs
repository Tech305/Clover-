using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace CloverEditor
{
    public class AssetDatabase
    {
        public static string assetpath => $"{new FileInfo(Application.ExecutablePath).Directory.FullName}\\Assets";
        public static string temppath => $"{new FileInfo(Application.ExecutablePath).Directory.FullName}\\Temp";
        
        
        public static string tmpConfigFile => Path.Combine(temppath, "EditorConfig.temp.config");
        public static string settingsFile => Path.Combine(assetpath, "EditorConfig.config");
        public static string settingsLayoutFile => Path.Combine(assetpath, "DockLayout.config");


        public static T Load<T>()
        {
            Directory.CreateDirectory(assetpath);
            Directory.CreateDirectory(temppath);

            if(typeof(T).Equals(typeof(WindowSettings)))
            {
                WindowSettings ws;
                if (!File.Exists(settingsFile)) return default;
                using(var sr = new StreamReader(settingsFile))
                {
                    var json = sr.ReadToEnd();
                    ws = JsonConvert.DeserializeObject<WindowSettings>(json);
                    using(var sw = new StreamWriter(tmpConfigFile, false))
                    {
                        sw.Write(ws.XML);
                    }
                }
                return (T)(object)ws;
            }

            return default;
        }

        public static void Save<T>(T settings)
        {
            Directory.CreateDirectory(assetpath);
            Directory.CreateDirectory(temppath);
            var json = JsonConvert.SerializeObject(settings);
            using(var sw = new StreamWriter(settingsFile, false))
                sw.Write(json);
        }
    }
}
