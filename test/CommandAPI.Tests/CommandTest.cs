using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTest : IDisposable
    {
        private Command testCommand;

        public CommandTest()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandLine"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }
        
        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange
            
            // Act
            testCommand.HowTo = "Execute Unit Tests";
            
            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrange
            
            // Act
            testCommand.Platform = "xUnit";
            
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrange
            
            // Act
            testCommand.CommandLine = "dotnet test";
            
            // Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}