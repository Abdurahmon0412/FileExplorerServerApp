using FileExplorer.Application.FileStorage.Models.Filtering;

namespace FileExplorer.Application.Common.Models.Filtering;

public class StorageFileSummary
{
    public StorageFileType FileType { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public long Count { get; set; }

    public long Size { get; set; }

    public string ImageUrl { get; set; } = string.Empty;
}