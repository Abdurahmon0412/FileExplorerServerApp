using FileExplorer.Application.FileStorage.Models.Filtering;
using FileExplorer.Application.FileStorage.Services;
using Microsoft.AspNetCore.Mvc;

namespace FileExplorer.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilesController : ControllerBase
{
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IFileProcessingService _fileProcessingService;

    public FilesController(IWebHostEnvironment hostEnvironment, IFileProcessingService fileProcessingService)
    {
        _hostEnvironment = hostEnvironment;
        _fileProcessingService = fileProcessingService;
    }

    [HttpGet("root/files/filter")]
    public async ValueTask<IActionResult> GetFilesSummary()
    {
        var result = await _fileProcessingService.GetFilterDataModelAsync(_hostEnvironment.WebRootPath);
        return Ok(result);
    }

    [HttpGet("root/files/by-filter")]
    public async ValueTask<IActionResult> GetFilesByFilter([FromQuery] StorageFileFilterModel filterModel)
    {
        filterModel.DirectoryPaht = _hostEnvironment.WebRootPath;
        var files = await _fileProcessingService.GetFilterAsync(filterModel);
        return files.Any() ? Ok(files) : NotFound(files);
    }
}