# GoblinMode

GoblinMode is a turn-based RPG where you create and customize your own goblin character, explore a quirky goblin town, interact with NPCs, and battle various opponents. The project is implemented in C# with both a classic Windows Forms version and a modern .NET MAUI cross-platform version.

## Table of Contents

- [Features](#features)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Gameplay Overview](#gameplay-overview)
- [Building and Running](#building-and-running)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- **Character Creation:** Allocate stat points to customize your goblin's abilities and choose your portrait.
- **Turn-Based Combat:** Battle a variety of enemies with options to attack, block, or run.
- **Dialogue System:** Interact with quirky NPCs, including the wise "Old Gob," and navigate branching dialogues.
- **Town Hub:** Rest to regain health, get help, or pick new opponents to fight.
- **Cross-Platform:** Playable as a Windows Forms app or as a .NET MAUI app (Windows, Mac Catalyst, and more).

---

## Project Structure

```
GoblinMode.sln
|
|-- GoblinMode/         # Windows Forms application
|-- GoblinModeMaui/     # .NET MAUI cross-platform application
|-- GameLogic2/         # Core game logic (shared)
|-- Game/               # (Appears to be a duplicate or legacy logic folder)
|-- TestMaui/           # (Test project for MAUI, if present)
```

- **GoblinMode/**: Main Windows Forms UI, forms for title, character creation, town, battle, and dialogue.
- **GoblinModeMaui/**: .NET MAUI UI, pages for character creation, town, battle, and dialogue.
- **GameLogic2/**: Core logic for characters, battles, items, and dialogue, shared by both UIs.

---

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 2022 or later (with MAUI workload for cross-platform)
- Windows 10+ for Windows Forms version

### Cloning the Repository

```sh
git clone <your-repo-url>
cd GoblinMode
```

---

## Gameplay Overview

1. **Start the Game:** Launch the app and begin at the title screen.
2. **Create Your Goblin:** Assign stat points (Power, Sneak, Grit, Mischief, Cunning, Skitter, Gleam) and choose a portrait.
3. **Explore the Town:** Rest, get help from NPCs, or select an enemy to fight.
4. **Battle:** Use turn-based combat mechanics to defeat enemies or retreat if needed.
5. **Dialogue:** Engage in branching conversations with NPCs for tips and flavor.

---

## Building and Running

### Windows Forms Version

```sh
dotnet build GoblinMode/GoblinMode.csproj
dotnet run --project GoblinMode/GoblinMode.csproj
```

### .NET MAUI Version

```sh
dotnet build GoblinModeMaui/GoblinModeMaui.csproj
dotnet run --project GoblinModeMaui/GoblinModeMaui.csproj
```

> **Note:** For MAUI, ensure you have the required workloads installed. See [MAUI documentation](https://learn.microsoft.com/en-us/dotnet/maui/) for setup.
