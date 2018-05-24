using CSharpSamples.EventDrivenArchitecture.SampleProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.EventDrivenArchitecture
{
    public class EDAProgram : IProgram
    {
        public void Run()
        {
            var lister = new FileSearcher();
            EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
            {
                Console.WriteLine(eventArgs.FoundFile);
            };

            lister.FileFound += onFileFound;
        }
    }
}
