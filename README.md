# KeepAwake Script

A simple yet effective utility to prevent your Windows system from entering sleep or lock modes by simulating keyboard input at regular intervals.

## Overview

This repository contains lightweight scripts that keep your computer awake by sending periodic keyboard input to prevent the system from entering sleep, screen lock, or screensaver modes. This is useful for situations where you want to keep your machine active without being physically present.

## Features

- **Minimal Resource Usage**: Lightweight scripts that run efficiently in the background
- **Multiple Implementation Options**: Choose between PowerShell or Batch script versions
- **Random Intervals**: Uses randomized sleep intervals to appear more natural and avoid detection
- **Non-Intrusive**: Uses the F15 key (a special function key) that has no visible effect on your screen

## Files

### `KeepAwake.ps1` (PowerShell Version)
A PowerShell implementation that:
- Creates a WScript.Shell COM object to send keyboard inputs
- Sends a Shift+F15 key combination every 55-86 seconds (random interval)
- Runs in an infinite loop until manually terminated

**Usage:**
```powershell
powershell -ExecutionPolicy Bypass -File KeepAwake.ps1
```

Or run directly in PowerShell:
```powershell
.\KeepAwake.ps1
```

### `KeepAwake.bat` (Batch Script Version)
A batch file wrapper version for quick execution from Command Prompt or Windows Explorer.

**Usage:**
```cmd
KeepAwake.bat
```

## How It Works

Both scripts operate on the same principle:

1. **Input Simulation**: They use the WScript.Shell COM object to simulate keyboard input
2. **Key Combination**: Sends a Shift+F15 key press (a non-printable function key that won't interfere with your work)
3. **Random Timing**: Waits between 55-86 seconds before sending the next input, randomized to seem more natural
4. **Continuous Loop**: Repeats indefinitely until the script is stopped

This approach prevents:
- System sleep mode
- Screen locks
- Screensaver activation
- Session timeouts on some systems

## Requirements

- **Operating System**: Windows
- **PowerShell Version**: 2.0 or higher (for the `.ps1` version)
- **Permissions**: Administrator privileges may be required depending on your system policies

## Installation

1. Clone or download this repository
2. Choose either the PowerShell or Batch version
3. Run the script you prefer

## Stopping the Script

- **PowerShell**: Press `Ctrl+C` in the PowerShell window
- **Batch**: Press `Ctrl+C` in the Command Prompt window, or close the window

## Use Cases

- Preventing system sleep during long-running tasks
- Keeping your system available during automated processes
- Maintaining network connectivity without manual interaction
- Avoiding session timeouts in remote desktop or VPN scenarios

## Disclaimer

Use this script responsibly. Be aware of your organization's policies regarding system automation and screen locking, especially in corporate environments. Circumventing security policies could violate your company's acceptable use policy.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Feel free to suggest improvements, report issues, or submit pull requests to enhance this utility.

---

**Note**: This script is provided as-is. Use at your own risk and ensure you comply with all applicable policies and regulations in your organization.