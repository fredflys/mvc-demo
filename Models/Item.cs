using System.ComponentModel.DataAnnotations;

namespace mvc_demo.Models {
    public class Item {
        [Key]
        public int Id {get; set;}
        public required string? Name {get; set;}
        public string? Description {get; set;}
        public float? Price {get; set;}
        public byte[]? Image {get; set;}
        public string? ImageName {get; set;}
        public string? ImageUrl {get; set;}
    }

    public class ItemViewModel {
        public string? Name {get; set;}
        public string? Description {get; set;}
        public float? Price {get; set;}
        public string? ImageName {get; set;}
        public string? ImageUrl {get; set;}
        public IFormFile? FormFile {get; set;}
    }
}