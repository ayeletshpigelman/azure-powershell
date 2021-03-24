// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    /// <summary>Gets or sets the type of the source data store.</summary>
    public partial struct SourceDataStoreType :
        System.IEquatable<SourceDataStoreType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType ArchiveStore = @"ArchiveStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType SnapshotStore = @"SnapshotStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType VaultStore = @"VaultStore";

        /// <summary>the value for an instance of the <see cref="SourceDataStoreType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SourceDataStoreType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SourceDataStoreType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SourceDataStoreType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SourceDataStoreType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SourceDataStoreType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SourceDataStoreType && Equals((SourceDataStoreType)obj);
        }

        /// <summary>Returns hashCode for enum SourceDataStoreType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SourceDataStoreType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SourceDataStoreType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SourceDataStoreType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SourceDataStoreType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SourceDataStoreType" />.</param>

        public static implicit operator SourceDataStoreType(string value)
        {
            return new SourceDataStoreType(value);
        }

        /// <summary>Implicit operator to convert SourceDataStoreType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SourceDataStoreType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SourceDataStoreType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SourceDataStoreType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType e2)
        {
            return e2.Equals(e1);
        }
    }
}