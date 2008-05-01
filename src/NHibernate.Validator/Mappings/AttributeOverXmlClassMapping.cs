using System;
using System.Collections.Generic;
using System.Reflection;
using Iesi.Collections.Generic;
using NHibernate.Validator.Cfg.MappingSchema;

namespace NHibernate.Validator.Mappings
{
	public class AttributeOverXmlClassMapping : MixedClassMapping
	{

		public AttributeOverXmlClassMapping(NhvmClass meta) : base(meta) {}

		protected override void InitializeMembers(HashedSet<MemberInfo> lmembers, XmlClassMapping xmlcm, ReflectionClassMapping rcm)
		{
			MixMembersWith(lmembers, xmlcm);
			MixMembersWith(lmembers, rcm);
		}

		protected override void InitializeClassAttributes(XmlClassMapping xmlcm, ReflectionClassMapping rcm)
		{
			classAttributes = new List<Attribute>();
			CombineAttribute(xmlcm.GetClassAttributes(), classAttributes);
			CombineAttribute(rcm.GetClassAttributes(), classAttributes);
		}
	}
}