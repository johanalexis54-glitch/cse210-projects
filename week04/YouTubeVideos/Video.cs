using System;
using System.Collections.Generic;

class Video
{
    // create private fields (Encaptulation)
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
        // Properties: They allow controlled access to the fields
    public string Title
    {
        get{return _title;}
        set{_title = value;}
    }
    public string Author
    {
        get{return _author;}
        set{_author = value;}
    }
    public int Length
    {
        get{return _length;}
        set{_length = value;}
    }
        // Constructor
    public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }
    public void AddComment(Comment comments)
    {
        _comments.Add(comments);
    }
    public int GetNumberOfComents()
    {
        return _comments.Count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"{_title}: {_author}  {_length} Seconds");
        Console.WriteLine($"Comments Noun {GetNumberOfComents()}");
        Console.WriteLine($"Comentarios: ");


        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}