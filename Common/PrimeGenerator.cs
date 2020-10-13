using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    class PrimeGenerator : INumberSequenceSource
    {
        int N;
        public PrimeGenerator(int N)
        {
            N = this.N;
        }        

        public IEnumerable<int> GenerateNumbers()
        {
            throw new NotImplementedException();
        }

        private bool isPrime(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }                
            }
            return true;
        }        
    }
}
