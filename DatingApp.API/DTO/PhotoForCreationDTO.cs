using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.DTO
{
    public class PhotoForCreationDTO
    {
        public string Url { get; set; } = string.Empty;
        public IFormFile File { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; } = string.Empty;

        public PhotoForCreationDTO()
        {
            DateAdded = DateTime.Now;
        }
    }
}