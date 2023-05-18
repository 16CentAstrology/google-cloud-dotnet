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
    // [START logging_v2_generated_ConfigServiceV2_CreateLink_sync]
    using Google.Cloud.Logging.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for CreateLink</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateLinkRequestObject()
        {
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateLinkRequest request = new CreateLinkRequest
            {
                ParentAsLogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Link = new Link(),
                LinkId = "",
            };
            // Make the request
            Operation<Link, LinkMetadata> response = configServiceV2Client.CreateLink(request);

            // Poll until the returned long-running operation is complete
            Operation<Link, LinkMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, LinkMetadata> retrievedResponse = configServiceV2Client.PollOnceCreateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END logging_v2_generated_ConfigServiceV2_CreateLink_sync]
}