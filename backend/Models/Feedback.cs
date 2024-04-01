using System;

namespace FeedBackPortal.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }  // Primary Key
        public string Subject { get; set; }  // subject line of feedback ("Wow, Squidward was so welcoming!")
        public string Content { get; set; }  // body of feedback
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public int CategoryId { get; set; }  // Foreign key references Category table

        public Category Category { get; set;}
    }
}