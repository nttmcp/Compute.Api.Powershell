﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Powershell.Mcp20
{
    using System.Management.Automation;
    using Api.Client;
    using Api.Contracts.Network20;
    using Api.Contracts.Requests.Network20;

    /// <summary>
    ///     The Get detailed usage report
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "CaasDetailedUsageReport")]
    [OutputType(typeof(string))]
    public class GetDetailedUsageReportCmdlet : PSCmdletCaasWithConnectionBase
    {        
        /// <summary>
        ///     Gets or sets start date.
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "The start date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     Gets or sets end date.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The end date")]
        public DateTime? EndDate { get; set; }

        protected override void ProcessRecord()
        {
            if (!EndDate.HasValue)
            {
                EndDate = DateTime.Now;
            }

            base.ProcessRecord();

            try
            {
                var result = Connection.ApiClient.Reports.GetDetailedUsageReport(StartDate, DateTime.Now).Result;
                WriteObject(result.ToString());
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
    }
}
