---
external help file:
Module Name: Microsoft.Graph.Identity.Domains
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.domains/new-mgdomainserviceconfigurationrecord
schema: 2.0.0
---

# New-MgDomainServiceConfigurationRecord

## SYNOPSIS
Create new navigation property to serviceConfigurationRecords for domains

## SYNTAX

### CreateExpanded (Default)
```
New-MgDomainServiceConfigurationRecord -DomainId <String> [-Id <String>] [-IsOptional] [-Label <String>]
 [-RecordType <String>] [-SupportedService <String>] [-Ttl <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDomainServiceConfigurationRecord -DomainId <String> -BodyParameter <IMicrosoftGraphDomainDnsRecord>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDomainServiceConfigurationRecord -InputObject <IIdentityDomainsIdentity>
 -BodyParameter <IMicrosoftGraphDomainDnsRecord> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDomainServiceConfigurationRecord -InputObject <IIdentityDomainsIdentity> [-Id <String>] [-IsOptional]
 [-Label <String>] [-RecordType <String>] [-SupportedService <String>] [-Ttl <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to serviceConfigurationRecords for domains

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
domainDnsRecord
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainDnsRecord
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DomainId
key: domain-id of domain

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDomainsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IsOptional
If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Label
Value used when configuring the name of the DNS record at the DNS host.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RecordType
Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SupportedService
Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Ttl
Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host.
Not nullable

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityDomainsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainDnsRecord

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainDnsRecord

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphDomainDnsRecord>: domainDnsRecord
  - `[Id <String>]`: Read-only.
  - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
  - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
  - `[RecordType <String>]`: Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey
  - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune
  - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable

#### INPUTOBJECT <IIdentityDomainsIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[DomainDnsRecordId <String>]`: key: domainDnsRecord-id of domainDnsRecord
  - `[DomainId <String>]`: key: domain-id of domain

## RELATED LINKS

