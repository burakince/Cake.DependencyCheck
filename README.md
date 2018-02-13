# Cake.DependencyCheck

OWASP DependencyCheck Cake Package. You need to use [DependencyCheck Runner Tool](https://github.com/burakince/DependencyCheck.Runner.Tool).

[![Build status](https://ci.appveyor.com/api/projects/status/w4p88lcixif2erl9?svg=true)](https://ci.appveyor.com/project/burakince/cake-dependencycheck) 
[![NuGet version](https://img.shields.io/nuget/v/Cake.DependencyCheck.svg)](https://www.nuget.org/packages/Cake.DependencyCheck/) 
[![NuGet downloads](https://img.shields.io/nuget/dt/Cake.DependencyCheck.svg)](https://www.nuget.org/stats/packages/Cake.DependencyCheck?groupby=Version)

Example usage;

```csharp

#tool "nuget:?package=DependencyCheck.Runner.Tool&include=./**/dependency-check.sh&include=./**/dependency-check.bat"
#addin "nuget:?package=Cake.DependencyCheck"

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
