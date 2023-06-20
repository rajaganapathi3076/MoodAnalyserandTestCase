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
        public enum weekdays
        {
            Monday,tuesday,wednesday,thursday,friday,saturday
        }
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
                else if (message.ToLower().Contains("sad"))
                {
                    Console.WriteLine("sad");
                    return "sad";

                }
                else
                {
                    Console.WriteLine("unknown Mood cannot find");
                    return message;
                }
            }
            catch(NullReferenceException ex)
            {
                return "Happy";
            }
           
            
           
        }
       
    }
}
