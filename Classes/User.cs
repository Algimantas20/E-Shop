using System;
using System.Data;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Privilege { get; set; }

    public User(int id, string username, string firstName, string lastName, string email, string privilege)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Privilege = privilege;
    }

    public static User GetUserByUsername(string username, DataSet table)
    {
        var userRow = table.Tables["Users"].Select($"Username = '{username}'")[0];
        return new User
        (
            id: Convert.ToInt32(userRow["Id"]),
            username: userRow["Username"].ToString(),
            firstName: userRow["First_Name"].ToString(),
            lastName: userRow["Last_Name"].ToString(),
            email: userRow["Email"].ToString(),
            privilege: userRow["Privilege"].ToString()
        );
    }
}
