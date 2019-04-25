using BandManagementApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandManagementApp.Entities.Entities
{
    public class Musician : IMusician
    {
        public int MusicianId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public IContact Contacts { get; set; }
        public Dictionary<IBand, IEnumerable<string>> Bands { get; set; }
    }
}
