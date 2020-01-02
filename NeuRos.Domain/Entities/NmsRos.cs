using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeuRos.Domain.Entities
{
    public class NmsRos
    {
        [Key]
        public DateTime Date { get; set; }
        [Key]
        public int MemberId { get; set; }
        public string Shift { get; set; }
        public string Attendance { get; set; }
    }
}
