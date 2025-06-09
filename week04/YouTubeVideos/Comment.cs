public class Comment
{
    private string _comment;
    private string _user;

    public Comment(string comment, string user)
    {
        _comment = comment;
        _user = user;
    }

    public string getUser()
    {
        return _user;
    }

    public string getComment()
    {
        return _comment;
    }
}