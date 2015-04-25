﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace DD.CBU.Compute.Api.Contracts.Network20
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
	public enum ServerItemChoiceType1
	{

		/// <remarks/>
		privateIpv4,

		/// <remarks/>
		vlanId,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class NicType
	{

		private string idField;

		private string privateIpv4Field;

		private string ipv6Field;

		private string vlanIdField;

		private string vlanNameField;

		private string macAddressField;

		private string stateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string privateIpv4
		{
			get { return this.privateIpv4Field; }
			set { this.privateIpv4Field = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ipv6
		{
			get { return this.ipv6Field; }
			set { this.ipv6Field = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string vlanId
		{
			get { return this.vlanIdField; }
			set { this.vlanIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string vlanName
		{
			get { return this.vlanNameField; }
			set { this.vlanNameField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string macAddress
		{
			get { return this.macAddressField; }
			set { this.macAddressField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class OperatingSystemType
	{

		private string idField;

		private string displayNameField;

		private string familyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string displayName
		{
			get { return this.displayNameField; }
			set { this.displayNameField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string family
		{
			get { return this.familyField; }
			set { this.familyField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("server", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class ServerType
	{

		private string nameField;

		private string descriptionField;

		private OperatingSystemType operatingSystemField;

		private int cpuCountField;

		private int memoryGbField;

		private ServerTypeDisk[] diskField;

		private object itemField;

		private ServerTypeBackup backupField;

		private ServerTypeMonitoring monitoringField;

		private string[] softwareLabelField;

		private string sourceImageIdField;

		private System.DateTime createTimeField;

		private bool deployedField;

		private bool startedField;

		private string stateField;

		private ProgressType progressField;

		private ServerTypeMachineStatus[] machineStatusField;

		private string idField;

		private string datacenterIdField;

		/// <remarks/>
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}

		/// <remarks/>
		public OperatingSystemType operatingSystem
		{
			get { return this.operatingSystemField; }
			set { this.operatingSystemField = value; }
		}

		/// <remarks/>
		public int cpuCount
		{
			get { return this.cpuCountField; }
			set { this.cpuCountField = value; }
		}

		/// <remarks/>
		public int memoryGb
		{
			get { return this.memoryGbField; }
			set { this.memoryGbField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("disk")]
		public ServerTypeDisk[] disk
		{
			get { return this.diskField; }
			set { this.diskField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("networkInfo", typeof (ServerTypeNetworkInfo))]
		[System.Xml.Serialization.XmlElementAttribute("nic", typeof (ServerTypeNic))]
		public object Item
		{
			get { return this.itemField; }
			set { this.itemField = value; }
		}

		/// <remarks/>
		public ServerTypeBackup backup
		{
			get { return this.backupField; }
			set { this.backupField = value; }
		}

		/// <remarks/>
		public ServerTypeMonitoring monitoring
		{
			get { return this.monitoringField; }
			set { this.monitoringField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("softwareLabel")]
		public string[] softwareLabel
		{
			get { return this.softwareLabelField; }
			set { this.softwareLabelField = value; }
		}

		/// <remarks/>
		public string sourceImageId
		{
			get { return this.sourceImageIdField; }
			set { this.sourceImageIdField = value; }
		}

		/// <remarks/>
		public System.DateTime createTime
		{
			get { return this.createTimeField; }
			set { this.createTimeField = value; }
		}

		/// <remarks/>
		public bool deployed
		{
			get { return this.deployedField; }
			set { this.deployedField = value; }
		}

		/// <remarks/>
		public bool started
		{
			get { return this.startedField; }
			set { this.startedField = value; }
		}

		/// <remarks/>
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}

		/// <remarks/>
		public ProgressType progress
		{
			get { return this.progressField; }
			set { this.progressField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("machineStatus")]
		public ServerTypeMachineStatus[] machineStatus
		{
			get { return this.machineStatusField; }
			set { this.machineStatusField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string datacenterId
		{
			get { return this.datacenterIdField; }
			set { this.datacenterIdField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeDisk
	{

		private string idField;

		private int scsiIdField;

		private int sizeGbField;

		private string speedField;

		private string stateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int scsiId
		{
			get { return this.scsiIdField; }
			set { this.scsiIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int sizeGb
		{
			get { return this.sizeGbField; }
			set { this.sizeGbField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string speed
		{
			get { return this.speedField; }
			set { this.speedField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeNetworkInfo
	{

		private NicType primaryNicField;

		private NicType[] additionalNicField;

		private string networkDomainIdField;

		/// <remarks/>
		public NicType primaryNic
		{
			get { return this.primaryNicField; }
			set { this.primaryNicField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("additionalNic")]
		public NicType[] additionalNic
		{
			get { return this.additionalNicField; }
			set { this.additionalNicField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string networkDomainId
		{
			get { return this.networkDomainIdField; }
			set { this.networkDomainIdField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeNic
	{

		private string idField;

		private string privateIpv4Field;

		private string networkIdField;

		private string networkNameField;

		private string macAddressField;

		private string stateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string privateIpv4
		{
			get { return this.privateIpv4Field; }
			set { this.privateIpv4Field = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string networkId
		{
			get { return this.networkIdField; }
			set { this.networkIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string networkName
		{
			get { return this.networkNameField; }
			set { this.networkNameField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string macAddress
		{
			get { return this.macAddressField; }
			set { this.macAddressField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeBackup
	{

		private string assetIdField;

		private string servicePlanField;

		private string stateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string assetId
		{
			get { return this.assetIdField; }
			set { this.assetIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string servicePlan
		{
			get { return this.servicePlanField; }
			set { this.servicePlanField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeMonitoring
	{

		private string monitoringIdField;

		private string servicePlanField;

		private string stateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string monitoringId
		{
			get { return this.monitoringIdField; }
			set { this.monitoringIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string servicePlan
		{
			get { return this.servicePlanField; }
			set { this.servicePlanField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ServerTypeMachineStatus
	{

		private string nameField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class servers
	{

		private ServerType[] serverField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Server")]
		public ServerType[] Server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageNumber
		{
			get { return this.pageNumberField; }
			set { this.pageNumberField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageNumberSpecified
		{
			get { return this.pageNumberFieldSpecified; }
			set { this.pageNumberFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageCount
		{
			get { return this.pageCountField; }
			set { this.pageCountField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageCountSpecified
		{
			get { return this.pageCountFieldSpecified; }
			set { this.pageCountFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int totalCount
		{
			get { return this.totalCountField; }
			set { this.totalCountField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool totalCountSpecified
		{
			get { return this.totalCountFieldSpecified; }
			set { this.totalCountFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageSize
		{
			get { return this.pageSizeField; }
			set { this.pageSizeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageSizeSpecified
		{
			get { return this.pageSizeFieldSpecified; }
			set { this.pageSizeFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deployServer", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class DeployServerType
	{

		private string nameField;

		private string descriptionField;

		private string imageIdField;

		private bool startField;

		private string administratorPasswordField;

		private object itemField;

		private DeployServerTypeDisk[] diskField;

		/// <remarks/>
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}

		/// <remarks/>
		public string imageId
		{
			get { return this.imageIdField; }
			set { this.imageIdField = value; }
		}

		/// <remarks/>
		public bool start
		{
			get { return this.startField; }
			set { this.startField = value; }
		}

		/// <remarks/>
		public string administratorPassword
		{
			get { return this.administratorPasswordField; }
			set { this.administratorPasswordField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("network", typeof (DeployServerTypeNetwork))]
		[System.Xml.Serialization.XmlElementAttribute("networkInfo", typeof (DeployServerTypeNetworkInfo))]
		public object Item
		{
			get { return this.itemField; }
			set { this.itemField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("disk")]
		public DeployServerTypeDisk[] disk
		{
			get { return this.diskField; }
			set { this.diskField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class DeployServerTypeNetwork
	{

		private string itemField;

		private ServerItemChoiceType itemElementNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("networkId", typeof (string))]
		[System.Xml.Serialization.XmlElementAttribute("privateIpv4", typeof (string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public string Item
		{
			get { return this.itemField; }
			set { this.itemField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ServerItemChoiceType ItemElementName
		{
			get { return this.itemElementNameField; }
			set { this.itemElementNameField = value; }
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class VlanIdOrPrivateIpType
	{

		private string itemField;

		private ServerItemChoiceType1 itemElementNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("privateIpv4", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("vlanId", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public string Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ServerItemChoiceType1 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
	public enum ServerItemChoiceType
	{

		/// <remarks/>
		networkId,

		/// <remarks/>
		privateIpv4,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class DeployServerTypeNetworkInfo
	{

		private VlanIdOrPrivateIpType primaryNicField;

		private VlanIdOrPrivateIpType[] additionalNicField;

		private string networkDomainIdField;

		/// <remarks/>
		public VlanIdOrPrivateIpType primaryNic
		{
			get { return this.primaryNicField; }
			set { this.primaryNicField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("additionalNic")]
		public VlanIdOrPrivateIpType[] additionalNic
		{
			get { return this.additionalNicField; }
			set { this.additionalNicField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string networkDomainId
		{
			get { return this.networkDomainIdField; }
			set { this.networkDomainIdField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class DeployServerTypeDisk
	{

		private ushort scsiIdField;

		private string speedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ushort scsiId
		{
			get { return this.scsiIdField; }
			set { this.scsiIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string speed
		{
			get { return this.speedField; }
			set { this.speedField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("notifyNicIpChange", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class NotifyNicIpChangeType
	{

		private string privateIpv4Field;

		private string ipv6Field;

		private string nicIdField;

		/// <remarks/>
		public string privateIpv4
		{
			get { return this.privateIpv4Field; }
			set { this.privateIpv4Field = value; }
		}

		/// <remarks/>
		public string ipv6
		{
			get { return this.ipv6Field; }
			set { this.ipv6Field = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nicId
		{
			get { return this.nicIdField; }
			set { this.nicIdField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("addNic", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class AddNicType
	{
		/// <remarks/>
		public string serverId { get; set; }

		/// <summary>	Gets or sets the private IPv4. </summary>
		/// <value>	The private IPv4. </value>
		[System.Xml.Serialization.XmlElementAttribute("privateIpv4", typeof (string))]
		public string PrivateIPv4
		{
			get; set;
		}

		/// <summary>	Gets or sets the identifier of the vlan. </summary>
		/// <value>	The identifier of the vlan. </value>
		[System.Xml.Serialization.XmlElementAttribute("vlanId", typeof (string))]
		public string VLANId
		{
			get; set;
		}
	}
}