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
        public PerdoruesModel Perdorues { get; set; }
        public int PerdoruesId { get; set; }
        public DateTime KohaMesazhit { get; set; }
        public string Mesazhi { get; set; }
    }
}