using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TechInterviews.Tests")]
namespace TechInterviews
{
    internal class VTexApproaches
    {
        internal bool ApplyTwoHashSetsApproach(string firstString, string secondString)
        {
            var hashfirstString = new HashSet<char>(firstString);
            var dicSecondString = new HashSet<char>(secondString);

            foreach(var item in hashfirstString)
            {
                if (dicSecondString.Contains(item))
                    return true;
            }

            return false;
        }

        internal bool ApplyDistinctWithHashsetApproach(string firstString, string secondString)
        {
            firstString = string.Join("", firstString.Distinct());
            var dicSecondString = new HashSet<char>(secondString); 

            for (var indexString = 0; indexString < firstString.Length; indexString++)
            {
                if (dicSecondString.Contains(firstString[indexString]))
                    return true;
            }

            return false;
        }
    }
}