---
external help file:
Module Name: Microsoft.Graph.Teams.Chats
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.chats/new-mgchatmessagereply
schema: 2.0.0
---

# New-MgChatMessageReply

## SYNOPSIS
Create new navigation property to replies for chats

## SYNTAX

### CreateExpanded (Default)
```
New-MgChatMessageReply -ChatId <String> -ChatMessageId <String>
 [-Attachments <IMicrosoftGraphChatMessageAttachment[]>] [-BodyContent <String>] [-BodyContentType <String>]
 [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-Etag <String>]
 [-From <IMicrosoftGraphIdentitySet>] [-HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]
 [-Id <String>] [-Importance <String>] [-LastModifiedDateTime <DateTime>] [-Locale <String>]
 [-Mentions <IMicrosoftGraphChatMessageMention[]>] [-MessageType <String>] [-PolicyTipComplianceUrl <String>]
 [-PolicyTipGeneralText <String>] [-PolicyTipMatchedConditionDescriptions <String[]>]
 [-PolicyViolationDlpAction <String>] [-PolicyViolationJustificationText <String>]
 [-PolicyViolationUserAction <String>] [-PolicyViolationVerdictDetails <String>]
 [-Reactions <IMicrosoftGraphChatMessageReaction[]>] [-Replies <IMicrosoftGraphChatMessage[]>]
 [-ReplyToId <String>] [-Subject <String>] [-Summary <String>] [-WebUrl <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgChatMessageReply -ChatId <String> -ChatMessageId <String> -BodyParameter <IMicrosoftGraphChatMessage>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgChatMessageReply -InputObject <ITeamsChatsIdentity> -BodyParameter <IMicrosoftGraphChatMessage>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgChatMessageReply -InputObject <ITeamsChatsIdentity>
 [-Attachments <IMicrosoftGraphChatMessageAttachment[]>] [-BodyContent <String>] [-BodyContentType <String>]
 [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-Etag <String>]
 [-From <IMicrosoftGraphIdentitySet>] [-HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]
 [-Id <String>] [-Importance <String>] [-LastModifiedDateTime <DateTime>] [-Locale <String>]
 [-Mentions <IMicrosoftGraphChatMessageMention[]>] [-MessageType <String>] [-PolicyTipComplianceUrl <String>]
 [-PolicyTipGeneralText <String>] [-PolicyTipMatchedConditionDescriptions <String[]>]
 [-PolicyViolationDlpAction <String>] [-PolicyViolationJustificationText <String>]
 [-PolicyViolationUserAction <String>] [-PolicyViolationVerdictDetails <String>]
 [-Reactions <IMicrosoftGraphChatMessageReaction[]>] [-Replies <IMicrosoftGraphChatMessage[]>]
 [-ReplyToId <String>] [-Subject <String>] [-Summary <String>] [-WebUrl <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to replies for chats

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

### -Attachments
.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageAttachment[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyContent
The content of the item.

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

### -BodyContentType
bodyType

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

### -BodyParameter
chatMessage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ChatId
key: chat-id of chat

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

### -ChatMessageId
key: chatMessage-id of chatMessage

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

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Etag
.

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

### -From
identitySet
To construct, see NOTES section for FROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -HostedContents
.
To construct, see NOTES section for HOSTEDCONTENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageHostedContent[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
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

### -Importance
chatMessageImportance

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
Type: Microsoft.Graph.PowerShell.Models.ITeamsChatsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Locale
.

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

### -Mentions
.
To construct, see NOTES section for MENTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageMention[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MessageType
chatMessageType

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

### -PolicyTipComplianceUrl
.

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

### -PolicyTipGeneralText
.

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

### -PolicyTipMatchedConditionDescriptions
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PolicyViolationDlpAction
chatMessagePolicyViolationDlpActionTypes

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

### -PolicyViolationJustificationText
.

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

### -PolicyViolationUserAction
chatMessagePolicyViolationUserActionTypes

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

### -PolicyViolationVerdictDetails
chatMessagePolicyViolationVerdictDetailsTypes

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

### -Reactions
.
To construct, see NOTES section for REACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageReaction[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Replies
.
To construct, see NOTES section for REPLIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ReplyToId
.

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

### -Subject
.

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

### -Summary
.

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

### -WebUrl
.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage

### Microsoft.Graph.PowerShell.Models.ITeamsChatsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ATTACHMENTS <IMicrosoftGraphChatMessageAttachment[]>: .
  - `[Content <String>]`: 
  - `[ContentType <String>]`: 
  - `[ContentUrl <String>]`: 
  - `[Id <String>]`: 
  - `[Name <String>]`: 
  - `[ThumbnailUrl <String>]`: 

#### BODYPARAMETER <IMicrosoftGraphChatMessage>: chatMessage
  - `[Id <String>]`: Read-only.
  - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: 
    - `[Content <String>]`: 
    - `[ContentType <String>]`: 
    - `[ContentUrl <String>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
    - `[ThumbnailUrl <String>]`: 
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Etag <String>]`: 
  - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Importance <String>]`: chatMessageImportance
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Locale <String>]`: 
  - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: 
    - `[Id <Int32?>]`: 
    - `[MentionText <String>]`: 
    - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MessageType <String>]`: chatMessageType
  - `[PolicyTipComplianceUrl <String>]`: 
  - `[PolicyTipGeneralText <String>]`: 
  - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
  - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
  - `[PolicyViolationJustificationText <String>]`: 
  - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
  - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
  - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ReactionType <String>]`: 
    - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Replies <IMicrosoftGraphChatMessage[]>]`: 
  - `[ReplyToId <String>]`: 
  - `[Subject <String>]`: 
  - `[Summary <String>]`: 
  - `[WebUrl <String>]`: 

