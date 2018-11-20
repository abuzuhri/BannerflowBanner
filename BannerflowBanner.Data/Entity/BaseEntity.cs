using System;
using System.Collections.Generic;
using System.Text;

namespace BannerflowBanner.Data.Entity
{
    public class BaseEntity
    {
        public long ID { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Modified { get; set; }
    }
}
