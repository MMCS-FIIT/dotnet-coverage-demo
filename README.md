# C# Coverage Demo Project

## Visual Studio Code
- **Установите** [.NET report generator](https://github.com/danielpalme/ReportGenerator) с помощью команды в терминале:

  ``` powershell
  dotnet tool install -g dotnet-reportgenerator-globaltool
  ```
- **Добавьте** пакет [Coverlet MSBuild](https://www.nuget.org/packages/coverlet.msbuild) к проекту с тестами:
  ``` powershell
  dotnet add Tests/Tests.csproj package coverlet.msbuild
  ```
- **Запустите** тесты и создайте [html-отчет о покрытии](coverage/index.html) нажатием `Ctrl-Shift-B`.

> [!NOTE]  
> Задача сборки `coverage` предоставляется файлом [tasks.json](vscode/tasks.json) из этого репозитория.
> Вы можете скопировать его содержимое в ваш собственный файл `vscode/tasks.json`.

> [!IMPORTANT]  
> В строке 
> ``` json
> "-reports:${workspaceFolder}/Tests/coverage.info"
> ```
> скопированной вами конфигурации **необходимо** заменить путь к проекту `Tests` на путь к **вашему** проекту с тестами.
