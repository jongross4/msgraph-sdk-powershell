---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/update-mgofficeconfigurationclientconfigurationpriority
schema: 2.0.0
---

# Update-MgOfficeConfigurationClientConfigurationPriority

## SYNOPSIS
Invoke action updatePriorities

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeConfigurationClientConfigurationPriority [-OfficeConfigurationPolicyIds <String[]>]
 [-OfficeConfigurationPriorities <Int32[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOfficeConfigurationClientConfigurationPriority
 -BodyParameter <IPaths9D5V4YOfficeconfigurationClientconfigurationsMicrosoftGraphUpdateprioritiesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action updatePriorities

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths9D5V4YOfficeconfigurationClientconfigurationsMicrosoftGraphUpdateprioritiesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OfficeConfigurationPolicyIds
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OfficeConfigurationPriorities
.

```yaml
Type: System.Int32[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IPaths9D5V4YOfficeconfigurationClientconfigurationsMicrosoftGraphUpdateprioritiesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths9D5V4YOfficeconfigurationClientconfigurationsMicrosoftGraphUpdateprioritiesPostRequestbodyContentApplicationJsonSchema>: .
  - `[OfficeConfigurationPolicyIds <String[]>]`: 
  - `[OfficeConfigurationPriorities <Int32[]>]`: 

## RELATED LINKS

