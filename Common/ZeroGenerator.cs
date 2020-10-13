using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    class ZeroGenerator : INumberSequenceSource
    {
        public int N { get; set; }
        public IEnumerable<int> GenerateNumbers()
        {
            for (int i = 0; i < N +1; i++)
            {
                yield return 0;
            }
            
        }
    };
    {
    }
}
