using System;
using System.Data;

public static class Session
{
    public static User User { get; private set; }

    public static void SignIn(DataRow userDataRow)
    {
        User user = new User
        (
            id: Convert.ToInt32(userDataRow["Id"]),
            username: userDataRow["Username"].ToString(),
            firstName: userDataRow["First_Name"].ToString(),
            lastName: userDataRow["Last_Name"].ToString(),
            email: userDataRow["Email"].ToString(),
            privilege: userDataRow["Privilege"].ToString()
        );

        User = user;
    }

    public static void SignOut()
    {
        User = null;
    }

    public static bool IsSignedIn => User != null;
}
