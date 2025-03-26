using System.ComponentModel.DataAnnotations;

namespace DahitanGhar.Domain.Entities;

public class ImageDescriptionEntity
{
	[Key]
    public int Id { get; set; }
	public int ImageId { get; set; }
	public int? CostPerNight { get; set; }
    public string? Summary { get; set; }
	public string? RoomType { get; set; }
	public ImageEntity Image { get; set; }
	public ImageDescriptionEntity()
	{

	}
}
