﻿using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyser
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            
                Console.WriteLine("Welcome to MoodAnalyser problem UC3");
                MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1("I am in happy mood ");
                moodAnalyser1.Analyser();

        
        }
    }
}
