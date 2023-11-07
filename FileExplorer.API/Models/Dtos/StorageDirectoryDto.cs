using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.API.Models.Dtos;

public class StorageDirectoryDto : IStorageItemDto
{
    public string Name { get; set; } = string.Empty;

    public string Path { get; set; } = string.Empty;

    public long ItemsCount { get; set; }

    public StorageEntryType EntryType { get; set; }
}