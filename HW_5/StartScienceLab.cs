namespace HW_5
{
    public class StartScienceLab
    {
        public static void Main()
        {
            Console.WriteLine("You can choose a science lab...but be carefull what you wish!");
            Console.WriteLine("Your choise:");
            Console.WriteLine("\n1. Physics\n2. Math\n3. Biology \n4. Chemistry");
            Console.Write("\nLet me know: ");

            string choice = Console.ReadLine();
            string scienceSubBranch = "random scince";

            switch (choice)
            {
                case "1":
                    Physics PhysicsLab = new("Physics", "Natural Science", "Physics", "Physics", 4, "Bachelor's", "");
                    PhysicsLab.DisplayInfo();
                    scienceSubBranch = PhysicsLab.ScienceSubBranch;
                    break;
                case "2":
                    Mathematics MathLab = new("Mathematics", "Formal Science", "Math", "Pure Math", 4, "Bachelor's", "");
                    MathLab.TheoreticalInformation();
                    MathLab.DisplayInfo();
                    scienceSubBranch = MathLab.ScienceSubBranch;
                    break;
                case "3":
                    Biology BiologyLab = new("Biology", "Natural Science", "Biology", "Life Sciences", 4, "Bachelor's", "");
                    BiologyLab.TheoreticalInformation();
                    BiologyLab.DisplayInfo();
                    scienceSubBranch = BiologyLab.ScienceSubBranch;
                    break;
                case "4":
                    Chemistry ChemistryLab = new("Chemistry", "Natural Science", "Nature sciences", "Physical Sciences", 4, "Bachelor's", "");
                    ChemistryLab.TheoreticalInformation();
                    ChemistryLab.DisplayInfo();
                    scienceSubBranch = ChemistryLab.ScienceSubBranch;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid subject.");
                    break;
            }

            Research research = new Research($"", scienceSubBranch, "");
            research.DisplayResearch();

            Console.WriteLine("\nYou have reached singularity. Everythong is zeroed out.\nSo long, and thanks for the fish.");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }
    } 
}

