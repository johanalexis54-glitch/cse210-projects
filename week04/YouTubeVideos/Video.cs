using System;
using System.Collections.Generic;

class Video
{
    // create private fields (Encaptulation)
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;
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
    public string Length
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
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
    public int GetNumberOfComents()
    {
        return _comment.Count;
    }
    
}