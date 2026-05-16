# Packrat Fork — Storage Browser

**Fork of the [original mod](https://mods.vintagestory.at/show/mod/36243) by [dizzyd](https://mods.vintagestory.at/show/user/C0109EAD44B2C9580E9B) — [GitHub](https://github.com/dizzyd/packrat)**

View, search, and sort the contents of all nearby containers at once — perfect for the compulsive hoarder in all of us.

## What is a pack rat?

The term "pack rat" comes from the North American woodrat, famous for collecting and storing an eclectic variety of objects in its nest. Like its namesake, any dedicated Vintage Story player eventually accumulates room after room of carefully organized — or _not-so-carefully_ organized — supplies.

Packrat helps you find what you need without opening every chest.

## Features

| Feature                    | Description                                                                                                                                                                        |
| -------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **One-key browsing**       | Press `R` to open a unified view of all containers within 5 blocks.                                                                                                                |
| **Room detection**         | In an enclosed room, opens everything regardless of line-of-sight. In open areas, requires visibility to each container.                                                           |
| **Container highlighting** | Each container's slots are color-coded so you always know which chest or crate holds what.                                                                                         |
| **Search & filter**        | Type to filter by item name, block material (stone, wood, metal), or food category (protein, grain, vegetable). Press `/` to focus the search box instantly.                       |
| **Sorting**                | Sort all slots by name (A-Z), category, material, or spoilage time. Re-clicking the same sort mode re-sorts after item changes. Empty slots can be shown or hidden via the toggle. |
| **Smart transfers**        | Shift-click prioritizes crates with matching items, then empty crates, then chests.                                                                                                |
| **Crate awareness**        | Respects single-item-type restrictions and shows ghost items in empty crate slots.                                                                                                 |
| **Localisation**           | UI strings translated into English, Italian, French, German, Spanish, Russian, Ukrainian, Portuguese, and Polish.                                                                  |

## How to use

1. Build a storage room with chests and/or crates.
2. Press `R` (rebindable in controls) while standing inside.
3. Browse the unified grid — colored backgrounds indicate different containers.
4. Use the **search box** (or press `/`) to filter by item name, material, or food category.
5. Use the **sort dropdown** to order slots by name, category, material, or spoilage time.
6. Toggle **Show Empty** to hide or show empty slots when sorting is active.
7. Click or shift-click to move items as usual.

> **Note:** Packrat respects reinforced and locked containers — if you can't open it normally, Packrat won't open it either.

## Sort modes

| Mode           | Description                                                         |
| -------------- | ------------------------------------------------------------------- |
| **None**       | Original container order, grouped by container.                     |
| **A-Z**        | Alphabetical by item display name.                                  |
| **Category**   | Grouped by type: tools, weapons, food, clothing, blocks, resources. |
| **Material**   | Grouped by material (copper, iron, wood, stone, …).                 |
| **Perishable** | Soonest-to-expire items first; non-perishables at the end.          |

## Building

- **Build & package:** `./build.ps1` (Windows) or `./build.sh` (Linux/macOS)
- **Clean artifacts:** `./clean.sh`
- **Environment:** Requires .NET 10 and `VINTAGE_STORY` environment variable pointing to your Vintage Story installation
