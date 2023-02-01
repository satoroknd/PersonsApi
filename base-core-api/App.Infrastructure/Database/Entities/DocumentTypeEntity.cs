using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Database.Entities
{
    [Table("DocumentTypes")]
    public class DocumentTypeEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [Column("DocumentTypeID")]
        public int DocumentTypeID { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Code")]
        public string  Code { get; set; }
    }
}
