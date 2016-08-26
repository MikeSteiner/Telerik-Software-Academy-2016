using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TaskManager.Model;
using Moq;

namespace TaskManager.Test
{
    public class MockedLogger : ILogger
    {
        public bool IsLogCalled { get; set; }

        public void Log(string message)
        {
            this.IsLogCalled = true;
        }
    }

    public class MockedIdProvider : IIdProvider
    {
        public int Id
        {
            get
            {
                return 1;
            }
        }
    }

    [TestClass]
    public class TestTaskManager
    {        
        [TestMethod]
        public void TestTaskManger_WhenAddTask_ShouldCallLog()
        {
            // Arrange
            var mockedLogger = new MockedLogger();
            var mockedIdProvider = new MockedIdProvider();
            var taskManger = new Tasker(mockedLogger, mockedIdProvider);

            var task = new Task("Task for test");

            // Act
            taskManger.Save(task);

            // Assert
            Assert.IsTrue(mockedLogger.IsLogCalled);
        }

        [TestMethod]
        public void TestTaskManger_WithMoq_WhenAddTaskIsCalled_ShouldBeCallTheLogMethod()
        {
            ICollection<Task> tasks = new List<Task>()
            {
                new Model.Task("Kupi leb"),
                new Model.Task("Wash the car", DateTime.Now.AddDays(2)),
                new Model.Task("Kupi bira", DateTime.Now)
            };

            // Arrange  
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManger = new Tasker(mockedLogger.Object, mockedIdProvider.Object);
            taskManger.Tasks = tasks;

            //Action<string> actionMockedLoggerLog =
            //    (string s) => mockedLogger.Object.Log(s);
            //Action actionMockedLoggerLog =
            //    () => mockedLogger.Object.Log(It.IsAny<string>());

            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            // Act
            taskManger.Save(tasks.First());

            // Assert
            mockedLogger.Verify();
        }

        [TestMethod]
        public void TestTaskManger_WithMoq_WhenAllTaskIsCalled_ShouldCallLogForAllTasksInTaskList()
        {
            // Arrange
            ICollection<Task> tasks = new List<Task>()
            {
                new Model.Task("Kupi leb"),
                new Model.Task("Wash the car", DateTime.Now.AddDays(2)),
                new Model.Task("Kupi bira", DateTime.Now)
            };

            Mock<ILogger> mockedLogger = new Mock<ILogger>();
            Mock<IIdProvider> mockedIdProvider = new Mock<IIdProvider>();
            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            taskManager.Tasks = tasks;
            //mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            // Act
            taskManager.AllTasks();

            // Assert       
            mockedLogger.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(taskManager.Tasks.Count - 2));   


        }

        [TestMethod]
        public void TestTaskManger_WithMoq_WhenSaveIsCalled_ShouldIdProiderReturnOne()
        {
            // Arrange
            Mock<ILogger> mockedLogger = new Mock<ILogger>();
            Mock<IIdProvider> mockedIdProvider = new Mock<IIdProvider>();
            var taskManger = new Tasker(
                mockedLogger.Object, 
                mockedIdProvider.Object
                );

            Task task1 = new Model.Task("Kupi leb");
            mockedIdProvider.Setup(x => x.Id).Returns(1);

            // Act
            taskManger.Save(task1);

            //Assert
            mockedIdProvider.Verify();
        }
    }

    
}
