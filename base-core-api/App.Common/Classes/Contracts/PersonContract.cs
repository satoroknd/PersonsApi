using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Common.Classes.Contracts
{
    public class PersonContract
    {
        [JsonPropertyName("personID")]
        public int PersonID { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("dni")]
        public string DNI  { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("document_TypeID")]
        public int DocumentTypeID { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("person_code")]
        public string PersonCode { get; set; }

        [JsonPropertyName("complete_name")]
        public string CompleteName { get; set; }

     
    }
}
