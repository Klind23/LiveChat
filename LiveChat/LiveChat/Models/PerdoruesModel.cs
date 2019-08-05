using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiveChat.Models
{
    public class PerdoruesModel
    {
        [Key]
        public int Id { get; set; }
        public bool Tipi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ChatModel Chat { get; set; }
    }
}