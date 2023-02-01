using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Common.Classes.DTO
{
    public class RegisterDTO
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = default!;

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("dni")]
        public string DNI { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; } = default!;

        [JsonPropertyName("password_confirm")]
        public string PasswordConfirm { get; set; } = default!;

        [JsonPropertyName("document_typeID")]
        public int DocumentTypeID { get; set; }
    }
}
