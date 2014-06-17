﻿namespace DD.CBU.Compute.Api.Contracts.Provisioning
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// A new customer to do provisioning
    /// </summary>
    [GeneratedCode("xsd", "4.0.30319.1")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.Provision)]
    [XmlRoot(Namespace = XmlNamespaceConstants.Provision, IsNullable = false)]
    public class CustomerProvisioning
    {
        /// <remarks/>
        public string companyName;

        /// <remarks/>
        public int trustLevel;

        /// <remarks/>
        [XmlElementAttribute("BillingDetailses")]
        public BillingDetails BillingDetailses;

        /// <remarks/>
        [XmlElementAttribute("primaryAdministrator")]
        public PrimaryAdministrator primaryAdministrator;

        /// <remarks/>
        [XmlElementAttribute("contact")]
        public Contact contact;
    }

    /// <summary>
    /// A new customer contact details
    /// </summary>
    [GeneratedCode("xsd", "4.0.30319.1")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.Provision)]
    public class BillingDetails
    {
        /// <remarks>
        /// optional
        /// </remarks>
        public string referrerId;

        /// <remarks>
        /// optional
        /// </remarks>
        public string vatNumber;

        /// <remarks>
        /// optional
        /// </remarks>
        public string externalID;

        /// <remarks>
        /// optional
        /// </remarks>
        public string whereDidiYouFirstHearAbout;

        /// <remarks>
        /// optional
        /// </remarks>
        public string promotionCode;

        /// <remarks/>
        public string pricingPlanKey;
    }

    /// <summary>
    /// A new customer contact details
    /// </summary>
    [GeneratedCode("xsd", "4.0.30319.1")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.Provision)]
    public class Contact
    {
        /// <remarks/>
        public string email;

        /// <remarks/>
        public string firstName;

        /// <remarks/>
        public string lastName;

        /// <remarks/>
        public string address1;

        /// <remarks/>
        public string address2;

        /// <remarks/>
        public string city;

        /// <remarks>
        /// optional
        /// </remarks>
        public string state;

        /// <remarks>
        /// optional
        /// </remarks>
        public string zip;

        /// <remarks/>
        public string country;

        /// <remarks/>
        public string phoneNumber;
    }

    /// <summary>
    /// Primary Administrator
    /// </summary>
    [GeneratedCode("xsd", "4.0.30319.1")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.Provision)]
    public class PrimaryAdministrator
    {
        /// <remarks/>
        public string userName;

        /// <remarks/>
        public string password;
    }
}
