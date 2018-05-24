using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.EventDrivenArchitecture.SampleProgram
{
    public class FileSearcher
    {
        public event EventHandler<FileFoundArgs> FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                FileFound?.Invoke(this, new FileFoundArgs(file));
            }
        }
    }
}
