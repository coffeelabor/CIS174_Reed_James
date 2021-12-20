using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;

namespace ClassSceduleTest
{
    public class TeacherControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var repo = new Mock<IRepository<Teacher>>();
            var controller = new TeacherController(repo.Object);
            var result = controller.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
