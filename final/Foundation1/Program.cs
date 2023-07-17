using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        _videos.Add(video1);
        video1._author = "Casey Neistat";
        video1._title = "A day in the life of a SWE in Google";
        video1._length = 90;
        
        Comment Comment1 = new Comment();
        Comment1._name = "Alan";
        Comment1._text = "That was a nice video";
        video1._comments.Add(Comment1);

        Comment Comment2 = new Comment();
        Comment2._name = "Domingo";
        Comment2._text = "Let's go Yankees!";
        video1._comments.Add(Comment2);

        Comment Comment3 = new Comment();
        Comment3._name = "Mauricio";
        Comment3._text = "Good job!";
        video1._comments.Add(Comment3);
        
        Video video2 = new Video();
        _videos.Add(video2);
        video2._author = "Darryl";
        video2._title = "A day in the warehouse";
        video2._length = 60;
        
        Comment Comment11 = new Comment();
        Comment11._name = "Alan";
        Comment11._text = "That was a nice video";
        video2._comments.Add(Comment11);

        Comment Comment22 = new Comment();
        Comment22._name = "Domingo";
        Comment22._text = "Let's go Yankees!";
        video2._comments.Add(Comment22);

        Comment Comment33 = new Comment();
        Comment33._name = "Mauricio";
        Comment33._text = "Good job!";
        video2._comments.Add(Comment33);

        Video video3 = new Video();
        _videos.Add(video3);
        video3._author = "Ling Ding";
        video3._title = "New York Marathon 2023";
        video3._length = 100;
        
        Comment Comment111 = new Comment();
        Comment111._name = "Alan";
        Comment111._text = "Crazy Fast!";
        video3._comments.Add(Comment111);

        Comment Comment222 = new Comment();
        Comment222._name = "Jared";
        Comment222._text = "So sad this run is in Sunday!";
        video3._comments.Add(Comment222);

        Comment Comment333 = new Comment();
        Comment333._name = "Mauricio";
        Comment333._text = "#MakeSabbathDayHolyAgain";
        video3._comments.Add(Comment333);

        Comment Comment444 = new Comment();
        Comment444._name = "James";
        Comment444._text = "Let's go Yankees!";
        video3._comments.Add(Comment444);

        foreach(Video v in _videos)
        {
            Console.WriteLine($"{v.PrintList()}");
            Console.WriteLine(v.CommentsNumber());
            v.PrintComments();
        }
        



    }
}