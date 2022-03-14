using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public string Experience { get; set; }
        public Job()
        {
        }
    }
}
