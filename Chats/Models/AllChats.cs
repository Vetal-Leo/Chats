using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chats.Models
{
    public class Allchats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Openness { get; set; }
        public string UserId { get; set; }     
        public int TopicId { get; set; }

        [ForeignKey("TopicId")]
        public  Topics Topics { get; set; }
        public DateTime LastVisit { get; set; }
        public bool RemovalCandidate { get; set; }  
        
    }
}
