﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Contracts
{
    public interface INumberWriter
    {
        void WriteNumbersToFile(int max);
    }
}
