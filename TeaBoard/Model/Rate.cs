namespace TeaBoard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tea_board.Rate")]
    public partial class Rate
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime date { get; set; }

        [Key]
        [Column("rate", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rate1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Tea_name { get; set; }

        public virtual Tea Tea { get; set; }
    }
}
