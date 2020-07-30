using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRidOfPolishLetters
{
    public static class ReplacingPolishLetters
    {
        public static string MakeItNormal(string text)
        {
            string result;

            result = text.Replace('ę', 'e').Replace('ó', 'o').Replace('ą', 'a').Replace('ś', 's')
                            .Replace('ł', 'l').Replace('ż', 'z').Replace('ź', 'z').Replace('ć', 'c').Replace('ń', 'n');

            return result;
        }
    }
}
