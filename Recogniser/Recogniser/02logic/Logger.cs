using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser._02logic
{
    public class ProgressLog : Log
    {
        private double max;
        private double current;
        public ProgressLog(string val, double max) : base(val)
        {
            this.max = max;
        }

        public void Reload(double current)
        {
            this.current = current;
            Logger.SelfReload(this);
        }
        public void Reload(double current, string val)
        {
            this.current = current;
            this.content = val;
            Logger.SelfReload(this);
        }

        public void Next() {
            this.current += 1;
            Logger.SelfReload(this);
        }
    }
    public class Log {
        protected string content;
        private int index;

        public string Content
        {
            get { return this.content; }
            set { }
        }
        public int Index
        {
            get { return this.index; }
            set { }
        }
        public Log(string val) {
            this.content = val;
            this.index = Logger.SelfAdd(this);
        }

        override public string ToString() { return this.content; }
        public int GetIndex() { return this.index; }
    }

    internal static class Logger
    {
        private static List<Log> logs = new List<Log>();
        public static int SelfAdd(Log l) {
            logs.Add(l);
            Program.main.ShowLogs();
            return logs.Count-1;
        }

        public static void SelfReload(Log l) {
            logs[l.GetIndex()] = l;
            Program.main.ShowLogs();
        }

        public static void NewLine(String l) {
            new Log(l);
        }

        public static List<Log> GetLogs() { return logs;}
    }
}
