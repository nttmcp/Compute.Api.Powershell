Supplemental Modules
=====================
The Supplemental folder contains scripts that provide extra functionality to the main package. These changes aren't
part of the main Nuget package.

#### ChangeDiskSpeedProvIops.psm1
This script will install the cmdlet *Set-CaasChangeDiskSpeedProvIops*. 

The cmdlet changes the speed of a disk to a __different__ value. This includes the PROVISIONEDIOPS speed, something
 not supported by the current Set-CaaSServerDiskSpeed Cmdlet.

Please note, the cmdlet requests that the disk speed is changed. This function is asynchronous, completion of the 
cmdlet does not indicate the disk speed has changed, or will be successful.

The API used within the cmdlet is *https://$ApiPath/caas/2.12/$orgId/server/changeDiskSpeed* and all the rules and
restrictions imposed by that API apply to this module.

##### Installing
To install from a Powershell command line:

`Import-Module .\ChangeDiskSpeedProvIops.psm1`

If the module is already installed use the -force flag to update it:

`Import-Module .\ChangeDiskSpeedProvIops.psm1 -force`

##### Running Cmdlet
The cmdlet can be run on the Powershell command line, and accepts the following parameters:

-apiUrl - Mandatory parameter stating path of the API to use

-orgId - Mandatory parameter providing the org Id

-cred - Mandatory parameter providing [credentials object](#passing-credentials)

-diskId - Mandatory parameter providing the ID of the disk to update

-speed - Mandatory parameter, must be set to a [valid disk speed](#valid-disk-speed-settings)

-iops - If the speed is set to PROVISIONEDIOPS this parameter must be specified to an integer for the number of iops


##### Example Run
In this example we're changing a disk to STANDARD speed. Credentials are first obtained and then passed into the script.
During the run the script outputs the payload sent to the API. Finally the $? command can be used to determine if the
script succeeded (which it did in this case).

`$cred = Get-Credential`

`PS C:\pscripts\release> Set-CaasChangeDiskSpeedProvIops -apiPath api-ash99-dev.mcp-services.net -orgId a32ef0e8-d9aa-4e86-b617-d03673a031a3 -diskId d526e557-5822-43b3-8a30-8339629bc1c8 -speed STANDARD -cred $cred`

Changing Disk speed: Payload:
{
        "id" : "d526e557-5822-43b3-8a30-8339629bc1c8",
        "speed": "STANDARD"
        }

`PS C:\pscripts\release> $?`
True


###### Valid Disk Speed Settings
Valid settings for the *speed* parameter are one of ECONOMY, STANDARD, HIGHPERFORMANCE, PROVISIONEDIOPS

If the speed is set to PROVISIONEDIOPS then the *-iops* parameter must be specified.

##### Passing Credentials
Credentials passed in the -cred parameter are obtained using the `Get-Credential` Powershell cmdlet. 
The object returned by `Get-Credential` can be passed using the -cred parameter.

*Please note this cmdlet and related script are valid as of API v2.12.*