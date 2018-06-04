using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.CodeFirstApproach
{
    public class EFProgram : IProgram
    {
        private object obj = new Object();
        public void Run()
        {
            Task.Run(() =>
            {
                lock (obj)
                {
                    using (var context = new EFDbContext())
                    {
                        context.Database.Delete();
                        context.Database.Create();
                    }
                }
            });
        }
    }
}
