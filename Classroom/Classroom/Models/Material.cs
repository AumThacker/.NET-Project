using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Classroom.Models
{
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialId { get; set; }
        public int ClassCode { get; set; }
        public string Desc { get; set; }
        public string DocName { get; set; }
        public string DocType { get; set; }
        public byte[] Document { get; set; }
        public bool IsAssignment { get; set; }
        public string Title { get; set; }
    }
}