using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epik.EpisodeManager.Workflow.Steps
{
    public class StepFileMove
    {
         private Guid _guid;

        public Guid ID
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public string InputFile { get; set; }
        public string Output { get; set; }
        public bool Overwite { get; set; }
        public bool Copy { get; set; }


        public StepFileMove()
        {
            this.ID = Guid.NewGuid();
        }


        public void Activate()
        {

            //Check to see if Input exist
            if (!File.Exists(this.InputFile))
            {
                //File Does not exist so warn someone        
            }
            //Check to see if output exist
            if (File.Exists(this.InputFile))
            {
                if(!this.Overwite)
                {
                    //File Does exist so warn someone
                }

            }


            //Copy/Move file(s)
            if (this.Copy)
            {
                File.Copy(this.InputFile, this.Output, Overwite);
            }
            else
            {
                File.Move(this.InputFile, this.Output);
            }
        }
    }
}
