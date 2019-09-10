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
        public int id { get; set; }
        public PerdoruesModel perdorues { get; set; }
        public int perdoruesId { get; set; }
        public DateTime kohaMesazhit { get; set; }
        public string mesazhi { get; set; }
    }
}