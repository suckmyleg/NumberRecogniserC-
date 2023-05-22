using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    public class ProgressLog : Log
    {
        private double max;
        private double current;
        private Boolean finished;
        public ProgressLog(string val, double max) : base(val)
        {
            this.max = max;
            finished = false;
        }

        public void Reload(double current)
        {
            this.current = current;
            if (max != 0 && this.current % 1 == 0 || current == max) Logger.SelfReload(this);
        }

        public void Reload(double current, string val)
        {
            this.content = val;
            Reload(current);
        }

        public double Status() {
            if (this.HasReachedMax()) this.Finish();
            double status = (this.max==0?0: (double)(this.current/this.max));

            return status < 0 ? 0 : status>100?100:status;
        }

        public void Finish()
        {
            this.current = this.max;
            this.finished = true;
        }

        public void Finish(string content)
        {
            Finish();
            Reload(content);
        }

        public Boolean HasFinished()
        {
            return finished;
        }
        public Boolean HasReachedMax()
        {
            return this.max == this.current;
        }

        public void Next()
        {
            Reload(current + 1);
        }
    }
}
