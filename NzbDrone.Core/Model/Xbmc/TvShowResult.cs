﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NzbDrone.Core.Model.Xbmc
{
    public class TvShowResult
    {
        public Dictionary<string, int> Limits { get; set; }
        public List<TvShow> TvShows;
    }
}
