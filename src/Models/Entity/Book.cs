using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLibrary.Web.Models.Entity
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public ICollection<Author> Authors { get; set; }

        [Required]
        [StringLength(100)]
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
