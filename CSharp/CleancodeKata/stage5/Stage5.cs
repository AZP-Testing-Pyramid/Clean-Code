using System.Collections.Generic;
using System.Linq;

namespace CleancodeKata.stage5
{
    /**
     * Refactor this code until all methods body is less then 5 lines, and you find the code clean.
     */
    public class Stage5
    {
        public bool IsEligible(string x)
        {
            var result = false;
            if (x.Length >= 10)
            {
                var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'y'};
                long nbVowels = x.ToCharArray().Where(vowels.Contains).Count();
                // long words need more than 6
                if (nbVowels >= 4)
                {
                    result = true;
                    return result;
                }

                long nbSpecialLetters = 0;
                for (var i = 0; i < x.Length; i++)
                {
                    if (x[i] == 'p')
                    {
                        nbSpecialLetters++;
                    }

                    if (x[i] == 'm')
                    {
                        nbSpecialLetters = nbSpecialLetters + 1;
                    }
                    else
                    {
                        nbSpecialLetters = nbSpecialLetters;
                    }
                }

                if (nbSpecialLetters >= 3)
                {
                    return true;
                }
            }
            else
            {
                long nbLettersInUpperCase = x.ToCharArray().Where(c => c >= 'A' && c <= 'Z').Count();
                if (nbLettersInUpperCase >= 5)
                {
                    return true;
                }

                var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'y'};

                var nb = 0;
                for (var i = 0; i < x.Length; i++)
                {
                    if (vowels.Contains(x[i]))
                    {
                        nb++;
                    }
                }

                if (nb >= 3)
                {
                    return true;
                }
            }

            return result;
        }
    }
}