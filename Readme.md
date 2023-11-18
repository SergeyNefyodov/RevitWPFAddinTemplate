## How to use this template

- Firstly, you need to install <a href="https://dotnet.microsoft.com/en-us/download">.NET SDK<a>

- Then clone this repo on your local computer and open it in Visual Studio
- Then use Project — Export template in Visual Studio
- Create a new project using this template

## After building

- You need manually change guids in Application in command classes, as well as guid in addin-file.

- You need to manually move addin-file to C:\ProgramData\Autodesk\Revit\Addins\2023
- Then create folder and move all the files from bin/Debug to this folder.
- Change path in addin-file to your folder.
- For comfortable debugging use <a href="https://github.com/chuongmep/RevitAddInManager/releases">Addin-manager<a>.