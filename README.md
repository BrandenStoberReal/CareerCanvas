<h1 align="center">Career Canvas</h1>

<div align="center">

[![GitHub Stars](https://img.shields.io/github/stars/brandenstoberreal/careercanvas)](#)
[![GitHub Forks](https://img.shields.io/github/forks/brandenstoberreal/careercanvas)](#)

</div>

<div align="center">

[![GitHub last commit](https://img.shields.io/github/last-commit/brandenstoberreal/careercanvas)](#)
[![GitHub commit activity](https://img.shields.io/github/commit-activity/m/brandenstoberreal/careercanvas)](#)
[![GitHub commits since latest release](https://img.shields.io/github/commits-since/brandenstoberreal/careercanvas/latest)](#)
[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/brandenstoberreal/careercanvas/dotnet.yml)](#)
[![GitHub Issues](https://img.shields.io/github/issues-raw/brandenstoberreal/careercanvas)](#)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr/brandenstoberreal/careercanvas)](#)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr-closed/brandenstoberreal/careercanvas)](#)
[![GitHub Repo Size](https://img.shields.io/github/languages/top/brandenstoberreal/careercanvas)](#)

</div>

 A robust and extensible C# job-hunting utility designed to provide free access to basic job application QoL tools.

 This project started due to my own personal frustrations with the job application process. I wanted to create a tool that would help me and others streamline the process of applying for jobs, and make it easier to keep track of resumes and cover letters.

 [![Pre-Alpha Screenshot](https://files.catbox.moe/j8bdge.png)](#)
 <p align="center">
  <i>Screenshot of a pre-alpha build. Many features are missing and subject to change.</i>
 </p>

 # Roadmap
 - [x] Material UI
 - [ ] Material UI - Application Themes
 - [ ] Material UI - Not Terrible UI
 - [x] Cover Letter Builder
 - [x] Cover Letter Builder - Export cover letter to PDF
 - [x] Cover Letter Builder - Export cover letter to HTML
 - [ ] Cover Letter Builder - Google Gemini Integration
 - [ ] Cover Letter Builder - OpenAI Integration
 - [x] Identity Builder
 - [x] Identity Builder - Information Encryption (AES-256)
 - [x] Industry Builder
 - [x] Industry Builder - Employment history GUI
 - [x] Industry Builder - Education history GUI
 - [x] Industry Builder - Certificates GUI
 - [x] Industry Builder - Skills GUI
 - [x] Resume Builder
 - [x] Resume Builder - Custom template support
 - [x] Resume Builder - Template switcher
 - [x] Resume Builder - Export resume to PDF
 - [x] Resume Builder - Export resume to HTML
 - [x] Resume Builder - Misc Utilities
 - [x] Cross-builder Integration
 - [x] Persistent Storage
 - [x] Macro Parsing & Documentation
 - [ ] ~~Custom Macros & Softcoded Macros~~ **Too niche to justify effort**
 - [ ] Update Notification System
 - [ ] Application Installer (.msi)
 - [ ] Improve Application UX
 - [ ] Applicationwide Tooltips
 - [x] Robust & Organized Logging
 - [ ] Debug Mode
 - [ ] Application Refinement/Polishing


# Installation
Take a look at the [releases](https://github.com/BrandenStoberReal/CareerCanvas/releases) page for the latest version of the application. The application comes bundled with the .NET 9 runtime, so you do not need to install it separately. Simply download the latest release and extract the files to a folder of your choice. You can then run the application by double-clicking on the `CareerCanvas.exe` executable.

# Custom Templates
If you are savvy with HTML and CSS, please read [the documentation](TEMPLATES.md) for more information on how to create custom templates. A few templates come pre-loaded with the application and can be used as bases without issue.

# Building
You will need the `.NET 9` SDK installed to build the application. You can download it from the [.NET website](https://dotnet.microsoft.com/download/dotnet/9.0). Once you have the SDK installed, you can clone the repository and run the following commands in the root directory of the project:
```bash
dotnet restore
dotnet build
```
This will build the application and create an executable in the `bin/Debug/net9.0-windows` directory. You can then run the application by double-clicking on the `CareerCanvas.exe` executable.

Keep in mind that if you decide to make any changes to UI elements, sometimes the build process bugs and does not apply the changes. Simply rebuild the project to resolve this.

# Liability
The creator(s) of this software is/are not liable if the program provides faulty, missing, or impartial output. This software is not a replacement for professional job-hunting services, and should be used as a supplement to a job-hunting strategy.

# Credits
Please view the "credits" section of the application for a full list of contributors and resources.

This project contains mild use of AI:
- Partial use of Claude 3.7 for generating the README.md file.
- Partial use of Claude 3.7 for generation documentation files.
- Partial use of Claude 3.7 for generating code comments.
- Partial use of Claude 3.7 for formatting html-converted PDFs during export (JS, CSS, and HTML).
- Partial use of Claude 3.7 for generating commit messages.
- Use of Claude 3.7 for generating resume templates.
- Use of Claude 3.7 for generating cover letter templates.
