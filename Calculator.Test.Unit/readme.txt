1. Create an MSTest project
dotnet new mstest -o Calculator.Test.Unit

2. Add reference of the project to be tested
dotnet add Calculator.Test.Unit/Calculator.Test.Unit.csproj reference Calculator/Calculator.csprojun 

3. Run unit tests
dotnet test Calculator.Test.Unit.csproj