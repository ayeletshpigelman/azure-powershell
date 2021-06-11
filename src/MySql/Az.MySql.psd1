#
# Module manifest for module 'Az.MySql'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2/26/2021
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './Az.MySql.psm1'

# Version number of this module.
ModuleVersion = '0.6.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '0b8ac9f4-b926-4ac8-b73f-937a0d218521'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell: MySql cmdlets'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.4.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = './bin/Az.MySql.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = './Az.MySql.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Get-AzMySqlConfiguration', 'Get-AzMySqlConnectionString', 
               'Get-AzMySqlFirewallRule', 'Get-AzMySqlFlexibleServer', 
               'Get-AzMySqlFlexibleServerConfiguration', 
               'Get-AzMySqlFlexibleServerConnectionString', 
               'Get-AzMySqlFlexibleServerDatabase', 
               'Get-AzMySqlFlexibleServerFirewallRule', 
               'Get-AzMySqlFlexibleServerLocationBasedCapability', 
               'Get-AzMySqlFlexibleServerReplica', 'Get-AzMySqlReplica', 
               'Get-AzMySqlServer', 'Get-AzMySqlVirtualNetworkRule', 
               'New-AzMySqlFirewallRule', 'New-AzMySqlFlexibleServer', 
               'New-AzMySqlFlexibleServerDatabase', 
               'New-AzMySqlFlexibleServerFirewallRule', 
               'New-AzMySqlFlexibleServerReplica', 'New-AzMySqlReplica', 
               'New-AzMySqlServer', 'New-AzMySqlVirtualNetworkRule', 
               'Remove-AzMySqlFirewallRule', 'Remove-AzMySqlFlexibleServer', 
               'Remove-AzMySqlFlexibleServerDatabase', 
               'Remove-AzMySqlFlexibleServerFirewallRule', 'Remove-AzMySqlServer', 
               'Remove-AzMySqlVirtualNetworkRule', 'Restart-AzMySqlFlexibleServer', 
               'Restart-AzMySqlServer', 'Restore-AzMySqlFlexibleServer', 
               'Restore-AzMySqlServer', 'Start-AzMySqlFlexibleServer', 
               'Stop-AzMySqlFlexibleServer', 'Test-AzMySqlFlexibleServerConnect', 
               'Update-AzMySqlConfiguration', 'Update-AzMySqlFirewallRule', 
               'Update-AzMySqlFlexibleServer', 
               'Update-AzMySqlFlexibleServerConfiguration', 
               'Update-AzMySqlFlexibleServerDatabase', 
               'Update-AzMySqlFlexibleServerFirewallRule', 'Update-AzMySqlServer', 
               'Update-AzMySqlVirtualNetworkRule'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','PSModule','MySql'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Added maintenance windows parameter to Update-AzMySqlFlexibleServer cmdlet
* Added zone parameter to server New-AzMySqlFlexibleServer cmdlet.'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

