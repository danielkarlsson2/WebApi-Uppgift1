﻿namespace WebApi_Uppgift1.Models
{
    public class CustomerTask
    {
        public int Id { get; set; }
        public string? Headline{ get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte TaskStatus  { get; set; }
        public string? TextMessage { get; set; }

    }
}
