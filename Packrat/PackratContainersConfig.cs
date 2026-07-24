using System.Collections.Generic;

namespace Packrat;

/// <summary>
/// One mod container type to support in the storage browser.
/// Loaded from ModConfig/packratfork-containers.json so users and modpack makers
/// can add support for other storage mods without a new Packrat release.
/// </summary>
public class ContainerEntry
{
    /// <summary>Full .NET type name of the block entity (as reported by crash logs / decompilers)</summary>
    public string Type { get; set; }

    /// <summary>True if the type has its own OnReceivedServerPacket handling the vanilla OpenInventory packet (not inherited from a patched base)</summary>
    public bool NeedsPatch { get; set; }

    /// <summary>True if the type never sends the vanilla OpenInventory packet; the browser reads its (already synced) inventory directly. Without this, browse waits for the 3s timeout.</summary>
    public bool DirectAccess { get; set; }

    /// <summary>Fixed number of leading inventory slots to hide in the browser (e.g. slots that hold the container blocks themselves)</summary>
    public int HiddenLeadingSlots { get; set; }

    /// <summary>Name of a public int field on the inventory class to read the hidden-slot count from at runtime. Overrides HiddenLeadingSlots when the field exists.</summary>
    public string HiddenLeadingSlotsField { get; set; }
}

/// <summary>
/// Registry of mod container types, persisted as a mod config file.
/// Defaults are written on first start; see PackratModSystem.DefaultContainerEntries.
/// </summary>
public class PackratContainersConfig
{
    public List<ContainerEntry> Containers { get; set; } = new();
}
