using GameWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameWebApp.Models
{
    public class GameRoom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PlayerNumber { get; set; }
        [NotMapped()]
        public ICharactor[] Charactors { get; set; }
    }
}
