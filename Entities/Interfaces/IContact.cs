using System.Collections.Generic;

namespace BandManagementApp.Entities.Interfaces
{
    public interface IContact
    {
        string Adress { get; set; }

        //У музыканта может быть много мейлов
        IEnumerable<string> Email { get; set; }

        //Как и номеров
        IEnumerable<string> TelephoneNumber { get; set; }
    }
}