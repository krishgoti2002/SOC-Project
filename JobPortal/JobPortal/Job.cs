using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    [DataContract]
    public class Job
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }

        [DataMember]
        [Required]
        public string Description { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [Required]
        public string MobileNo { get; set; }

        [DataMember]
        [Required]
        public string City { get; set; }

        [DataMember]
        [Required]
        public string State { get; set; }

        [DataMember]
        [Required]
        public DateTime Date { get; set; }

        [DataMember]
        [Required]
        public string Company { get; set; }

        [DataMember]
        public string Experience { get; set; }

        public Job()
        {
        }
    }
}
