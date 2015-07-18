﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml.Serialization;

namespace DD.CBU.Compute.Api.Contracts.Network20
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ProgressStepType
	{

		private string nameField;

		private int numberField;

		private int percentCompleteField;

		private bool percentCompleteFieldSpecified;

		/// <remarks/>
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		public int number
		{
			get { return this.numberField; }
			set { this.numberField = value; }
		}

		/// <remarks/>
		public int percentComplete
		{
			get { return this.percentCompleteField; }
			set { this.percentCompleteField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool percentCompleteSpecified
		{
			get { return this.percentCompleteFieldSpecified; }
			set { this.percentCompleteFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ProgressType
	{

		private string actionField;

		private System.DateTime requestTimeField;

		private string userNameField;

		private int numberOfStepsField;

		private bool numberOfStepsFieldSpecified;

		private System.DateTime updateTimeField;

		private bool updateTimeFieldSpecified;

		private ProgressStepType stepField;

		private string failureReasonField;

		/// <remarks/>
		public string action
		{
			get { return this.actionField; }
			set { this.actionField = value; }
		}

		/// <remarks/>
		public System.DateTime requestTime
		{
			get { return this.requestTimeField; }
			set { this.requestTimeField = value; }
		}

		/// <remarks/>
		public string userName
		{
			get { return this.userNameField; }
			set { this.userNameField = value; }
		}

		/// <remarks/>
		public int numberOfSteps
		{
			get { return this.numberOfStepsField; }
			set { this.numberOfStepsField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool numberOfStepsSpecified
		{
			get { return this.numberOfStepsFieldSpecified; }
			set { this.numberOfStepsFieldSpecified = value; }
		}

		/// <remarks/>
		public System.DateTime updateTime
		{
			get { return this.updateTimeField; }
			set { this.updateTimeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool updateTimeSpecified
		{
			get { return this.updateTimeFieldSpecified; }
			set { this.updateTimeFieldSpecified = value; }
		}

		/// <remarks/>
		public ProgressStepType step
		{
			get { return this.stepField; }
			set { this.stepField = value; }
		}

		/// <remarks/>
		public string failureReason
		{
			get { return this.failureReasonField; }
			set { this.failureReasonField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("networkDomain", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class NetworkDomainType
	{

		private string nameField;

		private string descriptionField;

		private string typeField;

		private string snatIpv4AddressField;

		private System.DateTime createTimeField;

		private string stateField;

		private ProgressType progressField;

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
		public string type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}

		/// <remarks/>
		public string snatIpv4Address
		{
			get { return this.snatIpv4AddressField; }
			set { this.snatIpv4AddressField = value; }
		}

		/// <remarks/>
		public System.DateTime createTime
		{
			get { return this.createTimeField; }
			set { this.createTimeField = value; }
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value.Replace(" ", String.Empty); }
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
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class networkDomains
	{

		private NetworkDomainType[] networkDomainField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("networkDomain")]
		public NetworkDomainType[] networkDomain
		{
			get { return this.networkDomainField; }
			set { this.networkDomainField = value; }
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
	[System.Xml.Serialization.XmlRootAttribute("deployNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class DeployNetworkDomainType
	{

		private string datacenterIdField;

		private string nameField;

		private string descriptionField;

		private string typeField;

		/// <remarks/>
		public string datacenterId
		{
			get { return this.datacenterIdField; }
			set { this.datacenterIdField = value; }
		}

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
		public string type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("editNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class EditNetworkDomainType
	{

		private string nameField;

		private string descriptionField;

		private string typeField;

		private string idField;

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
		public string type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value.Replace(" ", String.Empty); }
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deleteNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class DeleteNetworkDomainType
	{
		private string idField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value.Replace(" ", String.Empty); }
		}
	}
}