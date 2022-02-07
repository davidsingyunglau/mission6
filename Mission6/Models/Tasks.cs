using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Tasks
    {
        [Key]
        [Required]
        public int TaskID { get; set; }

        [Required]
        public string Task { get; set; }

        
        public DateTime DueDate { get; set; }

        [Required]
        public int Quadrant { get; set; }

        //Build Foreign key Relationship
        
        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public bool Completed { get; set; }


        //Build Foreign key Relationship
        
    }
}


 
