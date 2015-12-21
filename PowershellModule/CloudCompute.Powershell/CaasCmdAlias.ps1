#
# Powershell module manifest for the Compute Client for Dimension Data CaaS.
#

New-Alias New-CaasVM New-CaasServer
New-Alias Remove-CaasVM Remove-CaasServer
New-Alias Add-CaasNatRule New-CaasNatRule
New-Alias Add-CaasAclRule New-CaasAclRule
New-Alias Out-CaasWaitForOperation Wait-CaasServerOperation

#following singular name commands
New-Alias Get-CaasNetwork Get-CaasNetworks
New-Alias Get-CaasServer Get-CaasServers
New-Alias Get-CaasCustomerImages Get-CaasCustomerImage

