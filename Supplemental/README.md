Supplemental Modules
=====================
The Supplemental folder contains scripts that provide extra functionality to the main package. These changes aren't
part of the main Nuget package.

#### ChangeDiskSpeedProvIops.psm1
This script will install the commandlet *Set-CaasChangeDiskSpeedProvIops*. 

The commandlet changes the speed of a disk to a *different* value. This includes the PROVISIONEDIOPS speed, something
 not supported by the current Set-CaaSServerDiskSpeed commandlet.

Please note, the commandlet requests that the disk speed is changed. This function is asynchronous, completion of the 
commandlet does not indicate the disk speed has changed, or will be successful.

The API used within the commandlet is *https://$ApiPath/caas/2.12/$orgId/server/changeDiskSpeed* and all the rules and
restrictions imposed by that API apply to this module.

##### Installing
To install from a Powershell command line:

`Import-Module .\ChangeDiskSpeedProvIops.psm1`

If the module is already installed use the -force flag to update it:

`Import-Module .\ChangeDiskSpeedProvIops.psm1 -force`

##### Running Commandlet
The commandlet can be run on the Powershell command line, and accepts the following parameters:

-apiUrl - Mandatory parameter stating path of the API to use

-orgId - Mandatory parameter providing the org Id

-cred - Mandatory parameter providing [credentials object](#passing-credentials)

-diskId - Mandatory parameter providing the ID of the disk to update

-speed - Mandatory parameter, must be set to a [valid disk speed](#valid-disk-speed-settings)

-iops - If the speed is set to PROVISIONEDIOPS this parameter must be specified to an integer for the number of iops


###### Valid Disk Speed Settings
Valid settings for the *speed* parameter are one of ECONOMY, STANDARD, HIGHPERFORMANCE, PROVISIONEDIOPS

If the speed is set to PROVISIONEDIOPS then the *-iops* parameter must be specified.

##### Passing Credentials
Credentials passed in the -cred parameter are obtained using the `Get-Credential` Powershell commandlet. 
The object returned by `Get-Credential` can be passed using the -cred parameter.