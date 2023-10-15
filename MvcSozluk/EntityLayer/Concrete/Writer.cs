﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName{ get; set; }
        [StringLength(50)]
        public string WriteSurName{ get; set; }
        [StringLength(100)]

        public string WriteImage{ get; set; }
        [StringLength(100)]
        public string WriterAbout{ get; set; }
        [StringLength(200)]
        public string WriteMail{ get; set; }
        [StringLength(200)]
        public string WriterPassword{ get; set; }
        [StringLength(50)]
        public string WriterTitle { get; set; }

        public ICollection<Heading> Headings { get; set; } //bu collectiondan cek
        public ICollection<Content> Contents { get; set; }
    }
}
