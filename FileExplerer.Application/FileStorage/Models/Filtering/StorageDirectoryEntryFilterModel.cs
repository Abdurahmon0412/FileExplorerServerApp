using FileExplorer.Application.Common.Models.Filtering;

namespace FileExplorer.Application.FileStorage.Models.Filtering;

public class StorageDirectoryEntryFilterModel : FilterPagination
{
    public bool IncludeDirectories { get; set; }

    public bool IncludeFiles { get; set; }
}