using System;
using System.Collections;

namespace Spring2.DataTierGenerator.Generator {
    /// <summary>
    /// Summary description for IGenerator.
    /// </summary>
    public interface IGenerator {

	/// <summary>
	/// Call the generator to action and output somthing.
	/// </summary>
	void Generate(IParser parser);

	/// <summary>
	/// List of log messages (String) that were created durring generation
	/// </summary>
	IList Log {
	    get;
	}

    }
}
