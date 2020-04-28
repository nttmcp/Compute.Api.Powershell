
Function Set-CaaSChangeDiskSpeedProvIops
{
[CmdletBinding()]
Param (
    [Parameter(Mandatory)]
    [ValidateSet('ECONOMY','STANDARD','HIGHPERFORMANCE','PROVISIONEDIOPS')]
    [string]$speed,
    [Parameter(Mandatory)]
    [string]$apiPath, 
    [Parameter(Mandatory)]
    [string]$orgId,
    [Parameter(Mandatory)]
    $cred, 
    [Parameter(Mandatory)]
    $diskId, 
    [Int]$iops
)

Begin {}

Process
{
    $payload = ""

    if ($PSBoundParameters.ContainsKey('iops')) {
        $payload += "{
            `"id`" : `"${diskId}`",
            `"speed`": `"${speed}`",
            `"iops`": `"${iops}`"
        }"
    } Else {
      $payload += "{
        `"id`" : `"${diskId}`",
        `"speed`": `"${speed}`"
        }"
    }

    $endpoint = "https://$ApiPath/caas/2.12/$orgId/server/changeDiskSpeed"

    $params = @{
        Uri = $endpoint
        Credential = $cred
        Method = 'POST'
        Body = $payload
        ContentType = 'application/json'
    }

    Write-Host "Changing Disk speed: Payload:`r`n$payload"
    $r = Invoke-WebRequest @params

    if ($r.StatusCode -ne 200) {
        throw "Change Disk Speed HTTP call failed"
    }
}
}