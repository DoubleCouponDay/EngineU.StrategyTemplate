﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.ForYou
{
    public struct Verdict
    {
        public MarketAction action {get; private set; }
        public double ammounttocommit {get; private set;}

        public Verdict(MarketAction verdict, double percentageToCommit)
        {
            this.action = verdict;
            this.ammounttocommit = percentageToCommit;
        }
    }
}
