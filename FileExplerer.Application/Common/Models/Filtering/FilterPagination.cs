using System.Text.Json.Serialization;

namespace FileExplorer.Application.Common.Models.Filtering;

public class FilterPagination
{
    public virtual uint PageSize { get; set; } = 10;

    public virtual uint PageToken { get; set;} = 1;
}