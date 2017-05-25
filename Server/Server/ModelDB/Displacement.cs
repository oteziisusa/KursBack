namespace ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Displacement")]
    public partial class Displacement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public int ItemId { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime? Departure { get; set; }

        public virtual Item Item { get; set; }

        public virtual Room Room { get; set; }
    }
}
