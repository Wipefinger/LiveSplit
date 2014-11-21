﻿using LiveSplit.Model.Comparisons;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LiveSplit.Model
{
    public interface ISegment : ICloneable
    {
        Image Icon { get; set; }
        String Name { get; set; }
        Time PersonalBestSplitTime { get; set; }
        IComparisons Comparisons { get; set; }
        Time BestSegmentTime { get; set; }
        Time SplitTime { get; set; }
        IList<IIndexedTime> SegmentHistory { get; set; }
    }
}