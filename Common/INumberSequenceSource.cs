using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface INumberSequenceSource
    {
        IEnumerable<int> GenerateNumbers();
    }


}
