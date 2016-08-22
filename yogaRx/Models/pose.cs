using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace yogaRx.Models
{
    public class Pose
    {
        private ICollection<Ailment> _ailments;

        public int PoseId { get; set; }
        [MaxLength (50)]
        public string PoseName { get; set; }
        public string PoseDesc { get; set; }
        public string Photo { get; set; }
        public string Photo1 { get; set; }


        //Navigation
        public virtual ICollection<Ailment> Ailments
        {
            get { return _ailments ?? (_ailments = new Collection<Ailment>()); }
            protected set { _ailments = value; }
        }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}