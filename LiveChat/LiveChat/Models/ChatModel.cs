using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LiveChat.Models
{
    public class ChatModel
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public PerdoruesModel User { get; set; }
    }
}