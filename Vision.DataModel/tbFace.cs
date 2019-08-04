using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.DataModel
{
    public class tbFace
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        [StringLength(100)]
        public string Plate { get; set; }

        [StringLength(100)]
        public string Direction { get; set; }

        public int PlateImageSmId { get; set; }
        public tbBinaryData PlateImageSm { get; set; }

        public int PlateImageBgId { get; set; }
        public tbBinaryData PlateImageBg { get; set; }
    }
}
