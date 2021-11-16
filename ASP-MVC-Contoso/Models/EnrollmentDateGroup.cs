using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public Nullable<DateTime> EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
