I'm trying to create simplified example of JSON serialization and deserialization

Process:
1. Add dlls:
System.Memory
System.Text.Json

2. Wrap serialization/deserialization into try..catch, so you can figure our errors

3. Errors during deserialization.
3.1 Coverstion string to int. To fix it, I have to use ParseInt into JavaScript to generate proper JSON object.
3.2 Dll was not loading and conflicting with each other. So I have to uninstall them and intall from NuGet
	System.Memory 
	System.Runtime.CompilerServices.Unsafe


Used:
1. How to write .NET objects as JSON (serialize)
https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to

2. How to read JSON as .NET objects (deserialize)
https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization