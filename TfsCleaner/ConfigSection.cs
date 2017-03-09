using System.Configuration;

namespace FYK.Tfs.TfsCleaner
{
	public class Operation : ConfigurationElement
	{
		[ConfigurationProperty("Name", IsRequired = true)]
		public string Name
		{
			get { return (string)this["Name"]; }
			set { this["Name"] = value; }
		}

		
		[ConfigurationProperty("Condition", IsRequired = true, DefaultValue = "[System.WorkItemType]='Task'")]
		public string Condition
		{
			get { return (string)this["Condition"]; }
			set { this["Condition"] = value; }
		}

		[ConfigurationProperty("Action", IsRequired = true)]
		public ActionElement Action
		{
			get { return (ActionElement)this["Action"]; }
			set { this["Action"] = value; }
		}

		[ConfigurationProperty("Project", IsRequired = true)]
		public string Project
		{
			get { return (string)this["Project"]; }
			set { this["Project"] = value; }
		}

	}
	
	public class ActionElement : ConfigurationElement
	{
		[ConfigurationProperty("Type", IsRequired = true, DefaultValue = "Set")]
		[RegexStringValidator("(Set)")]
		public string Type
		{
			get { return (string)this["Type"]; }
			set { this["Type"] = value; }
		}

		[ConfigurationProperty("FieldName", IsRequired = true)]
		public string FieldName
		{
			get { return (string)this["FieldName"]; }
			set { this["FieldName"] = value; }
		}

		[ConfigurationProperty("NewValue", IsRequired = true)]
		public string NewValue
		{
			get { return (string)this["NewValue"]; }
			set { this["NewValue"] = value; }
		}
	}

	public class Operations : ConfigurationElementCollection
	{
		public Operation this[int index]
		{
			get { return (Operation)BaseGet(index); }
			set
			{
				if (BaseGet(index) != null)
					BaseRemoveAt(index);
				BaseAdd(index, value);
			}
		}
		public new Operation this[string responseString]
		{
			get { return (Operation)BaseGet(responseString); }
			set
			{
				if (BaseGet(responseString) != null)
					BaseRemoveAt(BaseIndexOf(BaseGet(responseString)));
				BaseAdd(value);
			}
		}
		protected override ConfigurationElement CreateNewElement()
		{
			return new Operation();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((Operation)element).Name;
		}
	}

	public class TfsElement : ConfigurationElement
	{

		[ConfigurationProperty("URL", IsRequired = true)]
		public string URL
		{
			get { return (string)this["URL"]; }
			set { this["URL"] = value; }
		}

		[ConfigurationProperty("UserName", IsRequired = true)]
		public string UserName
		{
			get { return (string)this["UserName"]; }
			set { this["UserName"] = value; }
		}

		[ConfigurationProperty("Domain", IsRequired = true)]
		public string Domain
		{
			get { return (string)this["Domain"]; }
			set { this["Domain"] = value; }
		}

		[ConfigurationProperty("Password", IsRequired = true)]
		public string Password
		{
			get { return Utils.UnProtect((string)this["Password"]); }
			set { this["Password"] = Utils.Protect(value); }
		}
	}

	public class OperationsSection : ConfigurationSection
	{
		public static OperationsSection GetConfig()
		{
			return (OperationsSection)ConfigurationManager.GetSection("TfsCleanerOperations") ?? new OperationsSection();
		}

		[ConfigurationProperty("Operations")]
		[ConfigurationCollection(typeof(Operations), AddItemName = "Operation")]
		public Operations Operations
		{
			get
			{
				object o = this["Operations"];
				return o as Operations;
			}
		}

		[ConfigurationProperty("Configuration", IsRequired = true)]
		public TfsElement Configuration
		{
			get { return (TfsElement)this["Configuration"]; }
			set { this["Configuration"] = value; }
		}
	}
}
