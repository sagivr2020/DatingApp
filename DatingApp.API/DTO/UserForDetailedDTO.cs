using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTO
{
    public class UserForDetailedDTO
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public string KnownAs { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string? introduction { get; set; }
        public string? LookingFor { get; set; }
        public string? Interests { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string PhotoURL { get; set; } = string.Empty;
        public ICollection<PhotosForDetailedDTO> Photos { get; set; } = new List<PhotosForDetailedDTO>();
    }
}