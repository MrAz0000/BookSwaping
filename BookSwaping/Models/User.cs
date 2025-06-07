﻿namespace BookSwaping.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public string Email { get; set; } = string.Empty;
        public int Balance { get; set; }

        public ICollection<Book> ?books { get; set; }
    }
}
