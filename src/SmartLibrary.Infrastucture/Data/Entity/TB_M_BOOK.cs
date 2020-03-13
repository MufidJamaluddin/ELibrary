using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLibrary.Infrastructure.Data.Entity
{
    public class TB_M_BOOK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public ICollection<TB_M_AUTHOR> Authors { get; set; }

        [Required]
        [StringLength(100)]
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
