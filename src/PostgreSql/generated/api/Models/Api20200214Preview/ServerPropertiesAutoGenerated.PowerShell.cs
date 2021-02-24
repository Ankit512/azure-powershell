namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>The properties of a server.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesAutoGeneratedTypeConverter))]
    public partial class ServerPropertiesAutoGenerated
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerPropertiesAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerPropertiesAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgument = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments) content.GetValueForProperty("DelegatedSubnetArgument",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgument, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesDelegatedSubnetArgumentsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin = (string) content.GetValueForProperty("AdministratorLogin",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaState = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState?) content.GetValueForProperty("HaState",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaState, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName = (string) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaEnabled = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum?) content.GetValueForProperty("HaEnabled",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaEnabled, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).SourceServerName = (string) content.GetValueForProperty("SourceServerName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).SourceServerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PointInTimeUtc = (global::System.DateTime?) content.GetValueForProperty("PointInTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PointInTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StandbyAvailabilityZone = (string) content.GetValueForProperty("StandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StandbyAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).ByokEnforcement = (string) content.GetValueForProperty("ByokEnforcement",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).ByokEnforcement, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode?) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgumentSubnetArmResourceId = (string) content.GetValueForProperty("DelegatedSubnetArgumentSubnetArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgumentSubnetArmResourceId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerPropertiesAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgument = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments) content.GetValueForProperty("DelegatedSubnetArgument",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgument, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesDelegatedSubnetArgumentsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin = (string) content.GetValueForProperty("AdministratorLogin",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaState = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState?) content.GetValueForProperty("HaState",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaState, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName = (string) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaEnabled = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum?) content.GetValueForProperty("HaEnabled",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).HaEnabled, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).SourceServerName = (string) content.GetValueForProperty("SourceServerName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).SourceServerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PointInTimeUtc = (global::System.DateTime?) content.GetValueForProperty("PointInTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).PointInTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StandbyAvailabilityZone = (string) content.GetValueForProperty("StandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StandbyAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).ByokEnforcement = (string) content.GetValueForProperty("ByokEnforcement",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).ByokEnforcement, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode?) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgumentSubnetArmResourceId = (string) content.GetValueForProperty("DelegatedSubnetArgumentSubnetArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal)this).DelegatedSubnetArgumentSubnetArmResourceId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a server.
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesAutoGeneratedTypeConverter))]
    public partial interface IServerPropertiesAutoGenerated

    {

    }
}