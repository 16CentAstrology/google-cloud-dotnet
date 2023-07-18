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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Connectors.V1;
using sys = System;

namespace Google.Cloud.Connectors.V1
{
    /// <summary>Resource name for the <c>ConnectorVersion</c> resource.</summary>
    public sealed partial class ConnectorVersionName : gax::IResourceName, sys::IEquatable<ConnectorVersionName>
    {
        /// <summary>The possible contents of <see cref="ConnectorVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
            /// .
            /// </summary>
            ProjectLocationProviderConnectorVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationProviderConnectorVersion = new gax::PathTemplate("projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}");

        /// <summary>Creates a <see cref="ConnectorVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectorVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectorVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectorVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectorVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectorVersionName"/> constructed from the provided ids.</returns>
        public static ConnectorVersionName FromProjectLocationProviderConnectorVersion(string projectId, string locationId, string providerId, string connectorId, string versionId) =>
            new ConnectorVersionName(ResourceNameType.ProjectLocationProviderConnectorVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), connectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string providerId, string connectorId, string versionId) =>
            FormatProjectLocationProviderConnectorVersion(projectId, locationId, providerId, connectorId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationProviderConnectorVersion(string projectId, string locationId, string providerId, string connectorId, string versionId) =>
            s_projectLocationProviderConnectorVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectorVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectorVersionName"/> if successful.</returns>
        public static ConnectorVersionName Parse(string connectorVersionName) => Parse(connectorVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectorVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectorVersionName"/> if successful.</returns>
        public static ConnectorVersionName Parse(string connectorVersionName, bool allowUnparsed) =>
            TryParse(connectorVersionName, allowUnparsed, out ConnectorVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectorVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectorVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectorVersionName, out ConnectorVersionName result) =>
            TryParse(connectorVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectorVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectorVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectorVersionName, bool allowUnparsed, out ConnectorVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectorVersionName, nameof(connectorVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProviderConnectorVersion.TryParseName(connectorVersionName, out resourceName))
            {
                result = FromProjectLocationProviderConnectorVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectorVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectorVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectorId = null, string locationId = null, string projectId = null, string providerId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectorId = connectorId;
            LocationId = locationId;
            ProjectId = projectId;
            ProviderId = providerId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectorVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectorVersionName(string projectId, string locationId, string providerId, string connectorId, string versionId) : this(ResourceNameType.ProjectLocationProviderConnectorVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), connectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Connector</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectorId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Provider</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProviderId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProviderConnectorVersion: return s_projectLocationProviderConnectorVersion.Expand(ProjectId, LocationId, ProviderId, ConnectorId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectorVersionName);

        /// <inheritdoc/>
        public bool Equals(ConnectorVersionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConnectorVersionName a, ConnectorVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConnectorVersionName a, ConnectorVersionName b) => !(a == b);
    }

    public partial class ConnectorVersion
    {
        /// <summary>
        /// <see cref="gccv::ConnectorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectorVersionName ConnectorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetConnectorVersionRequest
    {
        /// <summary>
        /// <see cref="gccv::ConnectorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectorVersionName ConnectorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectorVersionsRequest
    {
        /// <summary>
        /// <see cref="ConnectorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectorName ParentAsConnectorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}