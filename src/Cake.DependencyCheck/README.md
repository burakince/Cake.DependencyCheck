# Command Line Arguments

| Argument Name        | Parameter | Requirement | Description                            |
| -------------------- | --------- | ----------- | -------------------------------------- |
| --project            | `<name>`  | Required    | The name of the project being scanned. |
| --scan               | `<path>`  | Required    | The path to scan - this option can be specified multiple times. It is also possible to specify Ant style paths (e.g. directory/*/.jar). |
| --exclude            |`<pattern>`| Optional    | The path patterns to exclude from the scan - this option can be specified multiple times. This accepts Ant style path patterns (e.g. /exclude/). |
| --symLink            | `<depth>` | Optional    | The depth that symbolic links will be followed; the default is 0 meaning symbolic links will not be followed. |
| --out                | `<path>`  | Optional    | The folder to write reports to. This defaults to the current directory. If the format is not set to ALL one could specify a specific file name. |
| --format             | `<format>`| Required    | The output format to write to (XML, HTML, CSV, JSON, VULN, ALL). The default is HTML. |
| --failOnCVSS         | `<score>` | Optional    | If the score set between 0 and 10 the exit code from dependency-check will indicate if a vulnerability with a CVSS score equal to or higher was identified. |
| --log                | `<file>`  | Optional    | The file path to write verbose logging information. |
| --noupdate           |           | Optional    | Disables the automatic updating of the CPE data. |
| --suppression        | `<files>` | Optional    | The file paths to the suppression XML files; used to suppress false positives. This can be specified more than once to utilize multiple suppression files. |
| --help               |           | Optional    | Print the help message. |
| --advancedHelp       |           | Optional    | Print the advanced help message. |
| --version            |           | Optional    | Print the version information. |
| --cveValidForHours   | `<hours>` | Optional    | The number of hours to wait before checking for new updates from the NVD. The default is 4 hours. |
| --enableExperimental |           | Optional    | Enable the experimental analyzers. If not set the analyzers marked as experimental below will not be loaded or used. |
| --enableRetired      |           | Optional    | Enable the retired analyzers. If not set the analyzers marked as retired below will not be loaded or used. |

# Advanced Options

| Argument Name        | Parameter | Description                            | Default Value |
| -------------------- | --------- | -------------------------------------- | ------------- |
| --cveUrl12Modified   | `<url>`   | URL for the modified CVE 1.2           | https://nvd.nist.gov/download/nvdcve-Modified.xml.gz |
| --cveUrl20Modified   | `<url>`   | URL for the modified CVE 2.0           | https://nvd.nist.gov/feeds/xml/cve/nvdcve-2.0-Modified.xml.gz |
| --cveUrl12Base       | `<url>`   | Base URL for each year’s CVE 1.2, the %d will be replaced with the year | https://nvd.nist.gov/download/nvdcve-%d.xml.gz |
| --cveUrl20Base       | `<url>`   | Base URL for each year’s CVE 2.0, the %d will be replaced with the year | https://nvd.nist.gov/feeds/xml/cve/nvdcve-2.0-%d.xml.gz |
| --propertyfile       | `<file>`  | Specifies a file that contains properties to use instead of applicaion defaults. |               |
| --updateonly         |           | If set only the update phase of dependency-check will be executed; no scan will be executed and no report will be generated. |               |
| --disablePyDist      |           | Sets whether the experimental Python Distribution Analyzer will be used. | false         |
| --disablePyPkg       |           | Sets whether the experimental Python Package Analyzer will be used. | false         |
| --disableNodeJS      |           | Sets whether the retired Node.js Package Analyzer will be used. | false         |
| --disableNSP         |           | Sets whether the NSP Analyzer will be used. | false         |
| --disableRubygems    |           | Sets whether the experimental Ruby Gemspec Analyzer will be used. | false         |
| --disableBundleAudit |           | Sets whether the experimental Ruby Bundler Audit Analyzer will be used. | false         |
| --disableCocoapodsAnalyzer |           | Sets whether the experimental Cocoapods Analyzer will be used. | false         |
| --disableSwiftPackageManagerAnalyzer |           | Sets whether the experimental Swift Package Manager Analyzer will be used. | false         |
| --disableAutoconf    |           | Sets whether the experimental Autoconf Analyzer will be used. | false         |
| --disableOpenSSL     |           | Sets whether the OpenSSL Analyzer will be used. | false         |
| --disableCmake       |           | Sets whether the experimental Cmake Analyzer will be disabled. | false         |
| --disableArchive     |           | Sets whether the Archive Analyzer will be disabled. | false         |
| --zipExtensions      | `<strings>` | A comma-separated list of additional file extensions to be treated like a ZIP file, the contents will be extracted and analyzed. | false         |
| --disableJar         |           | Sets whether the Jar Analyzer will be disabled. | false         |
| --disableComposer    |           | Sets whether the experimental PHP Composer Lock File Analyzer will be disabled. | false         |
| --disableCentral     |           | Sets whether the Central Analyzer will be used. Disabling this analyzer is not recommended as it could lead to false negatives (e.g. libraries that have vulnerabilities may not be reported correctly). If this analyzer is being disabled there is a good chance you also want to disable the Nexus Analyzer. | false         |
| --disableNexus       |           | Sets whether the Nexus Analyzer will be used (requires Nexus Pro). Note, this has been superceded by the Central Analyzer. However, you can configure the Nexus URL to utilize an internally hosted Nexus Pro server. | false         |
| --nexus              | `<url>`   | The url to the Nexus Server’s web service end point (example: http://domain.enterprise/nexus/service/local/). If not set the Nexus Analyzer will be disabled. |               |
| --nexusUsesProxy     | `<true|false>` | Whether or not the defined proxy should be used when connecting to Nexus. | true          |
| --disableNuspec      |           | Sets whether or not the .NET Nuget Nuspec Analyzer will be used. | false         |
| --disableAssembly    |           | Sets whether or not the .NET Assembly Analyzer should be used. | false         |
| --mono               | `<path>`  | The path to Mono for .NET Assembly analysis on non-windows systems. |               |
| --bundleAudit        | `<path>`  | The path to the bundle-audit executable. |               |
| --proxyserver        | `<server>` | The proxy server to use when downloading resources; see the proxy configuration page for more information. |               |
| --proxyport          | `<port>`  | The proxy port to use when downloading resources. |               |
| --connectiontimeout  | `<timeout>` | The connection timeout (in milliseconds) to use when downloading resources. |               |
| --proxypass          | `<pass>`  | The proxy password to use when downloading resources. |               |
| --proxyuser          | `<user>`  | The proxy username to use when downloading resources. |               |
| --connectionString   | `<connStr>` | The connection string to the database. |               |
| --dbDriverName       | `<driver>` | The database driver name.             |               |
| --dbDriverPath       | `<path>`  | The path to the database driver; note, this does not need to be set unless the JAR is outside of the class path. |               |
| --dbPassword         | `<password>` | The password for connecting to the database. |               |
| --dbUser             | `<user>`  | The username used to connect to the database. |               |
| --data               | `<path>`  | The location of the data directory used to store persistent data. This option should generally not be set. |               |
| --purge              |           | Delete the local copy of the NVD. This is used to force a refresh of the data. |               |
