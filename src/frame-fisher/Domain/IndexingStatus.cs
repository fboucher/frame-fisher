using System;

namespace FrameFisher.Domain;

/// <summary>
/// Enumeration of possible indexing statuses
/// </summary>
public enum IndexingStatus
{
    Pending,
    Indexing,
    Indexed,
    Failed
}