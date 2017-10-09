using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDemoTDD
{
    public class Project
    {
        public bool IsActive { get; set; }
        public double DurationInSeconds
        {
            get
            {
                double totalDurationInSeconds = 0;
                foreach(Segment segment in Segments)
                {
                    totalDurationInSeconds += segment.DurationInSeconds;
                }
                return totalDurationInSeconds;
            }
        }
        public List<Segment> Segments { get; set; } = new List<Segment>();
        private Segment activeSegment;

        public void Start()
        {
            IsActive = true;
        }

        public void Start(DateTime startTime)
        {
            activeSegment = new Segment();
            activeSegment.Start(startTime);
        }

        public void End(DateTime endTime)
        {
            activeSegment.End(endTime);
            Segments.Add(activeSegment);
        }
    }
}
