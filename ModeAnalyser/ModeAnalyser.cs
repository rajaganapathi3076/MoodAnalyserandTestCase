﻿using System;
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
        public MoodAnalyser1(string msg)
        {
            message = msg;

        }
        public string Analyser() 
        {
            if (message.ToLower().Contains("happy")) 
            {
                Console.WriteLine("happy");
                return "happy";
                

            }
            else
            {
                Console.WriteLine("sad");
                return "sad";
            }
        }
       
    }
}