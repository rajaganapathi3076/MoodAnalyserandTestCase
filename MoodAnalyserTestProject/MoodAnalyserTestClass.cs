using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]

        [DataRow(" Iam in happy mood", "happy")]
        [DataRow(" Iam in sad mood", "sad")]
        public void Given_Message_Should_User_Mood(string msg,string expected)
        {

            //AAA Method
            ///Arrange
            MoodAnalyser1 moodanalyser = new MoodAnalyser1(msg);

            //Act
            string actual = moodanalyser.Analyser();


            //Assert
            Assert.AreEqual(expected, actual);



        }
    }
}
