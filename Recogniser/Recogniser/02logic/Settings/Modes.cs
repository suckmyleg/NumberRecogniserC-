using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser._02logic.Settings
{
    internal static class Modes
    {
        private static Dictionary<String, Mode> modes = new Dictionary<String, Mode>();
        public static Dictionary<String, Mode> GetModes() { return modes; }
        public static void AddMode(Mode m) { modes[m.Name] = m; }
        public static void RemoveModel(string name)
        {
            if (modes.ContainsKey(name)) {
                modes.Remove(name);
                if (name == SelectedMode) SelectedMode = null;
            }
        }
        public static string SelectedMode { get; private set; }
        public static void SetMode(string name) { SelectedMode = name; }
        public static Mode Get(string name) { try { return modes[name]; }catch{ return null; } }
    }
}
