using System;
using System.Collections.Generic;

namespace myWebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime EnrollMentDate { get; set; }
    }
}