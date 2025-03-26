﻿namespace HW_5
{
    public class Science
    {
        public string MainScienceBranch { get; set;  }
        protected string ScienceSubBranch;

        private string Research = "Field research Data";
        

        public Science(string mainScienceBranch, string scienceSubBranch)
            
        {
            MainScienceBranch = mainScienceBranch;
            ScienceSubBranch = scienceSubBranch;
        }

 
        protected  float LevelOfDificulty(int numOfEquations, int coffeeCupsConsumed, int panicLevel, int confidence)
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
            Console.WriteLine($"{MainScienceBranch} difficulty level: {normalizedDifficulty}/10");
            Console.WriteLine($"{MainScienceBranch} difficulty percentage: {difficultyPercent:F2}%");


            return normalizedDifficulty; 
        }


        private void ResearchMethodAccessDenied()
        {
            Console.WriteLine( $"\nAccess to {MainScienceBranch} results is denied:" );
        }

        public void ResearchMethodAccess()
        {
            ResearchMethodAccessDenied();
        }
    }
}


