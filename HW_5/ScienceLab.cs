using System;
using System.Collections.Generic;

namespace HW_5
{
    public class ScienceLab: Science
    {
        public string NameOfScience { get; set; }
        public string? SubjectOf { get; set; }

        public ScienceLab(string mainScienceBranch, string scienceSubBranch, string nameOfScience, string subjectOf)
            : base(mainScienceBranch, scienceSubBranch)
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
