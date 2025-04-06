# Revit MCP 命令开发模板

[English](README.md) | 简体中文

这个项目是一个标准模板，用于开发基于revit-mcp协议的Revit命令。通过使用这个模板，您可以快速搭建命令开发环境，而无需从头设置项目结构和配置。

## 项目概述

此模板提供了开发Revit命令所需的基本结构和配置，包括：

- revit-mcp-sdk的引用（版本1.0.0-beta.1）
- 示例命令"say_hello"，展示了如何创建基本的Revit命令

这个模板主要用于开发符合[revit-mcp](https://github.com/revit-mcp)项目的命令。revit-mcp是一个基于Autodesk Revit软件实现mcp协议的框架，它允许兼容mcp协议的AI对话客户端驱动Revit。

## 环境要求

- .NET Framework 4.8
- Visual Studio 2019或更新版本

## 依赖项

- Revit_API_x64 (2024.0.2)
- revit-mcp-sdk (1.0.0-beta.1)
- Newtonsoft.Json (13.0.3)

## 项目结构

```
Standard/
├── Commands/             # 存放命令类的文件夹
│   ├── SayHelloCommand.cs      # 示例命令类
│   └── SayHelloEventHandler.cs # 命令的事件处理器
├── Models/               # 存放数据模型的文件夹
├── Utils/                # 存放工具类的文件夹
├── Properties/           # 程序集属性
├── Standard.csproj       # 项目文件
└── packages.config       # NuGet包配置
```

## 如何使用

### 安装模板

```
dotnet new --install revit-mcp-templates
```

### 创建新项目

#### 使用命令行

```
dotnet new revitmcp -n YourProjectName
```

#### 使用Visual Studio

1. 打开Visual Studio
2. 选择"创建新项目"
3. 在模板列表中搜索"Revit MCP"
4. 选择"Revit MCP Development Template"
5. 为项目指定名称和位置，然后点击"创建"

### 添加新命令

1. 在`Commands`文件夹中创建新的命令类和对应的事件处理器
2. 命令类应继承自`ExternalEventCommandBase`
3. 事件处理器应实现`IExternalEventHandler`和`IWaitableExternalEventHandler`接口

### 示例命令与清理

项目包含一个名为"say_hello"的示例命令，当执行时会显示一个简单的对话框。这是一个基本示例，展示了如何创建和使用基于MCP的Revit命令。

在实际开发中，您可以删除示例命令文件（`SayHelloCommand.cs`和`SayHelloEventHandler.cs`），然后添加您自己的命令实现。
