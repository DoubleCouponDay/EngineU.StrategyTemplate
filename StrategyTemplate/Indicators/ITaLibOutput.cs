﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALib;

namespace StrategyTemplate.Indicators
{
    public interface ITaLibOutput <TOutputSeries>
    {
        /// <summary>
        /// Container for the different amount of series each ta lib algorithm can return.
        /// </summary>
        TOutputSeries Series {get; set;}

        Core.RetCode Outcome {get; set;} 

        /// <summary>
        /// equivalent to ta lib's outBegIdx.
        /// </summary>
        int AlgorithmsBeginningIndex {get; set;}

        int NBElement {get; set;}

        bool HistoryWasCustom {get; set;}
    }
}
