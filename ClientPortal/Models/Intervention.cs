using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClientPortal.Models
{
    public class Intervention
    {
        [Key]
        public int id { get; set; }
        public DateTime intervention_start { get; set; }
        public DateTime intervention_stop { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public int author { get; set; }
        public int battery_id { get; set; }
        public int building_id { get; set; }
        public int column_id { get; set; }
        public int customer_id { get; set; }
        public int elevator_id { get; set; }
        public int employee_id { get; set; }

    }
}