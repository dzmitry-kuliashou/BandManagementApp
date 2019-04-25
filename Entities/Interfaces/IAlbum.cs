using BandManagementApp.Entities.Enums;
using System;
using System.Collections.Generic;

namespace BandManagementApp.Entities.Interfaces
{
    public interface IAlbum
    {
        int AlbumId { get; set; }

        AlbumEnum? Type { get; set; }

        int ReleaseYear { get; set; }
        
        ICollection<ISong> Songs { get; set; }
    }
}