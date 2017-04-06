using System;

namespace finalProject

{
    public class Issue
    {
        public string EquipmentID { get; set; }
        public string StudentId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string RentalId { get; internal set; }
    }
}