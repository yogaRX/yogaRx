using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yogaRx.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public short? SymbolRating { get; set; }
        public string TextReview { get; set; }
        public int PoseId { get; set; }
        public int AilmentId { get; set; }



        //Navigation
        public virtual ApplicationUser User { get; set; }
        public virtual Pose Pose { get; set; }
        public virtual Ailment Ailment { get; set; }
    }
}