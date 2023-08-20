﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA_Core.Models
{
    public class PMA_ProjectUserJunction
    {
        [Key]
        public int ProjectUserID { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public PMA_Project Project { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public PMA_User User { get; set; }
    }
}
