using ModeAnalyser;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
       
        public string message;

        public MoodAnalyser1()
        {
            message = "happy ";
        }
        

        public MoodAnalyser1(string msg)
        {
            message = msg;

        }

        public string Analyser() 
        {
            try 
            {

                if (message.ToLower().Contains("happy"))
                {
                    Console.WriteLine("happy");
                    return "happy";


                }
                else if (message.Equals(string.Empty)) 
                {
                    throw new InvalidMoodException(InvalidMoodException.ExceptionTypes.EMPTY, "Message having empty");
                   

                }
                else
                {
                    return "sad";

                }
               
            }
            catch(NullReferenceException ex)
            {
                throw new InvalidMoodException(InvalidMoodException.ExceptionTypes.NULL, "Message having null");
            }
           
            
           
        }
       
    }
}
