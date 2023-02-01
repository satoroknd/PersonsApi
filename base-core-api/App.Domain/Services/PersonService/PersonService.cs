using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using App.Common.Resources;
using App.Domain.Services.DocumentTypeService;
using App.Infraestructure.Database.Entities;
using App.Infraestructure.Repositories.DocumentTypeRepository;
using App.Infraestructure.Repositories.PersonRepository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IDocumentTypeService _documentTypeService;

        public PersonService(IMapper mapper, IPersonRepository personRepository, IDocumentTypeService documentTypeService)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _documentTypeService = documentTypeService;
        }

        public string AddPerson(RegisterDTO request, DateTime creationDate)
        {
            PersonContract personContract = _mapper.Map<PersonContract>(request);
            DocumentTypeContract documentType = _mapper.Map<DocumentTypeContract>(_documentTypeService.GetDocumentType(personContract.DocumentTypeID));
            personContract.PersonCode = personContract.DNI + documentType.Code;
            personContract.CompleteName = personContract.FirstName + personContract.LastName;
            personContract.CreationDate = creationDate;
            _personRepository.Addperson(_mapper.Map<PersonEntity>(personContract));
            return ApplicationMessages.PersonCreatedSucces;
        }

        public List<PersonContract> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}
