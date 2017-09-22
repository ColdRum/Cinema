namespace Cinema.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Show
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Show()
        {
            Sold__or_Reserved_Tickets = new HashSet<Sold__or_Reserved_Tickets>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShowId { get; set; }

        [Required]
        [StringLength(40)]
        public string ShowName { get; set; }

        public DateTime Date { get; set; }

        public int HallId { get; set; }

        public virtual Hall Hall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sold__or_Reserved_Tickets> Sold__or_Reserved_Tickets { get; set; }
    }
}
