using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Common.Classes.Contracts
{
    public class UserContract
    {
        [JsonPropertyName("userID")]
        public int UserID { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = default!;

        [JsonPropertyName("password")]
        public string Password { get; set; } = default!;

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
