using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epik.EpisodeManager.Workflow.Steps;

namespace Epik.EpisodeManager.Workflow
{
    [Serializable]
    public class Step
    {
        private string _title = "";
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private int _index = 1;
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public Guid Id { get; set; }

        private StepStates _state = StepStates.Pending;

        public StepStates State
        {
            get { return _state; }
            set { _state = value; }
        }

        private Epik.EpisodeManager.Workflow.Steps.StepTypes _stepTypes;

        public Epik.EpisodeManager.Workflow.Steps.StepTypes StepType
        {
            get { return _stepTypes; }
            set { _stepTypes = value; }
        }
    }
}
