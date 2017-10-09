using System;

namespace XamarinDemoTDD
{
    public class Segment
    {
        private DateTime startTime;
        private DateTime endTime;

        public double DurationInSeconds
        {
            get
            {
                return (endTime - startTime).TotalSeconds;
            }
        }

        public void Start(DateTime startTime)
        {
            this.startTime = startTime;
        }

        public void End(DateTime endTime)
        {
            this.endTime = endTime;
        }
    }
}
