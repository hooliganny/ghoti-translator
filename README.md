# Ghoti Translator

Ghoti Translator is a simple Blazor WebAssembly application that takes user input and transforms it into an idiosyncratic spelling - based loosely on the fact that English is an inconsistent language that has many ways of spelling the same phonemes - i.e. how "fish" can be spelt as "ghoti", as 'gh' can be an "f" sound (think "enough"), "o" can be an "i" sound (think "women"), and "ti" can be an "sh" sound (think "nation").

## Core Features

- Enter any text into a textarea
- The app converts the input to an alternative, "ghoti"-ised spelling

## TODO/Future Improvements

- Improve phonetic-based transformation rules for better accuracy
- Allow users to add/select different phonetic rules that are potentially missing

# Tech Stuff

- Built with Blazor WebAssembly for fast, client-side rendering (and an excuse to learn C#/Blazor/WASM)
- Deployed as a static site via GitHub Actions and GitHub Pages

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/hooliganny/ghoti-translator.git
   cd ghoti-translator
   ```

2. Ensure you have .NET installed. If not, download it from https://dotnet.microsoft.com.

3. Run the project locally:

   ```bash
   dotnet run
   ```

4. Open the browser at https://localhost:5001/ (or the provided URL).
