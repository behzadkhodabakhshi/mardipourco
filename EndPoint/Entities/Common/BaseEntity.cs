﻿using System.ComponentModel.DataAnnotations;

namespace EndPoint.Entities.Common
{
    public class BaseEntity
    {

        [Key]
        public long Id { get; set; }
        public bool IsDelete { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
