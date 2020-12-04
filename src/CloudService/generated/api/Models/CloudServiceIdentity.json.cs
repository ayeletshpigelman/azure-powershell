// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    public partial class CloudServiceIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject into a new instance of <see cref="CloudServiceIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CloudServiceIdentity(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_cloudServiceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("cloudServiceName"), out var __jsonCloudServiceName) ? (string)__jsonCloudServiceName : (string)CloudServiceName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_roleInstanceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("roleInstanceName"), out var __jsonRoleInstanceName) ? (string)__jsonRoleInstanceName : (string)RoleInstanceName;}
            {_roleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("roleName"), out var __jsonRoleName) ? (string)__jsonRoleName : (string)RoleName;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_updateDomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNumber>("updateDomain"), out var __jsonUpdateDomain) ? (int?)__jsonUpdateDomain : UpdateDomain;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.ICloudServiceIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.ICloudServiceIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.ICloudServiceIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json ? new CloudServiceIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CloudServiceIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CloudServiceIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._cloudServiceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._cloudServiceName.ToString()) : null, "cloudServiceName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._roleInstanceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._roleInstanceName.ToString()) : null, "roleInstanceName" ,container.Add );
            AddIf( null != (((object)this._roleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._roleName.ToString()) : null, "roleName" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != this._updateDomain ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNumber((int)this._updateDomain) : null, "updateDomain" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}