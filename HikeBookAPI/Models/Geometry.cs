namespace HikeBookAPI.Models
{
    public class Geometry
    {
        public string Type { get; set; }
        public List<double> PointCoordinates { get; set; } // For Points
        public List<List<double>> LineStringCoordinates { get; set; } 
    }
}
