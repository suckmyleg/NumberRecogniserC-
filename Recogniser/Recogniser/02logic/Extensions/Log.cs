using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    public class Log
    {
        protected string content;
        private int index;

        public Log(string val)
        {
            this.content = val;
            this.index = Logger.SelfAdd(this);
        }

        public void BackIndex() {
            this.index--;
        }

        public void Reload(string content) { 
            this.content = content; 
            Logger.SelfReload(this);
        }
        public void Remove() { 
            Logger.SelfRemove(this);
        }
        override public string ToString() { return this.content; }
        public int GetIndex() { 
            return Logger.GetLogs().IndexOf(this);
        }
    }
}
