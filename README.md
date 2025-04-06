# Revit MCP Command Development Template

English | [简体中文](README_zh.md) 

This is a standard template for developing Revit commands based on the revit-mcp protocol. By using this template, you can quickly set up a command development environment without configuring the project structure from scratch.

## Project Overview

This template provides the basic structure and configuration needed for developing Revit commands, including:

- References to revit-mcp-sdk (version 1.0.0-beta.1)
- A sample command "say_hello" demonstrating how to create a basic Revit command

This template is mainly used for developing commands that conform to the [revit-mcp](https://github.com/revit-mcp) project. revit-mcp is a framework that implements the mcp protocol based on Autodesk Revit software, allowing AI conversation clients compatible with the mcp protocol to drive Revit.

## Requirements

- .NET Framework 4.8
- Visual Studio 2019 or newer

## Dependencies

- Revit_API_x64 (2024.0.2) - Revit API NuGet package
- revit-mcp-sdk (1.0.0-beta.1)
- Newtonsoft.Json (13.0.3)

## Project Structure

```
Standard/
├── Commands/             # Folder for command classes
│   ├── SayHelloCommand.cs      # Sample command class
│   └── SayHelloEventHandler.cs # Command event handler
├── Models/               # Folder for data models
├── Utils/                # Folder for utility classes
├── Properties/           # Assembly properties
├── Standard.csproj       # Project file
└── packages.config       # NuGet package configuration
```

## How to Use

### Install Template

```
dotnet new --install revit-mcp-templates
```

### Create New Project

#### Using Command Line

```
dotnet new revitmcp -n YourProjectName
```

#### Using Visual Studio

1. Open Visual Studio
2. Select "Create a new project"
3. Search for "Revit MCP" in the templates list
4. Select "Revit MCP Development Template"
5. Specify a name and location for your project, then click "Create"

### Add New Commands

1. Create new command classes and corresponding event handlers in the `Commands` folder
2. Command classes should inherit from `ExternalEventCommandBase`
3. Event handlers should implement the `IExternalEventHandler` and `IWaitableExternalEventHandler` interfaces

### Sample Command and Cleanup

The project includes a sample command named "say_hello" that displays a simple dialog box when executed. This is a basic example showing how to create and use MCP-based Revit commands.

In actual development, you can delete the sample command files (`SayHelloCommand.cs` and `SayHelloEventHandler.cs`) and add your own command implementations.
