﻿namespace UniversityMobileApp.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Debt { get; set; }
        public decimal TuitionTotal { get; set; }
        public int StudentNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime Period { get; set; }
    }
}
