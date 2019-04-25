
using System;
using System.Collections.Generic;

namespace BandManagementApp.Entities.Interfaces
{
    public interface ISong
    {
        int SongId { get; set; }

        string Name { get; set; }

        int ReleaseYear { get; set; }

        //Песня может входить в разные альбомы
        IEnumerable<IAlbum> Albums { get; set; }

    }
}