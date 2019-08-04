using System;

namespace Vision.DataModel
{
    public class tbBinaryData
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreateDate { get; set; }

        public tbBinaryData()
        {
            CreateDate = DateTime.Now;
        }

        public tbBinaryData(byte[] data)
        {
            CreateDate = DateTime.Now;
            Data = data;
        }
    }
}
