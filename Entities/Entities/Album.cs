using BandManagementApp.Entities.Enums;
using BandManagementApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandManagementApp.Entities.Entities
{
    public class Album : IAlbum
    {
        public int AlbumId { get; set; }
        public AlbumEnum? Type { get; set; }
        public int ReleaseYear { get; set; }
        public ICollection<ISong> Songs { get; set; }
    }
}
