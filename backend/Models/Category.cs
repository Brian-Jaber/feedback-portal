namespace FeedBackPortal.Models
{
    public class Category  // Category table
    {
        public int CategoryId { get; set; }  // Primary Key
        public string Name { get; set; }  //  Name of category to be used in feedback (i.e. customer service, product catalogue, accesibility)

        public List<Feedback> Feedbacks {get; set;}
    }
}