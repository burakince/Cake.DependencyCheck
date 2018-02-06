# Cake.DependencyCheck

OWASP DependencyCheck Cake Package

[![Build status](https://ci.appveyor.com/api/projects/status/vs3rphe2768u1pwa?svg=true)](https://ci.appveyor.com/project/burakince/cake-dependencycheck) 


Example usage;

```csharp

#tool "nuget:https://www.nuget.org/api/v2?package=DependencyCheck.Runner.Tool&include=./**/dependency-check.sh&include=./**/dependency-check.bat"
#addin "nuget:https://www.nuget.org/api/v2?package=Cake.DependencyCheck"

Task("Dependency-Check")
    .Does(() =>
    {
        DependencyCheck(new DependencyCheckSettings
        {
            Project = "CustomerService",
            Scan = "source/directory/*",
            Format = "HTML"
        });
    });

```
