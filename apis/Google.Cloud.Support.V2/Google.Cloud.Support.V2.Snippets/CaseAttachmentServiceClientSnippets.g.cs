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
    using Google.Api.Gax;
    using Google.Cloud.Support.V2;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCaseAttachmentServiceClientSnippets
    {
        /// <summary>Snippet for ListAttachments</summary>
        public void ListAttachmentsRequestObject()
        {
            // Snippet: ListAttachments(ListAttachmentsRequest, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = CaseAttachmentServiceClient.Create();
            // Initialize request argument(s)
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            PagedEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachmentsAsync</summary>
        public async Task ListAttachmentsRequestObjectAsync()
        {
            // Snippet: ListAttachmentsAsync(ListAttachmentsRequest, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = await CaseAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachments</summary>
        public void ListAttachments()
        {
            // Snippet: ListAttachments(string, string, int?, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = CaseAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            PagedEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachmentsAsync</summary>
        public async Task ListAttachmentsAsync()
        {
            // Snippet: ListAttachmentsAsync(string, string, int?, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = await CaseAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachments</summary>
        public void ListAttachmentsResourceNames()
        {
            // Snippet: ListAttachments(CaseName, string, int?, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = CaseAttachmentServiceClient.Create();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            PagedEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachmentsAsync</summary>
        public async Task ListAttachmentsResourceNamesAsync()
        {
            // Snippet: ListAttachmentsAsync(CaseName, string, int?, CallSettings)
            // Create client
            CaseAttachmentServiceClient caseAttachmentServiceClient = await CaseAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> response = caseAttachmentServiceClient.ListAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}