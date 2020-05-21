using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMenuServer
{
    public class Webhook
    {
        public string content { get; set; }
        public string username { get; set; }
        public List<Embeds> embeds { get; set; }
    }

    public class Embeds
    {
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public long? color { get; set; }
        public DateTimeOffset? timestamp { get; set; }
        public Footer footer { get; set; }
        public Image thumbnail { get; set; }
        public Image image { get; set; }
        public Author author { get; set; }
        public List<Field> fields { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string url { get; set; }
        public string icon_url { get; set; }
    }

    public class Field
    {
        public string name { get; set; }
        public string value { get; set; }
        public bool? inline { get; set; }
    }

    public class Footer
    {
        public string icon_url { get; set; }
        public string text { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
    }
}
