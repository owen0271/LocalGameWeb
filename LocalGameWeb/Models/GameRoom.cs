using LocalGameWeb.Enums;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalGameWeb.Models
{
    public class GameRoom
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public int PlayerNumber {get; set;}
        public GameTypes GameType { get; set; }

        private string Password { get; set; }
    }
}
