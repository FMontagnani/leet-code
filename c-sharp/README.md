# C# LeetCode Solutions

This folder contains C# implementations of LeetCode problems.

## 🛠️ Setup

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio, VS Code, or any C# compatible IDE

### Installation
1. Make sure you have .NET SDK installed:
   ```bash
   dotnet --version
   ```

2. Navigate to the project directory:
   ```bash
   cd c-sharp/LeetCodeSolutions
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

## 🚀 Running Solutions

### Run the main program:
```bash
dotnet run
```

### Build the project:
```bash
dotnet build
```

### Run in release mode:
```bash
dotnet run --configuration Release
```

## 📁 Project Structure

```
LeetCodeSolutions/
├── Solutions/           # Individual problem solutions
│   ├── 1-two-sum.cs    # Two Sum problem solution
│   └── ...             # More solutions
├── Tests/              # Test cases for solutions
│   ├── TwoSumTests.cs  # Tests for Two Sum
│   └── ...             # More test files
├── Program.cs          # Main entry point
└── LeetCodeSolutions.csproj
```

## 📝 Adding New Solutions

1. Create a new file in the `Solutions/` folder following the naming convention:
   ```
   <problem-number>-<problem-name>.cs
   ```

2. Use the following template:
   ```csharp
   namespace LeetCodeSolutions.Solutions
   {
       /// <summary>
       /// LeetCode Problem X: Problem Name
       /// Difficulty: Easy/Medium/Hard
       /// 
       /// Problem description...
       /// 
       /// Time Complexity: O(?)
       /// Space Complexity: O(?)
       /// </summary>
       public class ProblemName
       {
           public ReturnType SolutionMethod(InputType input)
           {
               // Your solution here
           }
       }
   }
   ```

3. Create corresponding test file in `Tests/` folder.

## 🧪 Testing

Test cases are included in the `Tests/` folder. Each solution should have corresponding test cases to validate correctness.

## 📊 Solutions List

| Problem | Difficulty | Status |
|---------|------------|--------|
| 1. Two Sum | Easy | ✅ |

## 🔧 Development Tips

- Use meaningful variable names
- Add XML documentation comments
- Include time and space complexity analysis
- Write comprehensive test cases
- Follow C# naming conventions (PascalCase for public members)

## 📚 Resources

- [LeetCode](https://leetcode.com/)
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
