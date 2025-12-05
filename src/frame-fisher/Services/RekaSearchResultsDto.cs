using System;
using System.Text.Json.Serialization;

namespace FrameFisher.Services;

public class RekaSearchResultsDto
{
    [JsonPropertyName("results")]
    public RekaSearchResultDto[] Results { get; set; } = Array.Empty<RekaSearchResultDto>();

}
