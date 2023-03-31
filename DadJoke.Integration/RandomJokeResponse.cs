﻿namespace DadJoke.Integration
{
    public class RandomJokeResponse
    {
        public bool success { get; set; }
        public List<Body> body { get; set; }
    }
    public class Body
    {
        public string _id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public string type { get; set; }
        public List<object> likes { get; set; }
        public Author author { get; set; }
        public bool approved { get; set; }
        public int date { get; set; }
        public bool NSFW { get; set; }
        public string shareableLink { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public object id { get; set; }
    }
}
