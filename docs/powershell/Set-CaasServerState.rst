﻿
Set-CaasServerState
===================

Synopsis
--------

.. code-block:: powershell
    
    
Set-CaasServerState -Action <SetCaasServerActionCmdlet+ServerAction> -Server <ServerType> [-PassThru] [-Connection <ComputeServiceConnection>] [<CommonParameters>]





Description
-----------



Parameters
----------




-Action <SetCaasServerActionCmdlet+ServerAction>
~~~~~~~~~

The server action to take

* Position?                    Named
* Accept pipeline input?       false
* Parameter set name           (All)
* Aliases                      None
* Dynamic?                     false





-Connection <ComputeServiceConnection>
~~~~~~~~~

The CaaS Connection created by New-CaasConnection

* Position?                    Named
* Accept pipeline input?       true (ByPropertyName)
* Parameter set name           (All)
* Aliases                      None
* Dynamic?                     false





-PassThru <switch>
~~~~~~~~~

Return the Server object after execution

* Position?                    Named
* Accept pipeline input?       false
* Parameter set name           (All)
* Aliases                      None
* Dynamic?                     false





-Server <ServerType>
~~~~~~~~~

The server to action on

* Position?                    Named
* Accept pipeline input?       true (ByValue)
* Parameter set name           (All)
* Aliases                      None
* Dynamic?                     false





Inputs
------

DD.CBU.Compute.Api.Contracts.Network20.ServerType
DD.CBU.Compute.Powershell.ComputeServiceConnection


Outputs
-------

System.Object

Notes
-----



Examples
---------


