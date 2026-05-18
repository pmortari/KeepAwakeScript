# KeepAwake Script

A simple yet effective utility to prevent your Windows system from entering sleep or lock modes by simulating keyboard input at regular intervals.

## Overview

This repository contains lightweight implementations that keep your computer awake by sending periodic keyboard input to prevent the system from entering sleep, screen lock, or screensaver modes. This is useful for various scenarios including long-running tasks, automated processes, and maintaining network connectivity without manual interaction.

## Features

- **Multiple Implementation Options**: Choose between PowerShell, Batch script, or .NET Console application
- **Minimal Resource Usage**: Lightweight solutions that run efficiently in the background
- **Random Intervals**: Uses randomized sleep intervals to appear more natural and avoid detection
- **Non-Intrusive**: Uses the F15 key (a special function key) that has no visible effect on your screen
- **Cross-Version Support**: Implementations available for different preferences and scenarios

## Files

### `KeepAwake.ps1` (PowerShell Version)

A PowerShell implementation that:
- Creates a WScript.Shell COM object to send keyboard inputs
- Sends a Shift+F15 key combination every 45-85 seconds (random interval)
- Runs in an infinite loop until manually terminated

**Requirements:**
- PowerShell 2.0 or higher
- Windows operating system

**Usage:**
```powershell
powershell -ExecutionPolicy Bypass -File KeepAwake.ps1
```

Or run directly in PowerShell:
```powershell
.\KeepAwake.ps1
```

### `KeepAwake.bat` (Batch Script Version)

A batch file wrapper version for quick execution from Command Prompt or Windows Explorer. This is a convenient way to run the PowerShell script without having to navigate to the directory or adjust execution policies.

**Usage:**
```cmd
KeepAwake.bat
```

### `.NET` Folder (.NET Console Application)

A modern C# console application built with .NET that provides the same functionality with better performance and no PowerShell dependency.

**Features:**
- Direct Windows API integration using P/Invoke
- No dependency on WScript.Shell COM objects
- Native .NET console application
- Targets .NET 10.0 for optimal performance
- Sends Shift+F15 key combination every 45-85 seconds (random interval)

**Requirements:**
- Windows operating system
- .NET 10.0 Runtime or later (or .NET 10.0 SDK to build from source)

**Files in `.NET` folder:**
- `Program.cs` - Main console application
- `KeepAwake.csproj` - Project file
- `KeepAwake.slnx` - Solution file

**Building from Source:**
```bash
dotnet build
```

**Running:**
```bash
dotnet run
```

Or after building:
```bash
.\bin\Debug\net10.0\KeepAwake.exe
```

## How It Works

All implementations operate on the same principle:

1. **Input Simulation**: They simulate keyboard input to wake the system
2. **Key Combination**: Sends a Shift+F15 key press (a non-printable function key that won't interfere with your work)
3. **Random Timing**: Waits between 45-85 seconds before sending the next input, randomized to seem more natural
4. **Continuous Loop**: Repeats indefinitely until the application is stopped

This approach prevents:
- System sleep mode
- Screen locks
- Screensaver activation
- Session timeouts on some systems

## Implementation Comparison

| Feature | PowerShell | Batch | .NET |
|---------|-----------|-------|------|
| Simplicity | Medium | High | Medium |
| Performance | Good | Good | Excellent |
| Dependencies | PowerShell | PowerShell | .NET Runtime |
| Direct API Access | No (COM-based) | No (COM-based) | Yes (P/Invoke) |
| Startup Time | Moderate | Moderate | Fast |

## Requirements

- **Operating System**: Windows (XP or later for PowerShell/Batch; Windows 7+ recommended for .NET)
- **For PowerShell Version**: PowerShell 2.0 or higher
- **For .NET Version**: .NET 10.0 Runtime or later
- **Permissions**: Administrator privileges may be required depending on your system policies

## Installation

1. Clone or download this repository:
   ```bash
   git clone https://github.com/pmortari/KeepAwakeScript.git
   ```

2. Choose your preferred version:
   - **PowerShell**: Run `KeepAwake.ps1`
   - **Batch**: Run `KeepAwake.bat`
   - **.NET**: Build and run from the `.NET` folder

3. Run the script or application

## Stopping the Script

- **PowerShell**: Press `Ctrl+C` in the PowerShell window
- **Batch**: Press `Ctrl+C` in the Command Prompt window, or close the window
- **.NET**: Press `Ctrl+C` in the console window, or close the application

## Use Cases

- Preventing system sleep during long-running tasks
- Keeping your system available during automated processes
- Maintaining network connectivity without manual interaction
- Avoiding session timeouts in remote desktop or VPN scenarios
- Keeping systems awake during presentations or demonstrations
- Maintaining uptime during background downloads or installations

## Disclaimer

Use this script responsibly. Be aware of your organization's policies regarding system automation and screen locking, especially in corporate environments. Circumventing security policies could violate organizational guidelines. Always ensure you have appropriate permissions and comply with all applicable policies and regulations in your organization.

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE](LICENSE) file for details.

## Contributing

Feel free to suggest improvements, report issues, or submit pull requests to enhance this utility. Contributions are welcome!

---

**Note**: These applications/scripts are provided as-is. Use at your own risk and ensure you comply with all applicable policies and regulations in your organization.
