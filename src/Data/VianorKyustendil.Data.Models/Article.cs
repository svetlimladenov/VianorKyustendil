using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VianorKyustendil.Data.Models
{
    public class Article
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string CoverImageUrl { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public VianorKyustendilUser Author { get; set; }


    }
}
