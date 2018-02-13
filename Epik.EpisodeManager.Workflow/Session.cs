using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Epik.EpisodeManager.Workflow.Steps;

namespace Epik.EpisodeManager.Workflow
{
    [XmlRootAttribute("Session", Namespace = "http://www.Epiktetus.net", IsNullable = false)]
    public class Session
    {
        
        private String _name;
        [XmlElement]
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Step> _steps = new List<Step>();


        [XmlElement]
        public List<Step> Steps
        {
            get { return _steps; }
            set { _steps = value; }
        }

        private List<StepFileMove> _stepFileMovers =  new List<StepFileMove>();
        [XmlElement]
        public List<StepFileMove> StepFileMovers
        {
            get { return _stepFileMovers; }
            set { _stepFileMovers = value; }
        }


        public Session()
        {
            Initializer();
        }

        public void Initializer()
        {

        }

        //Save Session file for reloading if needed.
        public void SaveSession(string filename)
        {
            EMSerializer.SaveSession(this, filename);
        }

        public void AddaStep(string title, Steps.StepTypes stepType)
        {
            StepFileMove fmstep;

            switch (stepType)
            {
                case StepTypes.FileMover:
                    fmstep = new StepFileMove();
                    this.StepFileMovers.Add(fmstep);
                    this.Steps.Add(new Step() { Title = title, Index = this.Steps.Count, State = StepStates.Pending, StepType = stepType, Id = fmstep.ID });
                    break;
                case StepTypes.CommandPrompt:
                    this.Steps.Add(new Step() { Title = title, Index = this.Steps.Count, State = StepStates.Pending, StepType = stepType, Id = Guid.NewGuid() });
                    break;
                case StepTypes.Manual:
                    this.Steps.Add(new Step() { Title = title, Index = this.Steps.Count, State = StepStates.Pending, StepType = stepType, Id = Guid.NewGuid() });
                    break;
                default:
                    break;
            }
        }


    }
}
