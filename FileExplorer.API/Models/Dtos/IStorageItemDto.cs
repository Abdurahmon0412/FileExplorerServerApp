using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.API.Models.Dtos;

public interface IStorageItemDto
{
    string Path { get; set; }

    StorageEntryType EntryType { get; set; }
}