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
    [Table("Persons")]
    public   class PersonEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [Column("PersonID")]
        public int PersonID { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("DNI")]
        public string DNI { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("DocumentTypeID")]
        public int DocumentTypeID { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [Column("PersonCode")]
        public string PersonCode { get; set; }

        [Column("CompleteName")]
        public string CompleteName { get; set; }


    }
}
