using FileExplorer.Application.Common.Models.Filtering;

namespace FileExplorer.Application.FileStorage.Models.Filtering;

public class StorageFileFilterDataModel
{
    public List<StorageFileSummary> FilterData { get; set; } = new();
}