using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's GradeBook";
            
            Console.WriteLine(g2.Name);

      
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! this is the grade programe");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(78.5f);
            book.AddGrade(59);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            book = new GradeBook();
            book.AddGrade(75);
       
        }
    }
}
