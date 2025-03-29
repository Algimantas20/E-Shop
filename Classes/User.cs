namespace E_Shop.Classes
{
    internal class User
    {
        private static int _id;
        private static string _username, _first_name, _last_name, _email, _privilege;
        public User(int id, string username, string first_name, string last_name, string email, string privilege)
        {
            Id = id;
            _username = username;
            _first_name = first_name;
            _last_name = last_name;
            _email = email;
            _privilege = privilege;
        }

        public static int Id { get => _id; set => _id = value; }
        public static string Username { get => _username; set => _username = value; }
        public static string First_Name { get => _first_name; set => _first_name = value; }
        public static string Last_Name { get => _last_name; set => _last_name = value; }
        public static string Email { get => _email; set => _email = value; }
        public static string Privilege { get => _privilege; set => _privilege = value; }

        public static void SignOut()
        {
            Id = -1;
            Username = null;
            First_Name = null;
            Last_Name = null;
            Email = null;
            Privilege = null;
        }
    }
}
