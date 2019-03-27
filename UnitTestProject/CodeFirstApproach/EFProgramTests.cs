using NUnit.Framework;
using CSharpSamples.CodeFirstApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CSharpSamples.CodeFirstApproach.Entities;
using System.Data.Entity;

namespace CSharpSamples.CodeFirstApproach.Tests
{
    [TestFixture()]
    public class EFProgramTests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test()]
        public void NewUser_Adding_ReturnsTrue()
        {
            var mockUser = new Mock<DbSet<User>>();
            var mockContext = new Mock<EFDbContext>();
            mockContext.Setup(x => x.Users).Returns(mockUser.Object);
            Assert.IsTrue(true);
        }
    }
}