using Microsoft.AspNetCore.Http;

namespace DahitanGhar.Application.Fiiles.Command;

public class UploadImageDto
{
    public IFormFile Image { get; set; }
    public string ImageType { get; set; }
    public string Title { get; set; }
    public int? CostPerNight { get; set; }
    public string? Summary { get; set; }
    public string? RoomType { get; set; }
    public bool IsCarousalActive { get; set; }
    public UploadImageDto()
    {

    }
}

