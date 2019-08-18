using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Project
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Project Number")]
        public string ProjectNumber { get; set; }

        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        [Display(Name ="Supplement Number")]
        public int SupplementNumber { get; set; }

        [Display(Name = "Sequence Number")]
        public int SequenceNumber { get; set; }


    }
}
