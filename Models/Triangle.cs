using System;
using System.ComponentModel.DataAnnotations;

namespace ShapesAPI.Models
{
    public class Triangle : IShape
    {
        [Required]
        public double HeightBase { get; set; }
        [Required]
        public double Width { get; set; }

        public double Hypotenuse
        {
            get
            {
                return Math.Sqrt((HeightBase * HeightBase) + (Width * Width));
            }
        }

        public double Area
        {
            get
            {
                return (HeightBase * Width) / 2;
            }
        }

        public double Perimeter
        {
            get
            {
                return HeightBase + Width + Hypotenuse;
            }
        }

    }
}