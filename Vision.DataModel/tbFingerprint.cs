using SourceAFIS.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.DataModel
{
    public class tbFingerprint:Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string FatherName { get; set; }

        public int PhotoId { get; set; }
        public tbBinaryData Photo { get; set; }

        public ICollection<tbBinaryData> Templates { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(100)]
        public string PersonStatus { get; set; }
    }
}
