// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Helpers.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyPermission.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyPermission
    {
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Full")]
        Full
    }
    internal static class KeyPermissionEnumExtension
    {
        internal static string ToSerializedValue(this KeyPermission? value)
        {
            return value == null ? null : ((KeyPermission)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this KeyPermission value)
        {
            switch( value )
            {
                case KeyPermission.Read:
                    return "Read";
                case KeyPermission.Full:
                    return "Full";
            }
            return null;
        }

        internal static KeyPermission? ParseKeyPermission(this string value)
        {
            switch( value )
            {
                case "Read":
                    return KeyPermission.Read;
                case "Full":
                    return KeyPermission.Full;
            }
            return null;
        }
    }
}
