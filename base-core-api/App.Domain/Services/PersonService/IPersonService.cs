using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.PersonService
{
    public interface IPersonService
    {
        string AddPerson(RegisterDTO request, DateTime creationDate);

        List<PersonContract> GetAllPersons();
    }
}
