﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ember.Shared
{
    public class NewsPost
    {
        public int Id { get; set; }

        public string  Title { get; set; }

        public string Description { get; set; }

        public string ImageSrc { get; set; }

        public DateTime Time { get; set; }

        public string Category { get; set; }
    }
}
