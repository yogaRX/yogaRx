using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yogaRx.Models
{
    public class ViewModel
    {
        public IEnumerable<Pose> Poses { get; set; }
        public IEnumerable<Ailment> Ailments { get; set; }

    }
}