using System;

namespace Til.Mobile.Api.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public bool WithPhoto { get; set; }

        public string PhotoUrl { get; set; }

        public int Rating { get; set; }
    }
}
