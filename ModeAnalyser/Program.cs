using MoodAnalyser;
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
            try
            {

                Console.WriteLine("Welcome to MoodAnalyser problem UC1");
                MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1(" ");
                moodAnalyser1.Analyser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

        }
    }
}
