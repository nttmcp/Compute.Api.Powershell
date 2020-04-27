﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveCaasServerCmdlet.cs" company="">
//   
// </copyright>
// <summary>
//   The Re,pve CaaS Virtual Machine cmdlet.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Contracts.General;

namespace DD.CBU.Compute.Powershell
{
    using Api.Contracts.Network20;

    /// <summary>
	///     The Re,pve CaaS Virtual Machine cmdlet.
	/// </summary>
	[Cmdlet(VerbsCommon.Remove, "CaasServer", SupportsShouldProcess = true)]
    [OutputType(typeof(ResponseType))]
	public class RemoveCaasServerCmdlet : PsCmdletCaasServerBase
	{
		/// <summary>
		///     The process record method.
		/// </summary>
		protected override void ProcessRecord()
		{
			try
			{
				if (!ShouldProcess(Server.name)) return;
				var status = Connection.ApiClient.ServerManagement.Server.DeleteServer(Guid.Parse(Server.id)).Result;

				WriteObject(status);
			}
			catch (AggregateException ae)
			{
				ae.Handle(
					e =>
					{
						if (e is ComputeApiException)
						{
							WriteError(new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, Connection));
						}
						else
						{
// if (e is HttpRequestException)
							ThrowTerminatingError(new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, Connection));
						}

						return true;
					});
			}

			base.ProcessRecord();
		}
	}
}