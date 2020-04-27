﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeployCaasVlanCmdlet.cs" company="">
//   
// </copyright>
// <summary>
//   The new CaaS Virtual Machine cmdlet.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DD.CBU.Compute.Powershell.Mcp20
{
    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Net;
    using Api.Client;
    using Api.Contracts.Generic;
    using Api.Contracts.Network20;
    using Contracts;

    /// <summary>
    ///     The new CaaS Virtual Machine cmdlet.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "CaasVlan")]
    [OutputType(typeof(ResponseType))]
    public class NewCaasVlanCmdlet : WaitableCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "With_NetworkDomainId", HelpMessage = "The network domain id")]
        public string NetworkDomainId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "With_NetworkDomain", HelpMessage = "The network domain")]
        public NetworkDomainType NetworkDomain { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The vlan name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The vlan description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the private ip v4 base address.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The vlan Private Ipv4BaseAddress")]
        public IPAddress PrivateIpv4BaseAddress { get; set; }

        /// <summary>
        ///     Gets or sets the private ip v4 base address.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The vlan Private Ipv4 PrefixSize, must be between 16 and 24")]
        public int PrivateIpv4PrefixSize { get; set; }

        /// <summary>
        ///     Gets or sets the private ip v4 base address.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The vlan Gateway Addressing (HIGH/LOW). Defaults to LOW if not provided.")]
        public string GatewayAddressing { get; set; }

        /// <summary>
        ///     The process record method.
        /// </summary>
        protected override void ProcessRecord()
        {
            if (NetworkDomain != null)
            {
                NetworkDomainId = NetworkDomain.id;
            }

            try
            {
                var response = Connection.ApiClient.Networking.Vlan.DeployVlan(
                    new DeployVlanType
                    {
                        name = Name,
                        description = Description,
                        networkDomainId = NetworkDomainId,
                        privateIpv4PrefixSize = PrivateIpv4PrefixSize,
                        privateIpv4NetworkAddress = (PrivateIpv4BaseAddress == null ? string.Empty : PrivateIpv4BaseAddress.ToString())
                    }).Result;
                if (response != null)
                    WriteDebug(
                        string.Format(
                            "{0} resulted in {1} ({2}): {3}",
                            response.operation,
                            response.message,
                            response.requestId,
                            response.responseCode));

                base.ProcessRecord();

                Guid vlanId = Guid.Parse(response.info.First(nvp => nvp.name == "vlanId").value);

                WaitForFailureOrCompletion(response, vlanId);
            }
            catch (AggregateException ae)
            {
                ae.Handle(
                    e =>
                    {
                        if (e is ComputeApiException)
                        {
                            WriteError(
                                new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, Connection));
                        }
                        else
                        {
                            ThrowTerminatingError(
                                new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, Connection));
                        }

                        return true;
                    });
            }
        }

        public override void Update(Guid objectId, ref IEntityStatusV2 provisionedObject)
        {
            provisionedObject = Connection.ApiClient.Networking.Vlan.GetVlan(objectId).Result;
        }
    }
}
