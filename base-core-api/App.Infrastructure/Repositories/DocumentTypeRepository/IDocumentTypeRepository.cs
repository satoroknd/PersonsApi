using App.Infraestructure.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.DocumentTypeRepository
{
    public interface IDocumentTypeRepository
    {
        List<DocumentTypeEntity> GetAllDocumentTypes();

        DocumentTypeEntity GetDocumentType(int documentTypeID);
    }
}
