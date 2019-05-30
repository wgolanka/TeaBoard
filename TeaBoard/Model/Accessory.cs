namespace TeaBoard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tea_board.Accessory")]
    public partial class Accessory
    {
        [Key]
        [StringLength(10)]
        public string name { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        [Required]
        [StringLength(10)]
        public string Tea_name { get; set; }

        public virtual Tea Tea { get; set; }
    }
}
