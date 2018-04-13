using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        [Key]
        public virtual int Tid { get; set; }
        public virtual string Name { get; set; }
    }
}