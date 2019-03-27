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
        private EFDbContext context;

        public EFProgram(EFDbContext _dbContext)
        {
            context = _dbContext;
        }

        public EFProgram()
        {

        }

        public void Run()
        {
            //Task.Run(() =>
            //{
            //    lock (obj)
            //    {
            //        using (var context = new EFDbContext())
            //        {
            //            context.Database.Delete();
            //            context.Database.Create();
            //        }
            //    }
            //});
        }

        public bool AddNewItemToDb()
        {
            try
            {
                context.Users.Add(new Entities.User
                {
                    Email = "srinivas@cloudthing.com"
                });
                context.SaveChangesAsync();
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
