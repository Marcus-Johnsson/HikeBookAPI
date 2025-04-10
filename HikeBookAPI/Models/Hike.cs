using System.ComponentModel.DataAnnotations;

namespace HikeBookAPI.Models
{
    public class Hike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public int Difficulty { get; set; }
        public string PathType { get; set; }
        public List<Feature> Features { get; set; }
    }
}
