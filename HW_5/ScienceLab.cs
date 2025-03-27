namespace HW_5
{
    public class ScienceLab: Science
    {
        public string NameOfScience { get; set; }
        public string? SubjectOf { get; set; }

        public ScienceLab( string nameOfScience, string subjectOf)
            : base("", "", "")
        {
            NameOfScience = nameOfScience;
            SubjectOf = subjectOf;
        }

        public ScienceLab(string mainScienceBranch, string scienceSubBranch, string nameOfScience, string subjectOf, string research)
            : base(mainScienceBranch, scienceSubBranch, research)
        {
            NameOfScience = nameOfScience;
            SubjectOf = subjectOf;
        }

        public void TheoreticalInformation()
        {
            Console.WriteLine( $"\n{NameOfScience} study information... " );     
        }
    }
}
