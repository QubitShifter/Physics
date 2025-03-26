using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Research: Science
    {   
        
       public Research(string mainScienceBranch, string scienceSubBranch)
        : base(mainScienceBranch, scienceSubBranch){ }
    
        public void DisplayResearch()
        {
            Console.WriteLine( "\nAccessidg research results...." );
            ResearchMethodAccess();
        }
    }
}
