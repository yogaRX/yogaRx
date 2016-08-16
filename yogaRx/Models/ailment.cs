using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace yogaRx.Models
{
    public class Ailment
    {
        public int AilmentId { get; set; }
        [MaxLength (50)]
        public string AilmentName { get; set; }
        public string AilmentDesc { get; set; }


        //Navigation
        public virtual ICollection<Pose> Poses { get; set; }
        
    }
}