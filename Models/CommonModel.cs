using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDepartmentApp.API.Models
{
    public class CommonModel
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string DateTimeCreated { get; set; }
        public string Updatedby { get; set; }
        public int DateTimeUpdated { get; set; }
        public int LastTimeUpdated { get; set; }
    }
}
