using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.Models
{
    public class Submission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }
        public int ClassCode { get; set; }
        public string Email { get; set; }
        public string DocName { get; set; }
        public string DocType { get; set; }
        public byte[] Document { get; set; }
        public DateTime? SubmissionTime { get; set; }
    }
}