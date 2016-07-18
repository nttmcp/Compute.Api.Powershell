﻿Get-CaasReserveIPv6Address
===================

Synopsis
--------


Get-CaasReserveIPv6Address [-VlanId <guid>] [-IpAddress <string>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


Syntax
------

.. code-block:: powershell

    syntaxItem                                                                                                            

----------                                                                                                            

{@{name=Get-CaasReserveIPv6Address; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}


Description
-----------



Parameters
----------

-Connection &lt;ComputeServiceConnection&gt;
~~~~~~~~~

The CaaS Connection created by New-CaasConnection

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       true (ByPropertyName)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false

 
-IpAddress &lt;string&gt;
~~~~~~~~~

The IPv6 address

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       false
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false

 
-OrderBy &lt;string&gt;
~~~~~~~~~

The Order By of the results, only supported for MCP2

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false

 
-PageNumber &lt;int&gt;
~~~~~~~~~

The Page Number of the result page, only supported for MCP2

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false

 
-PageSize &lt;int&gt;
~~~~~~~~~

The Page Size of the result page, only supported for MCP2

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false

 
-VlanId &lt;guid&gt;
~~~~~~~~~

The unique identifier of MCP 2.0 VLAN

.. code-block:: powershell

    Position?                    Named
Accept pipeline input?       true (ByValue, ByPropertyName)
Parameter set name           Filtered
Aliases                      Id
Dynamic?                     false


INPUTS
------

System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
DD.CBU.Compute.Powershell.ComputeServiceConnection


OUTPUTS
-------

DD.CBU.Compute.Api.Contracts.Network20.ReservedIpv6AddressType


NOTES
-----



EXAMPLES
---------
