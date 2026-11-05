# 🎯 NumberGuessingGame CLI

A simple interactive number guessing game built with C# and .NET. Challenge yourself across three difficulty levels and try to guess the randomly generated number before running out of attempts.

## ✨ Features

- 🎲 Random number generation between 1 and 100
- 🎮 Three difficulty levels:
  - **Easy:** 10 attempts
  - **Medium:** 5 attempts
  - **Hard:** 3 attempts
- 💡 Helpful hints after each guess
- 🔢 Attempt counter
- 🔁 Option to restart the game
- 💻 Command-line interface (CLI)
- ⚡ Lightweight application with no external dependencies

## 🚀 Installation

1. Open the [Releases](https://github.com/joshuu43/Number-Guessing-Game/releases) page.
2. Download the latest `number-guess-setup.exe` installer.
3. Run the installer and follow the instructions.
4. Open a new terminal window to use the CLI.

The installer adds the application to your user `PATH`, allowing you to run it from any directory.

## 🖥️ Usage

### Available Commands

| Command | Description |
|---|---|
| `number-guess start` | Starts a new game |
| `number-guess --help` | Displays available commands |

### Start a Game

```bash
number-guess start
```

### Display Help

```bash
number-guess --help
```

## 🎮 How to Play

1. Start the game using the `start` command.
2. Select one of the three difficulty levels.
3. Enter your guesses.
4. Follow the hints to determine whether the secret number is higher or lower.
5. Try to guess the correct number before running out of attempts.
6. Choose whether to play again.

## 🛠️ Built With

- **C#** — Main programming language
- **.NET 10** — Application framework
- **Visual Studio** — Development environment
- **Inno Setup** — Windows installer

## 📚 What I Learned

- Working with command-line arguments in C#
- Using `switch` statements and conditional logic
- Generating random numbers with the `Random` class
- Handling user input through the console
- Creating interactive terminal applications
- Publishing standalone .NET applications
- Creating Windows installers with Inno Setup

## 🗺️ Project Challenge

This project is based on the [Number Guessing Game challenge from roadmap.sh](https://roadmap.sh/projects/number-guessing-game).

## 👨‍💻 Author

Developed by [@joshuu43](https://github.com/joshuu43).

If you have suggestions or find an issue, feel free to open an issue in this repository.
