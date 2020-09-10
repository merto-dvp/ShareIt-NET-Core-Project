using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareIT.Models
{
    public class UploadedFile
    {
        [Key]
        public string id { get; set; } //Randomized name

        public string fileName { get; set; } //Real filename
        public string userGuid { get; set; } //User id
        public string extension { get; set; }//Extension
        public long fileSize { get; set; } //Filesize
        public string userName { get; set; } //Username
        public DateTime date { get; set; }
        public string imgExt { get; set; }
    }
}
