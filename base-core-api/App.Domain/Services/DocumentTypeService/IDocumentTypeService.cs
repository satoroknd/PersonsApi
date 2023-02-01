using App.Common.Classes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.DocumentTypeService
{
    public interface IDocumentTypeService
    {
        DocumentTypeContract GetDocumentType(int documentTypeID);

        List<DocumentTypeContract> GetAllDocuments();
    }
}
