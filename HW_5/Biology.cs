using System;

namespace HW_5
{
    public class Biology : Science
    {
        public string Branch { get; set; }

        public Biology(string name, string branch, string fieldOfStudy)
            : base(name, fieldOfStudy, "Bachelor of Science", 4)
        {
            Branch = branch;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"                                                                              ");
            Console.WriteLine($"{Name} is a branch of {FieldOfStudy}.");
            Console.WriteLine($"It awards a {AcademicDegree} degree and takes {Semesters} semesters.");
            Console.WriteLine($"                          ");
            Console.WriteLine($"  ----------------------- ");
            Console.WriteLine("Would you like to see an example? (y/n)");


            while (true)
            {
                string? choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "y")
                {
                    DoBiologyProblems();
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Bye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'y' or 'n'.");
                }
            }
        }

        public void DoBiologyProblems()
        {
            Console.WriteLine($"                                                                                                              ");
            Console.WriteLine("In Biology we are dealing with living organisms.");
            Console.WriteLine("We try to understand our DNA, the human genome.");
            Console.WriteLine($"                                           ");
            Console.WriteLine("DNA is our genetic material and carries all the instructions from generation to generation.");
            Console.WriteLine($"DNA is made up of “letters”, represented as A, T, G and C. These letters are short for the chemical compounds they constitute.");
            Console.WriteLine("There are 3 billion DNA letters contained in every cell!");
            Console.WriteLine("Can you imagine!");
        }
    }
}
