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

            //GradeBook g1 = new GradeBook();
            //GradeBook g2 = g1;

            //g1 = new GradeBook();
            //g1.Name = "Scott's GradeBook";

            //Console.WriteLine(g2.Name);


            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! this is the grade programe");

            GradeBook book = new GradeBook();


            book.NameChanged += OnNameChanged;
       


            book.Name = "Mohammad's Grade Book";
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(78.5f);
            book.AddGrade(59);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Avarage",stats.AverageGrade);
            WriteResult("Highest ",(int)stats.HighestGrade);
            WriteResult("Lowest",stats.LowestGrade);
            //book = new GradeBook();
            //book.AddGrade(75);

            Console.ReadLine();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult (string description, int result)
        {
            Console.WriteLine(description + ": " + result) ;
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}
