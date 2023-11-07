using FileExplorer.Application.Common.Models.Filtering;

namespace FileExplorer.Application.FileStorage.Models.Filtering;

public class StorageFileFilterModel : FilterPagination
{
    public string DirectoryPaht {  get; set; } = string.Empty;

    public ICollection<StorageFileType> FileTypes { get; set; } = default!;
}