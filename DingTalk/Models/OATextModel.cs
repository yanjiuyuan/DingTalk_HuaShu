﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingTalk.Models
{
    public class OATextModel
    {
        public string message_url { get; set; }

        public head head { get; set; }

        public body body { get; set; }


    }

    public class head
    {
        public string bgcolor { get; set; }

        public string text { get; set; }
    }

    public class body
    {
        public string title { get; set; }

        public form[] form { get; set; }

        public rich rich { get; set; }

        public string content { get; set; }
        public string image { get; set; }
        public string file_count { get; set; }
        public string author { get; set; }
    }

    public class form
    {
        public string key { get; set; }

        public string value { get; set; }
    }

    public class rich
    {
        public string num { get; set; }
        public string unit { get; set; }
    }
}