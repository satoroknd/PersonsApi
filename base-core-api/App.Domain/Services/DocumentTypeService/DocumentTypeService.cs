using App.Common.Classes.Contracts;
using App.Infraestructure.Repositories.DocumentTypeRepository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.DocumentTypeService
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IMapper _mapper;
        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository, IMapper mapper)
        {
            _documentTypeRepository = documentTypeRepository;
            _mapper = mapper;
        }

        public List<DocumentTypeContract> GetAllDocuments()
        {
            return _mapper.Map<List<DocumentTypeContract>>(_documentTypeRepository.GetAllDocumentTypes());
        }

        public DocumentTypeContract GetDocumentType(int documentTypeID)
        {
            return _mapper.Map<DocumentTypeContract>(_documentTypeRepository.GetDocumentType(documentTypeID));
        }
    }
}
