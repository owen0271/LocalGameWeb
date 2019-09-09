using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameWebApp.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        public int GameRmID { get; set; }
        public string NickName { get; set; }
        [Required]
        int SeatNumber { get; set; } = 0;
        [Required]
        string Charactor { get; set; } = "NotAssigned";
        [Required]
        int Status { get; set; } = Int32.MinValue;

    }
}
