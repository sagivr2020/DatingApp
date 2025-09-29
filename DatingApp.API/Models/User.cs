using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] passwordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0]; // key for the hash password
        public string Gender { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string? introduction { get; set; }
        public string? LookingFor { get; set; }
        public string? Interests { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();

        public ICollection<Like> Likers { get; set; } = new List<Like>();

        public ICollection<Like> Likees { get; set; } = new List<Like>();
        public ICollection<Message> MessageSent { get; set; } = new List<Message>();
        public ICollection<Message> MessageReceived { get; set; } = new List<Message>();
    }
}