using Chats.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chats.Models
{
    public class AppChats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Openness { get; set; }
        public string UserId { get; set; }
        public int TopicId { get; set; }

        [ForeignKey("TopicId")]
        public Topics Topics { get; set; }
        public DateTime LastVisit { get; set; }
        public bool RemovalCandidate { get; set; }

    }
}
