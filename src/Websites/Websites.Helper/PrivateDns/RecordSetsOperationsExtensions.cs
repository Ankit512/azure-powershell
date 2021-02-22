// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.PrivateDns
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecordSetsOperations.
    /// </summary>
    public static partial class RecordSetsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA can be
            /// updated but not created (they are created when the Private DNS zone is
            /// created). Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR',
            /// 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new record set to be created, but to prevent updating
            /// an existing record set. Other values will be ignored.
            /// </param>
            public static RecordSet CreateOrUpdate(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA can be
            /// updated but not created (they are created when the Private DNS zone is
            /// created). Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR',
            /// 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new record set to be created, but to prevent updating
            /// an existing record set. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecordSet> CreateOrUpdateAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
