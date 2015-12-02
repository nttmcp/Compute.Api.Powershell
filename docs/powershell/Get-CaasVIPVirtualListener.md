﻿Get-CaasVIPVirtualListener
===================

## SYNOPSIS

Get-CaasVIPVirtualListener [-Name <string>] [-NetworkDomain <NetworkDomainType>] [-Id <guid>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                            

----------                                                                                                            

{@{name=Get-CaasVIPVirtualListener; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
```

## DESCRIPTION


## PARAMETERS
### -Connection &lt;ComputeServiceConnection&gt;
The CaaS Connection created by New-CaasConnection
```
Position?                    Named
Accept pipeline input?       true (ByPropertyName)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Id &lt;guid&gt;
The VIP virtual listener id
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false
```
 
### -Name &lt;string&gt;
The VIP virtual listener name
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false
```
 
### -NetworkDomain &lt;NetworkDomainType&gt;
The network domain
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false
```

## INPUTS
DD.CBU.Compute.Api.Contracts.Network20.NetworkDomainType
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.VirtualListenerType[]


## NOTES


## EXAMPLES