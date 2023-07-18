// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    // [START composer_v1_generated_Environments_PollAirflowCommand_async]
    using Google.Cloud.Orchestration.Airflow.Service.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for PollAirflowCommandAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task PollAirflowCommandRequestObjectAsync()
        {
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            PollAirflowCommandRequest request = new PollAirflowCommandRequest
            {
                Environment = "",
                ExecutionId = "",
                Pod = "",
                PodNamespace = "",
                NextLineNumber = 0,
            };
            // Make the request
            PollAirflowCommandResponse response = await environmentsClient.PollAirflowCommandAsync(request);
        }
    }
    // [END composer_v1_generated_Environments_PollAirflowCommand_async]
}