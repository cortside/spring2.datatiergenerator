using System;
using System.Data;
using System.IO;
using System.Collections;
using System.Text;

namespace Spring2.DataTierGenerator {

    public class DOGenerator : GeneratorBase {
	private Entity entity;

	public DOGenerator(Configuration options, Entity entity) : base(options) {
	    this.entity = entity;
	}

	public void CreateDataObjectClass() {
	    StringBuilder sb = new StringBuilder(4096);
			
	    // Create the header for the class
	    sb.Append(GetUsingNamespaces(entity.Fields, false)).Append("\n");

	    // class definition
	    sb.Append("namespace " + options.GetDONameSpace(entity.Name) + " {\n");
	    sb.Append("    public class " + options.GetDOClassName(entity.Name));
	    if (options.DataObjectBaseClass.Length>0) {
		sb.Append(" : ").Append(options.DataObjectBaseClass);
	    }
	    sb.Append(" {\n\n");

	    // declaration of private member variables
	    foreach (Field field in entity.Fields) {
		if (field.Name.IndexOf('.')<0) {
		    sb.Append("\t").Append(field.AccessModifier).Append(" ");
		    sb.Append(field.Type.Name);
		    sb.Append(" ").Append(field.GetFieldFormat()).Append(" = ");
		    sb.Append(field.Type.NewInstanceFormat).Append(";\n");
		}
	    }
	    sb.Append("\n");

	    // accessor methods
	    foreach (Field field in entity.Fields) {
		if (field.Name.IndexOf('.')<0) {
		    if (field.Description.Length>0) {
			sb.Append("\t/// <summary>\n");
			sb.Append("\t/// ").Append(field.Description).Append("\n");
			sb.Append("\t/// </summary>\n");
		    }

		    sb.Append("\tpublic ");
		    sb.Append(field.Type.Name);
		    sb.Append(" ").Append(field.GetMethodFormat()).Append(" {\n");
		    sb.Append("\t    get { return this.").Append(field.GetFieldFormat()).Append("; }\n");
		    sb.Append("\t    set { this.").Append(field.GetFieldFormat()).Append(" = value; }\n");
		    sb.Append("\t}\n\n");
		}
	    }
		
	    // Close out the class and namespace
	    sb.Append("    }\n");
	    sb.Append("}\n");

	    FileInfo file = new FileInfo(options.RootDirectory + options.DoClassDirectory + "\\" + options.GetDOClassName(entity.Name) + ".cs");
	    WriteToFile(file, sb.ToString(), false);
	}
    }
}