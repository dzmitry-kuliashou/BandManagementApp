using BandManagementApp.Entities.Interfaces;
using System.Collections.Generic;

namespace BandManagementApp.Entities.Entities

{
    public class Contact : IContact
    {
        public string Adress { get; set; }
        
        public IEnumerable<string> Email { get; set; }

        public IEnumerable<string> TelephoneNumber { get; set; }
    }
}