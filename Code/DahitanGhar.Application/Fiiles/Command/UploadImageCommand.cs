using DahitanGhar.Application.Interfaces;
using DahitanGhar.Domain.Common;
using DahitanGhar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahitanGhar.Application.Fiiles.Command;

public class UploadImageCommand : IRequest<OperationResult>
{
    public required UploadImageDto uploadImageDto { get; set; }
}


public class UploadImageCommandHandler : IRequestHandler<UploadImageCommand, OperationResult>
{
    private readonly IDgDbContext dgDbContext;
    public UploadImageCommandHandler(IDgDbContext _dgDbContext)
    {
        dgDbContext = _dgDbContext;
    }
    public async Task<OperationResult> Handle(UploadImageCommand request, CancellationToken cancellationToken)
    {
        try
        {
            string UploadDir = "D:\\My-Projects\\DgImages";

            if (!Directory.Exists(UploadDir))
            {
                Directory.CreateDirectory(UploadDir);
            }

            // Generate unique file name
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(request.uploadImageDto.Image.FileName);
            string fileFullPath = Path.Combine(UploadDir, fileName);

            // Upload the file
            using (var stream = new FileStream(fileFullPath, FileMode.Create))
            {
                await request.uploadImageDto.Image.CopyToAsync(stream, cancellationToken);
            }

            // Prepare image entity
            var newImageToAdd = new ImageEntity
            {
                Source = fileFullPath,
                ImageType = request.uploadImageDto.ImageType,
                Title = request.uploadImageDto.Title,
                IsCarousalActive = request.uploadImageDto.IsCarousalActive,
                Description = new ImageDescriptionEntity
                {
                    CostPerNight = request.uploadImageDto.CostPerNight,
                    Summary = request.uploadImageDto.Summary,
                    RoomType = request.uploadImageDto.RoomType
                }
            };

            // Save image entity to the database
            await dgDbContext.Images.AddAsync(newImageToAdd, cancellationToken);
            await dgDbContext.SaveChangesAsync(cancellationToken);

            return OperationResult.Success();
        }
        catch (UnauthorizedAccessException ex)
        {
            // Handle permission errors
            return OperationResult.Failure("Access denied while uploading the file. Please check permissions.");
        }
        catch (Exception ex)
        {
            // Log error and provide user-friendly message
            return OperationResult.Failure("An error occurred while uploading the file. Please try again.");
        }
    }

}
