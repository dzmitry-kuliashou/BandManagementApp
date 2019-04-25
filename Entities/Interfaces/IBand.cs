using System;
using System.Collections.Generic;
using System.Text;

namespace BandManagementApp.Entities.Interfaces
{
    public interface IBand
    {
        int BandId { get; set; }

        string BandName { get; set; }
        
        //Т.к. нас интересует только год, поэтому int
        int FoundationYear { get; set; }

        //Связываем музыкантов с их ролями в группе
        Dictionary<IMusician, IList<string>> Members { get; set; }

        ICollection<ISong> Songs { get; set; }

        ICollection<IAlbum> Albums { get; set; }


    }
}
