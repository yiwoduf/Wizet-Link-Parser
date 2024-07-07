# Wizet Link Parser

### ACTIVE PROJECT: WORKING ON UPDATES

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

This project is a C# application built with .NET Framework 4.7.2 for parsing and modifying WIZET img/xml files. It's specifically designed for MapleStory (MS) Wizet server files and outdated client versions that do not support the `_source` node of the XML.

## 🛠️ Built with

[![C#][C#]][C#-url]
[![.NET Framework][.NET Framework]][.NET-url]
[![Windows Forms][Windows Forms]][Windows-Forms-url]
[![XML][XML]][XML-url]
[![WIZET][wizet-shield]][wizet-url]

## Features

- Parse and modify WIZET img/xml files
- Convert `_inlink` and `_outlink` properties to `source`
- Update file paths for `_inlink` properties
- Remove `_hash` nodes from XML files
- Create backups of original files before modification
- User-friendly GUI for selecting directories and options

## Prerequisites

- Windows operating system
- .NET Framework 4.7.2
- Visual Studio (for development)

## Getting Started

1. Clone the repository:

```bash
   git clone https://github.com/yiwoduf/Wizet-Link-Parser.git
```

2. Open the solution file in Visual Studio.

3. Build the project.

4. Run the application.

5. Select WZ File directory.

6. Run Parser.

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

## Project Structure

The main functionality is implemented in `Form1.cs`, which includes:

- Directory copying for backups
- XML parsing and modification
- Conversion of `_inlink` and `_outlink` properties
- Removal of `_hash` nodes
- Progress tracking for operations

## Contributing

Contributions to improve the tool or add new features are welcome. Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

**\*Please note that all rights related to the original game Maplestory belong to Nexon. This project is for personal study and is not affiliated with Nexon.**

## Disclaimer

This tool is not officially affiliated with or endorsed by NEXON or the MapleStory team. Use at your own risk.

<!-- MARKDOWN LINKS & IMAGES -->

[contributors-shield]: https://img.shields.io/github/contributors/yiwoduf/Wizet-Link-Parser.svg?style=for-the-badge
[contributors-url]: https://github.com/yiwoduf/Wizet-Link-Parser/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/yiwoduf/Wizet-Link-Parser.svg?style=for-the-badge
[forks-url]: https://github.com/yiwoduf/Wizet-Link-Parser/network/members
[stars-shield]: https://img.shields.io/github/stars/yiwoduf/Wizet-Link-Parser.svg?style=for-the-badge
[stars-url]: https://github.com/yiwoduf/Wizet-Link-Parser/stargazers
[issues-shield]: https://img.shields.io/github/issues/yiwoduf/Wizet-Link-Parser.svg?style=for-the-badge
[issues-url]: https://github.com/yiwoduf/Wizet-Link-Parser/issues
[license-shield]: https://img.shields.io/github/license/yiwoduf/Wizet-Link-Parser.svg?style=for-the-badge
[license-url]: https://github.com/yiwoduf/Wizet-Link-Parser/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/yiwoduf/
[C#]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[C#-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[.NET Framework]: https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white
[.NET-url]: https://dotnet.microsoft.com/
[Windows Forms]: https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white
[Windows-Forms-url]: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8
[XML]: https://img.shields.io/badge/XML-0C54C2?style=for-the-badge&logo=xml&logoColor=white
[XML-url]: https://www.w3.org/XML/
[wizet-shield]: https://img.shields.io/badge/WIZET-FF6600?style=for-the-badge
[wizet-url]: https://github.com/yiwoduf/Wizet-Link-Parser
