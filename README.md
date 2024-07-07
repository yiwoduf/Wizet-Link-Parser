# WIZET File Parser and Modifier

### ACTIVE PROJECT: WORKING ON UPDATES

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

This project is a C# application built with .NET Framework 4.7.2 for parsing and modifying WIZET img/xml files. It's designed to support outdated client versions of MapleStory by manipulating the game's resource files.

## 🛠️ Built with

[![C#][C#]][C#-url]
[![.NET Framework][.NET Framework]][.NET-url]
[![Windows Forms][Windows Forms]][Windows-Forms-url]
[![XML][XML]][XML-url]

## Features

- Parse and modify WIZET img/xml files
- Convert `_inlink` and `_outlink` properties to `source`
- Remove `_hash` nodes from XML files
- Create backups of original files before modification
- User-friendly GUI for selecting directories and options

## Prerequisites

- Windows operating system
- .NET Framework 4.7.2
- Visual Studio (for development)

## Getting Started

1. Clone the repository:
   git clone https://github.com/yourusername/wizet-file-parser.git
   javascript

2. Open the solution file in Visual Studio.

3. Build the project.

4. Run the application.

## Usage

1. Click "Get Directory" to select the folder containing WIZET files.
2. Check the options you want to apply:

- "Convert \_in/\_outlinks" to change `_inlink` and `_outlink` properties to `source`
- "Remove \_hash" to remove `_hash` nodes from XML files

3. Click "START" to begin the parsing and modification process.

## Important Notes

- Always create a backup of your original files before using this tool.
- This tool is designed for specific versions of MapleStory client files. Make sure it's compatible with your version.
- Place all your Wizet Folders (.wz) inside the workdirectory folder.

## Contributing

Contributions to improve the tool or add new features are welcome. Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

[Specify your license here, e.g., MIT, GPL, etc.]

## Disclaimer

This tool is not officially affiliated with or endorsed by NEXON or the MapleStory team. Use at your own risk.

<!-- MARKDOWN LINKS & IMAGES -->

[contributors-shield]: https://img.shields.io/github/contributors/yourusername/wizet-file-parser.svg?style=for-the-badge
[contributors-url]: https://github.com/yourusername/wizet-file-parser/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/yourusername/wizet-file-parser.svg?style=for-the-badge
[forks-url]: https://github.com/yourusername/wizet-file-parser/network/members
[stars-shield]: https://img.shields.io/github/stars/yourusername/wizet-file-parser.svg?style=for-the-badge
[stars-url]: https://github.com/yourusername/wizet-file-parser/stargazers
[issues-shield]: https://img.shields.io/github/issues/yourusername/wizet-file-parser.svg?style=for-the-badge
[issues-url]: https://github.com/yourusername/wizet-file-parser/issues
[license-shield]: https://img.shields.io/github/license/yourusername/wizet-file-parser.svg?style=for-the-badge
[license-url]: https://github.com/yourusername/wizet-file-parser/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/yourusername/
[C#]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[C#-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[.NET Framework]: https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white
[.NET-url]: https://dotnet.microsoft.com/
[Windows Forms]: https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white
[Windows-Forms-url]: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8
[XML]: https://img.shields.io/badge/XML-0C54C2?style=for-the-badge&logo=xml&logoColor=white
[XML-url]: https://www.w3.org/XML/

This README now includes:
The .NET Framework version (4.7.2)
Badges for the technologies used (C#, .NET Framework, Windows Forms, XML)
A note about placing Wizet Folders (.wz) inside the workdirectory folder
Shields and badges similar to the example you provided
