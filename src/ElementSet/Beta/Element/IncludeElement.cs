using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace Spring2.DataTierGenerator.Element {

    public class IncludeElement : ElementSkeleton {

	public static String INCLUDE = "include";

	public IncludeElement() {}

	public IncludeElement(XmlNode includeNode) : base(includeNode) {
	    if (!INCLUDE.Equals(includeNode.Name)) {
		throw new ArgumentException("The XmlNode argument is not an include node.");
	    }
	}

	public override void Validate(RootElement root) {}
    }
}
