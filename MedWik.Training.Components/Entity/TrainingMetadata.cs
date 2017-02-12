using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedWik.Training.Components.Entity
{
    public class Opengraph
    {
        public string type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string site_name { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public class Twitter
    {
        public string creator { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string card { get; set; }
        public string site { get; set; }
    }

    public class Microdata
    {
        public string type { get; set; }
        public bool hasError { get; set; }
        public List<object> errors { get; set; }
        public bool hasId { get; set; }
        public object properties { get; set; }
    }

    public class Image
    {
        public string src { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string alt { get; set; }
    }

    public class Data
    {
        public string title { get; set; }
        public string description { get; set; }
        public string viewport { get; set; }
        public string canonical { get; set; }
        public Opengraph opengraph { get; set; }
        public Twitter twitter { get; set; }
        public List<object> article { get; set; }
        public List<object> applinks { get; set; }
        public List<Microdata> microdata { get; set; }
        public List<Image> images { get; set; }
    }

    public class TrainingMetadata
    {
        public string success { get; set; }
        public Data data { get; set; }
    }
}