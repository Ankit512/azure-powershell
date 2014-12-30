﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network
{
    using Microsoft.Azure.Common.Extensions;
    using Microsoft.Azure.Common.Extensions.Models;
    using WindowsAzure.Commands.Common;
    using WindowsAzure.Commands.Utilities.Common;
    using WindowsAzure.Commands.Utilities.Profile;

    /// <summary>
    /// The base class for all Microsoft Azure Network Gateway Management Cmdlets
    /// </summary>
    public abstract class NetworkCmdletBase : AzurePSCmdlet
    {
        private NetworkClient client;

        protected AzureSubscription CurrentSubscription
        {
            get { return AzureSession.CurrentContext.Subscription; }
        }

        protected NetworkClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new NetworkClient(CurrentSubscription, CommandRuntime);
                }
                return client;
            }
        }
    }
}