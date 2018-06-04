using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.LINQ
{
    public class LINQProgram : IProgram
    {
        public async void Run()
        {
            await Task.Run(() => 
            {
                StudentData sc = new StudentData();
                sc.QueryHighScores(1, 90);

                DataClass.CreateData();
                DataClass.SimpleJoinQuery();
                LeftJoinDataClass.LeftOuterJoinExample();
            });
        }
    }
}
