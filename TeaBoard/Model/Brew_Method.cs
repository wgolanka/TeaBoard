namespace TeaBoard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tea_board.Brew_Method")]
    public partial class Brew_Method
    {
        [Key]
        [StringLength(10)]
        public string name { get; set; }

        public int time_minutes { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string instruction { get; set; }

        [Required]
        [StringLength(10)]
        public string Tea_name { get; set; }

        public virtual Tea Tea { get; set; }
    }
}