#### FROM <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### HOSTEDCONTENTS <IMicrosoftGraphChatMessageHostedContent[]>: .
  - `[Id <String>]`: Read-only.

#### INPUTOBJECT <ITeamsChatsIdentity>: Identity Parameter
  - `[ChatId <String>]`: key: chat-id of chat
  - `[ChatMessageHostedContentId <String>]`: key: chatMessageHostedContent-id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: chatMessage-id of chatMessage
  - `[ChatMessageId1 <String>]`: key: chatMessage-id of chatMessage
  - `[ConversationMemberId <String>]`: key: conversationMember-id of conversationMember
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[UserId <String>]`: key: user-id of user

#### MENTIONS <IMicrosoftGraphChatMessageMention[]>: .
  - `[Id <Int32?>]`: 
  - `[MentionText <String>]`: 
  - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity

#### REACTIONS <IMicrosoftGraphChatMessageReaction[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[ReactionType <String>]`: 
  - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity

#### REPLIES <IMicrosoftGraphChatMessage[]>: .
  - `[Id <String>]`: Read-only.
  - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: 
    - `[Content <String>]`: 
    - `[ContentType <String>]`: 
    - `[ContentUrl <String>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
    - `[ThumbnailUrl <String>]`: 
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Etag <String>]`: 
  - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Importance <String>]`: chatMessageImportance
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Locale <String>]`: 
  - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: 
    - `[Id <Int32?>]`: 
    - `[MentionText <String>]`: 
    - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MessageType <String>]`: chatMessageType
  - `[PolicyTipComplianceUrl <String>]`: 
  - `[PolicyTipGeneralText <String>]`: 
  - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
  - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
  - `[PolicyViolationJustificationText <String>]`: 
  - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
  - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
  - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ReactionType <String>]`: 
    - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Replies <IMicrosoftGraphChatMessage[]>]`: 
  - `[ReplyToId <String>]`: 
  - `[Subject <String>]`: 
  - `[Summary <String>]`: 
  - `[WebUrl <String>]`: 

## RELATED LINKS

