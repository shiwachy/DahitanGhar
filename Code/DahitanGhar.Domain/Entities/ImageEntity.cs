using System.ComponentModel.DataAnnotations;

namespace DahitanGhar.Domain.Entities;

public class ImageEntity
{
    [Key]
    public int ImageId { get; set; }
    public string Source { get; set; }
    public string ImageType { get; set; }
    public string Title { get; set; }
    public bool IsCarousalActive { get; set; }
    public ImageDescriptionEntity Description { get; set; }
}
