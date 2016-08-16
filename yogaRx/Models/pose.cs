using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yogaRx.Models
{
    public class Pose
    {
        public int PoseId { get; set; }
        [MaxLength (50)]
        public string PoseName { get; set; }
        public string PoseDesc { get; set; }
        public string Photo { get; set; }


        //Navigation
        public virtual ICollection<Ailment> Ailments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}