namespace Packrat;

/// <summary>
/// Client-side configuration for Packrat mod
/// </summary>
public class PackratConfig
{
    /// <summary>
    /// The last-used sort mode in the storage browser
    /// </summary>
    public SortMode SortMode { get; set; } = SortMode.None;

    /// <summary>
    /// Whether empty slots should be visible when sorting is active
    /// </summary>
    public bool ShowEmptySlotsWhenSorting { get; set; } = true;
}
