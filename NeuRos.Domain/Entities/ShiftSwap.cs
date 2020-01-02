using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NeuRos.Domain.Entities
{
    public class ShiftSwap
    {
        [Key]
        public int Month { get; set; }
        [ForeignKey("NmsTeam")]
        [Key]
        public int EmpId { get; set; }
        [Key]
        public int MemberId { get; set; }
    }
}
