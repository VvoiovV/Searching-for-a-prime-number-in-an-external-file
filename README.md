This project is a **C# application** that searches a text file for identifiers containing only prime numbers in their numeric part. The program reads the file line by line, analyzes its content, and prints identifiers that meet the prime number criteria.
## Features
- Reads data from a text file named `identyfikator.txt`.
- Verifies if the numeric part of the identifier consists only of prime numbers.
- Outputs the matching identifiers to the console.
## Identifier Structure
Each line in the file should be a string where:
1. The first 3 characters are textual (e.g., "ABC").
2. The rest of the line (numeric part) consists of digits that are analyzed.

**Example file content (`identyfikator.txt`):**
```
ABC2357
DEF1234
GHI357
```

**Program output for the above file:**
```
ABC2357
GHI357
```
(Only these identifiers have numeric parts consisting of prime numbers.)

---

## How to Run
1. Ensure you have .NET installed (e.g., Visual Studio or .NET SDK).
2. Copy the code below into a file named `Program.cs`.
3. Create a text file named `identyfikator.txt` in the program's working directory and add your input data.
4. Run the program:
   ```bash
   dotnet run
   ```
   ## Possible Improvements
- **Input validation**: Add error handling for missing or malformed input files.
- **Dynamic file paths**: Allow users to specify the file path as a command-line argument.
- **Unit tests**: Add tests to verify the functionality of `IsPrime` and `IsPrimeString` functions.
- **Result reporting**: Save the output to an external file.
