using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epik.EpisodeManager.Workflow;

namespace EpManConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String SessionFile = @"D:\Dev\Epiktetus\Epiktetus\Sample1.xml";
            Epik.EpisodeManager.Workflow.Session mySession = new Session();
            mySession.Name = "SampleSession";
            mySession.AddaStep("Copy Raw Video To Conversion Folder", Epik.EpisodeManager.Workflow.Steps.StepTypes.FileMover);
            mySession.AddaStep("Copy Raw Video To NAS Backup Folder",  Epik.EpisodeManager.Workflow.Steps.StepTypes.FileMover);
            mySession.AddaStep("Convert Raw Video", Epik.EpisodeManager.Workflow.Steps.StepTypes.CommandPrompt);



            mySession.SaveSession(SessionFile);


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
