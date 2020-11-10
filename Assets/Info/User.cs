using System;
public class User
{
    private string id;

    public User(string id)
    {
        this.Id = id;
    }

    public string Id { get => id; set => id = value; }
}
