using System;
using System.Collections.Generic;

namespace HW_5
{
    public class ScienceLab: Science
    {
        public string NameOfScience { get; set; }
        public string? SubjectOf { get; set; }

        public static List<string>? ScienceFiled { get; set; } = new List<string> { "Physics", "Math", "Biology", "Chemistry" };


        public ScienceLab(string mainScienceBranch, string scienceSubBranch, string nameOfScience, string subjectOf)
            : base(mainScienceBranch, scienceSubBranch)
        {
            NameOfScience = nameOfScience;
            SubjectOf = subjectOf;
        }

        public static void AskForSubject()
        {
            Console.WriteLine("Choose a subject: " + string.Join(", ", ScienceFiled!));
            string choice = Console.ReadLine()?.Trim().ToLower();

            Physics physics = new("Physics", "Natural Science", "Bachelor's", "Physics", 4, "Bachelor's");
            Mathematics mathematics = new("Mathematics", "Formal Science", "sciences studying numbers, complex numbers, and shapes", "Pure Math", 4, "Bachelor's");
            Biology bio = new("Biology", "Natural Science", "Nature sciences studying living organisms", "Life Sciences", 4, "Bachelor's");
            Chemistry chemistry = new("Chemistry", "Natural Science", "Nature sciences", "Physical Sciences", 4, "Bachelor's");

            switch (choice)
            {
                case "physics":
                    physics.DisplayInfo();
                    break;
                case "math":
                    mathematics.DisplayInfo();
                    break;
                case "biology":
                    bio.DisplayInfo();
                    break;
                case "chemistry":
                    chemistry.DisplayInfo();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid subject.");
                    break;
            }
        
        }

        public static void Main()
        {
            ScienceLab scienceMain = new("Physics", "Theoretical", "Quantum Mechanics", "Advanced Studies");
            AskForSubject();
        }
    }
}
