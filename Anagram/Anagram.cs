using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {

        public bool WordPairIsAnagram(string word1, string word2)
        {
            //Insert the correct implementation here
            char[] A;
            char[] B;

            A = word1.ToCharArray();
            B = word2.ToCharArray();

            Array.Sort(A);
            Array.Sort(B);

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                    return false;
            }
            return true;

        }

        public List<string> SelectAnagrams(string word, List<string> candidates)
        {

            for (var i = 0; i < candidates.Count; i++)
            {
                 
                if (!WordPairIsAnagram(word, candidates[i]))
                    candidates.RemoveAt(i);
            }

            return candidates;

        }
    }
