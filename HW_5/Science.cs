using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_5
{
    public class Science : ScienceLab
    {
        public string AcademicDegree { get; set; }
        public int Semesters { get; set; }

        public Science(string name, string fieldOfStudy, string academicDegree, int semesters)
            : base(name, fieldOfStudy)  
        {
            AcademicDegree = academicDegree;
            Semesters = semesters;
        }

        protected float LevelOfDificulty(int numOfEquations, int coffeeCupsConsumed, int panicLevel, int confidence)
        {
            if (numOfEquations == 0) 
            {
                return float.MaxValue; 
            }

            float panicModeCoefficient = (float)numOfEquations / coffeeCupsConsumed * ((float)panicLevel / confidence);

           
            float normalizedDifficulty = Math.Min(panicModeCoefficient, 10);

           
            float maxPossibleDifficulty = 50.0f; 
            float difficultyPercent = (panicModeCoefficient / maxPossibleDifficulty) * 100;
            difficultyPercent = Math.Min(difficultyPercent, 100);

            Console.WriteLine($"                                                     ");
            Console.WriteLine($"{Name} difficulty level: {normalizedDifficulty}/10   ");
            Console.WriteLine($"{Name} difficulty percentage: {difficultyPercent:F2}%");

            return normalizedDifficulty; 
        }




        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Subject: {Name}");
            Console.WriteLine($"Field of Study: {FieldOfStudy}");
            Console.WriteLine($"Academic Degree: {AcademicDegree}");
            Console.WriteLine($"Semesters: {Semesters}");
        }
    }
}


