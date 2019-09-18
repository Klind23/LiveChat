using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiveChat.Models
{
    public class RoomModel
    {
        [Key]
        public int roomId { get; set; }
        public ChatModel chat { get; set; }
        public PerdoruesModel perdorues { get; set; }
    }
}