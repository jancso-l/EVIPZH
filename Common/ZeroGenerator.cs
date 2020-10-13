using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ZeroGenerator : INumberSequenceSource
    {
        public int N { get; set; }
        public IEnumerable<int> GenerateNumbers()
        {
            for (int i = 0; i < N; i++)
            {
                yield return 0;
            }            
        }
    }
}
