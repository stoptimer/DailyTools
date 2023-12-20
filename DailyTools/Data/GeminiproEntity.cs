using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Data
{

    public class GeminiproEntity
    {
        public Candidate[] candidates { get; set; }
        public Promptfeedback promptFeedback { get; set; }
    }

    public class Promptfeedback
    {
        public Safetyrating[] safetyRatings { get; set; }
    }

    public class Safetyrating
    {
        public string category { get; set; }
        public string probability { get; set; }
    }

    public class Candidate
    {
        public Content content { get; set; }
        public string finishReason { get; set; }
        public int index { get; set; }
        public Safetyrating1[] safetyRatings { get; set; }
    }

    public class Content
    {
        public Part[] parts { get; set; }
        public string role { get; set; }
    }

    public class Part
    {
        public string text { get; set; }
    }

    public class Safetyrating1
    {
        public string category { get; set; }
        public string probability { get; set; }
    }
}
