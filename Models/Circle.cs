using System;
using System.ComponentModel.DataAnnotations;

namespace ShapesAPI.Models
{
    public class Circle : IShape
    {
        [Required]
        public double Radius { get; set; }

        public double Diameter 
        { 
            get 
            {
                return Radius * 2;
            }
        }

        public double Area 
        { 
            get 
            {
                return Math.PI * Radius * Radius;
            }
        }

        public double Perimeter 
        { 
            get 
            {
                return 2 * Math.PI * Radius;
            }
        }
    }
}