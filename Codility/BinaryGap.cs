using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    /*
    A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
    
    For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
    The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
    The number 20 has binary representation 10100 and contains one binary gap of length 1. 
    The number 15 has binary representation 1111 and has no binary gaps. 
    The number 32 has binary representation 100000 and has no binary gaps.
    
    Write a function:
    
    class Solution { public int solution(int N); }
    that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.
    For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. 
    Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.
    Write an efficient algorithm for the following assumptions:
    N is an integer within the range [1..2,147,483,647].

     */
    internal class BinaryGap
    {
        internal BinaryGap(int n)
        {
            var bin = ToBinary(n);
            int max = 1;
            var indexs = new List<int>();

            for (int i = 0; i < bin.Count; i++)
                if (bin[i] == "1")
                    indexs.Add(i);

            for (int i = indexs.Count - 1; i > 0; i--)
                if (indexs[i] - indexs[i - 1] > max)
                    max = indexs[i] - indexs[i - 1];

            Console.WriteLine(max - 1);

            List<string> ToBinary(int n)
            {
                int m = n;
                List<string> list = new List<string>();

                while (m > 1)
                {
                    list.Add((m % 2).ToString());
                    m = m / 2;
                }
                list.Add(m.ToString());
                list.Reverse();
                return list;
            }
        }

    }
}
