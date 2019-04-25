using System.Collections.Generic;

namespace BandManagementApp.Entities.Interfaces
{
    public interface IMusician
    {
        int MusicianId { get; set; }

        string Name { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        //можно сделать и enum
        string Gender { get; set; }

        IContact Contacts { get; set; }

        //Группа + те инструменты, на которых он играет в конкретной группе.
        //Возможно будет лучше сделать Key в качестве int, чтобы ссылаться на Id группы.
        Dictionary<IBand, IEnumerable<string>> Bands { get; set; }
    }
}