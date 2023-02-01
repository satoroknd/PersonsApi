using App.Infraestructure.Database.Entities;
using App.Infrastructure.Database.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.DocumentTypeRepository
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly ApplicationContext _context;
        private readonly IConfiguration _configuration;


        public DocumentTypeRepository(ApplicationContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        public List<DocumentTypeEntity> GetAllDocumentTypes()
        {
            List<DocumentTypeEntity> entities = _context.DocumentTypes.ToList() ;
            return entities;
        }

        public DocumentTypeEntity GetDocumentType(int documentTypeID)
        {
            DocumentTypeEntity entity = _context.DocumentTypes.Where(p => p.DocumentTypeID == documentTypeID).FirstOrDefault();
            return entity;
        }
    }
}
