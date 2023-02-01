using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using App.Infraestructure.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.PersonRepository
{
    public interface IPersonRepository
    {
        void Addperson(PersonEntity personContract);
    }
}
