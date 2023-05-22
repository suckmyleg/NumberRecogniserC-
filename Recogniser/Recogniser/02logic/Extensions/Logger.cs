using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    internal static class Logger
    {
        private static List<Log> logs = new List<Log>();
        private static bool reload = false;
        private static bool removed = false;
        private static List<Log> logsChanged = new List<Log>();
        private static int lastDisplayed = -1;


        public static int SelfAdd(Log l) {
            logs.Add(l);
            Program.main.ReloadLogs();
            return logs.IndexOf(l);
        }

        public static void SelfRemove(Log l) {
            logs.RemoveAt(l.GetIndex());
            removed = true;
            Program.main.ReloadLogs();
        }

        public static void SelfReload(Log l) {
            reload = true;
            logs[l.GetIndex()] = l;
            logsChanged.Add(l);
            Program.main.ReloadLogs();
        }

        public static void NewLine(String l) {
            new Log(l);
        }

        public static bool NeedToReload() {
            return reload;
        }

        public static bool HasRemoved() { 
            if (removed) { 
                removed = false; 
                return true;  
            } 
            return false; 
        }

        public static int Count() { return logs.Count(); }

        public static void MarkAsReloaded() { reload = false; }

        public static List<Log> GetLogs() { return logs; }

        public static List<Log> GetNewLogs() { 
            List<Log> logsToReturn = logs.FindAll((x)=> x.GetIndex() > lastDisplayed);
            lastDisplayed = logs[Count()-1].GetIndex();
            return logsToReturn;
        }

        public static List<Log> GetReloadedLogs(){
            List<Log> logsToReturn = logs.FindAll((x) => logsChanged.Contains(x));
            logsChanged.Clear();
            return logsToReturn;
        }
    }
}