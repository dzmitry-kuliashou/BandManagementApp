using BandManagementApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandManagementApp.Entities.Entities
{
    public class Band : IBand
    {
        public int BandId { get; set; }
        public string BandName { get; set; }
        public int FoundationYear { get; set; }
        public Dictionary<IMusician, IList<string>> Members { get; set; }
        public ICollection<ISong> Songs { get; set; }
        public ICollection<IAlbum> Albums { get; set; }
    }
}
