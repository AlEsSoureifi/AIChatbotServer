﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelperMethods.Models
{
    public class Datum
    {
        public string @object { get; set; }
        public int index { get; set; }
        public List<double> embedding { get; set; }
    }

    public class Root
    {
        public string @object { get; set; }
        public List<Datum> data { get; set; }
        public string model { get; set; }
        public Usage usage { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int total_tokens { get; set; }
    }

}
