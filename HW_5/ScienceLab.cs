using System;
using System.Collections.Generic;

namespace HW_5
{
    public class ScienceLab
    {
        public string? Name { get; set; }
        public string? FieldOfStudy { get; set; }
        public static List<string>? Subject { get; set; } = new List<string> { "Physics", "Math", "Biology", "Chemistry" };

        public ScienceLab()
        {
        }

        public ScienceLab(string name, string fieldOfStudy)
        {
            Name = name;
            FieldOfStudy = fieldOfStudy;
        }

        public void AskForSubject()
        {
            Console.WriteLine("Choose a subject: " + string.Join(", ", Subject!));
            string choice = Console.ReadLine()?.Trim().ToLower();

            Physics physics = new("Physics", "Theoretical and Experimental", "Nature sciences studying laws that govern interactions", 4);
            Mathematics mathematics = new("Trigonometry and Algebra", "Mathematics", "sciences studying numbers, complex numbers, and shapes, ");
            Biology bio = new("Biology", "Genetics", "Nature sciences studying living organisms");
            Chemistry chemistry = new("Chemistry", "Organic Chemistry", "Nature sciences");

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
            ScienceLab scienceMain = new();
            scienceMain.AskForSubject();
        }
    }
}
