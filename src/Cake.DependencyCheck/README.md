# Command Line Arguments

| Argument Name        | Parameter | Requirement | Description                            |
| -------------------- | --------- | ----------- | -------------------------------------- |
| --project            | `<name`>    | Required    | The name of the project being scanned. |
| --scan               | `<path`>    | Required    | The path to scan - this option can be specified multiple times. It is also possible to specify Ant style paths (e.g. directory/*/.jar). |
| --exclude            | `<pattern`> | Optional    | The path patterns to exclude from the scan - this option can be specified multiple times. This accepts Ant style path patterns (e.g. /exclude/). |
| --symLink            | `<depth`>   | Optional    | The depth that symbolic links will be followed; the default is 0 meaning symbolic links will not be followed. |
| --out                | `<path`>    | Optional    | The folder to write reports to. This defaults to the current directory. If the format is not set to ALL one could specify a specific file name. |
| --format             | `<format`>  | Required    | The output format to write to (XML, HTML, CSV, JSON, VULN, ALL). The default is HTML. |
| --failOnCVSS         | `<score`>   | Optional    | If the score set between 0 and 10 the exit code from dependency-check will indicate if a vulnerability with a CVSS score equal to or higher was identified. |
| --log                | `<file`>    | Optional    | The file path to write verbose logging information. |
| --noupdate           |           | Optional    | Disables the automatic updating of the CPE data. |
| --suppression        | `<files`>   | Optional    | The file paths to the suppression XML files; used to suppress false positives. This can be specified more than once to utilize multiple suppression files. |
| --help               |           | Optional    | Print the help message. |
| --advancedHelp       |           | Optional    | Print the advanced help message. |
| --version            |           | Optional    | Print the version information. |
| --cveValidForHours   | `<hours`>   | Optional    | The number of hours to wait before checking for new updates from the NVD. The default is 4 hours. |
| --enableExperimental |           | Optional    | Enable the experimental analyzers. If not set the analyzers marked as experimental below will not be loaded or used. |
| --enableRetired      |           | Optional    | Enable the retired analyzers. If not set the analyzers marked as retired below will not be loaded or used. |
