namespace Cinema.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Row
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowId { get; set; }

        public int RowNumber { get; set; }

        public int HallId { get; set; }

        public virtual Hall Hall { get; set; }
    }
}
