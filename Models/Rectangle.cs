using System.ComponentModel.DataAnnotations;

namespace ShapesAPI.Models
{
    public class Rectangle : IShape
    {
        [Required]
        public double Height { get; set; }
        [Required]
        public double Width { get; set; }
        
        public double Area 
        { 
            get
            {
                return Height * Width;
            }
        }

        public double Perimeter 
        { 
            get
            {
                return 2 * ( Height + Width);
            }
        }
    }
}