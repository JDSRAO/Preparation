using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.CodeFirstApproach
{
    public class EFProgram : IProgram
    {
        public void Run()
        {
            using (var context = new EFDbContext())
            {
                //context.Database.sq
                context.Database.Delete();
                context.Database.Create();
            }
        }
    }
}
