using App.Common.Classes.Contracts;
using App.Infraestructure.Database.Entities;
using App.Infrastructure.Database.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.PersonRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationContext _context;
        private readonly IConfiguration _configuration;

        public PersonRepository(ApplicationContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        public void Addperson(PersonEntity entity)
        {
            if (entity is not null)
            {
                this._context.Add(entity);
            }
            this._context.SaveChanges();
        }
    }
}
