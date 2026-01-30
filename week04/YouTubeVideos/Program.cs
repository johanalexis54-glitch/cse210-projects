using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video v1 = new Video ("The Sthandard of truth", "Church",600);
        v1.AddComment(new Comment ("Juan", "Great code"));
        v1.AddComment(new Comment ("Mattew", "many times is hard"));
        v1.AddComment(new Comment ("Juan", "Great code"));
        _videos.Add(v1);
        
        Video v2 = new Video ("Raining in japan","Puvliophile lofi",540);
        v2.AddComment(new Comment ("Pablo", "Great code"));
        v2.AddComment(new Comment ("Vanessa", "many times is hard"));
        v2.AddComment(new Comment ("Pipe", "Great code"));
        _videos.Add(v2);

        Video v3 = new Video (" postimpresionismo", "Vincet van gogh",580);
        v3.AddComment(new Comment ("Sergio", "Great code"));
        v3.AddComment(new Comment ("Juan P", "many times is hard"));
        v3.AddComment(new Comment ("Natalia", "Great code"));
        _videos.Add(v3);


        foreach (Video v in _videos)
        {
            v.DisplayVideoDetails();
            
            Console.WriteLine("--------------------------------");
        }

    }
}