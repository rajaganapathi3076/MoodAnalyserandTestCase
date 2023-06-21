using Microsoft.JScript;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeAnalyser;
using MoodAnalyser;
using System;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]

        [DataRow("Iam in happy mood", "happy")]
        [DataRow("Iam in sad mood", "sad")]
        public void Given_Message_Should_User_Mood(string msg, string expected)
        {

            //AAA Method
            ///Arrange
            MoodAnalyser1 moodanalyser = new MoodAnalyser1(msg);

            //Act
            string actual = moodanalyser.Analyser();


            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        [DataRow(null, "Message having null")]
        public void Given_Message_Should_User_Exception(string msg, string expected)
        {

            //AAA Method
            ///Arrange
            MoodAnalyser1 moodanalyser = new MoodAnalyser1(msg);
            try 
            {
                //Act
                string actual = moodanalyser.Analyser();


                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidMoodException ex)
            {
                Assert.AreEqual(expected, ex.Message);
                Assert.AreEqual("NULL", ex.exceptionTypes.ToString());
                Console.WriteLine(ex.Message);
            }
           

        }
        [TestMethod]
        [DataRow(" ", "Message having empty")]
        public void Given_Message_Should_User_Exceptions(string msg, string expected)
        {

            //AAA Method
            ///Arrange
            MoodAnalyser1 moodanalyser = new MoodAnalyser1(msg);
            try
            {
                //Act
                string actual = moodanalyser.Analyser();


                //Assert
                //Assert.AreEqual(expected, actual);
            }
            catch (InvalidMoodException ex)
            {
                Assert.AreEqual(expected, ex.Message);
                Assert.AreEqual("EMPTY", ex.exceptionTypes.ToString());
                Console.WriteLine(ex.Message);
            }


        }
    }   }
