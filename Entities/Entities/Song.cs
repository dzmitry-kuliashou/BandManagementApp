using BandManagementApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandManagementApp.Entities.Entities
{
    public class Song : ISong
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public IEnumerable<IAlbum> Albums { get; set; }
    }
}
