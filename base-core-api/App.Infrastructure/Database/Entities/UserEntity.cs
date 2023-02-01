using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Infraestructure.Database.Entities
{
    [Table("Users")]
    public class UserEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [Column("UserID")]
        public int UserID { get; set; }

        [Column("UserName")]
        public string UserName { get; set; } = default!;

        [Column("Password")]
        public string Password { get; set; } = default!;

        [Column("CreationDate")] 
        public DateTime CreationDate { get; set; } = default!;
    }
}
