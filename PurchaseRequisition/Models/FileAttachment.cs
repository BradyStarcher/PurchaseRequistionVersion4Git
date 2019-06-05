using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class FileAttachment
    {
        public int RequestID { get; set; }

        [ForeignKey(nameof(RequestID))]
        public Request Request { get; set; }

        [Required]
        public byte[] Content { get; set; }

        public string ContentType { get; set; }

        public string FileName { get; set; }
    }
}
