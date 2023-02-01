using App.Common.Classes.DTO;
using App.Domain.Services.DocumentTypeService;
using Microsoft.AspNetCore.Mvc;

namespace base_core_api.Controllers.DocumentType
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeService _documentTypeService;

        public DocumentTypeController(IDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpGet("document-types")]
        public IActionResult GetAllDocuments()
        {
            return Ok(_documentTypeService.GetAllDocuments());
        }
    }
}
