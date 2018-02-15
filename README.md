# Cake.DependencyCheck

OWASP DependencyCheck Cake Package. You need to use [DependencyCheck Runner Tool](https://github.com/burakince/DependencyCheck.Runner.Tool).

[![Build status](https://ci.appveyor.com/api/projects/status/w4p88lcixif2erl9?svg=true)](https://ci.appveyor.com/project/burakince/cake-dependencycheck) 
[![NuGet version](https://img.shields.io/nuget/v/Cake.DependencyCheck.svg)](https://www.nuget.org/packages/Cake.DependencyCheck/) 
[![NuGet downloads](https://img.shields.io/nuget/dt/Cake.DependencyCheck.svg)](https://www.nuget.org/packages/Cake.DependencyCheck/) 
[![Join the chat at https://gitter.im/Cake-DependencyCheck/Lobby](https://badges.gitter.im/Cake-DependencyCheck/Lobby.svg)](https://gitter.im/Cake-DependencyCheck/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

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

## Contributing

We'd love to get contributions from you! If you would like to contribute code or help squash a bug or two, that's awesome. Please familiarize yourself with [Contribution Document](https://github.com/burakince/Cake.DependencyCheck/blob/master/CONTRIBUTING.md).

## License

See [LICENSE](https://github.com/burakince/Cake.DependencyCheck/blob/master/LICENSE) file.

## Code of Conduct

See [Code of Conduct](https://github.com/burakince/Cake.DependencyCheck/blob/master/CODE_OF_CONDUCT.md) file.
