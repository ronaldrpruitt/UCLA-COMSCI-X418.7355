using System;
using System.Data.Linq.Mapping;

namespace week7_rpruitt
{
    [Table(Name = "Guests")]
    public class Guests
    {
        [Column()]
        public int GuestId { get; set; }

        [Column()]
        public string FirstName { get; set; }

        [Column()]
        public string LastName { get; set; }

        [Column()]
        public bool SignedInStatus { get; set; }

        [Column()]
        public string ApartmentId { get; set; }

        [Column()]
        public DateTime LastModified { get; set; }
    }
}
