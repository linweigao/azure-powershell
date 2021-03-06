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

using Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.DataObjects;

namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.Commands.BaseCommandInterfaces
{
    /// <summary>
    ///     Represents a command to set a default storage account for an Azure HDInsight config.
    /// </summary>
    internal interface ISetAzureHDInsightDefaultStorageBase
    {
        /// <summary>
        ///     Gets or sets the AzureHDInsightConfig.
        /// </summary>
        AzureHDInsightConfig Config { get; set; }

        /// <summary>
        ///     Gets or sets the Storage Account Key.
        /// </summary>
        string StorageAccountKey { get; set; }

        /// <summary>
        ///     Gets or sets the Storage Account Name.
        /// </summary>
        string StorageAccountName { get; set; }

        /// <summary>
        ///     Gets or sets the Storage Container Name.
        /// </summary>
        string StorageContainerName { get; set; }
    }
}
