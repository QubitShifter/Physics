namespace HW_5
{
    public class Research: Science
    {   
       public Research(string mainScienceBranch, string scienceSubBranch, string research)
        : base(mainScienceBranch, scienceSubBranch, research){ }
    
        public void DisplayResearch()
        {
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine($"\nAccessing {ScienceSubBranch} research results....");
            ResearchMethodAccess();
        }
    }
}
