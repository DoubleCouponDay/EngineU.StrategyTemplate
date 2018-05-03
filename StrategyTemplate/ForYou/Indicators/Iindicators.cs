﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyTemplate.ForYou.Indicators.Groups;

namespace StrategyTemplate.ForYou.Indicators
{
    public interface Iindicators
    {
        IList<IGraphBar> CurrentHistory {get;}

        ICycles Cycles {get;}
        IMomentums Momentums {get;}
        IOverlapStudies OverlapStudies {get;}
        IPatterns Patterns {get;}
        IPriceTransforms PriceTransforms {get;}
        IVolatilities Volatilities {get;}
        IVolumes Volumes {get;}

        /// <summary>
        /// Set whether the indicator should use database history or custom history.
        /// Combine startingIndex with historiesLength to customize your indicators range.
        /// Useful for backtesting.
        /// </summary>
        /// <param name="historyIsCustom"></param>
        /// <param name="history"></param>
        void SetManualHistoryToggle(bool historyIsCustom, int startingIndex = 0, IList<IGraphBar> history = null);
    }
}