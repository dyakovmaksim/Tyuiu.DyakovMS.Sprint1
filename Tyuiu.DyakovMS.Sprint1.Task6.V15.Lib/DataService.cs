using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyakovMS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letterCount = 0;
            int nonLetterCount = 0;
            foreach(char c in value)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else
                {
                    nonLetterCount++;
                }
            }
            return letterCount > nonLetterCount;
        }
    }
}
