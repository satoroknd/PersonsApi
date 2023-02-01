using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Common.Classes.Contracts
{
    public class DocumentTypeContract
    {
        [JsonPropertyName("document_typeID")]
        public int DocumentTypeID { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
