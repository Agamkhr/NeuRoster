using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NeuRos.Domain.Entities
{
    public class NmsTeam
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        //public string Project { get; set; }
    }
}
