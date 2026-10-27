using System;
using System.Collections.Generic;

namespace MidtermExam.Prob01
{
    public class VowelCounter
    {
        public int AS01_CountVowels(Queue<string> alphabets)
        {
            if (alphabets == null || alphabets.Count == 0) return 0;
            
            int count = 0;
            int initialCount = alphabets.Count;
            
            for (int i = 0; i < initialCount; i++)
            {
                string current = alphabets.Dequeue();
                if (current == "a" || current == "e" || current == "i" || current == "o" || current == "u")
                {
                    count++;
                }
                alphabets.Enqueue(current);
            }
            
            return count;
        }
    }
}
