using System.ComponentModel.DataAnnotations;

namespace Books_Pro_V1.Models
{
    public class Books
    {
        [Key]

        //Unique identifier for the book
        public int Id { get; set; }

        //Title of the book
        [Required(ErrorMessage ="Title is required.")]
        [StringLength (50,ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Title { get; set; }

        //Author of the book
        [Required(ErrorMessage = "Author is required.")]
        [StringLength (50,ErrorMessage = "Author cannot be longer than 50 characters.")]
        public string Author { get; set; }

        //Genre of the book
        [Required(ErrorMessage = "Genre is required.")]
        [StringLength (50, ErrorMessage = "Genre cannot be longer than 50 characters.")]
        public string Genre { get; set; }

        //Publication date of the book
        [Required(ErrorMessage ="Publication Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }

        //Brief description of the book 
        [StringLength (100, ErrorMessage = "Description cannot be longer than 100 characters.")]
        public string Description { get; set; }

        //Boolean value indicating if the book is checked in or not 
        [Display(Name = "Is Checked In")]
        public bool IsCheckedIn { get; set; }
        
    }
}
