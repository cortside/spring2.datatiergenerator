using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Xml;

using Spring2.DataTierGenerator;
using Spring2.DataTierGenerator.Element;
using Spring2.DataTierGenerator.Parser;
using Spring2.DataTierGenerator.Util;
using Spring2.DataTierGenerator.Generator.Task;

using Type = Spring2.DataTierGenerator.Element.Type;


namespace Spring2.DataTierGenerator.Generator {

    public class GeneratorTaskManager : GeneratorSkeleton, IGenerator {
	private IParser parser;

	public GeneratorTaskManager(IParser parser) {
	    this.parser = parser;
	    this.options = parser.Configuration;
	}

	public override void Generate() {
	    Console.Out.Write("\n");
	    Console.Out.WriteLine(String.Empty.PadLeft(20,'='));

	    if (parser.IsValid) {
		IList tasks = parser.Generator.FindTasksByElement("sqlentity");
		if (tasks.Count > 0) {
		    foreach (Database database in parser.Databases) {
			foreach (SqlEntity sqlentity in database.SqlEntities) {
			    foreach(Element.Task task in tasks) {
				IGenerator g = new VelocityTask(options, sqlentity, task, sqlentity.Name);
				g.Generate();
			    }

			    // foreach index
			    // foreach constraint
			}
		    }
		}

		tasks = parser.Generator.FindTasksByElement("entity");
		if (tasks.Count > 0) {
		    foreach (Entity entity in parser.Entities) {
			foreach(Element.Task task in tasks) {
			    IGenerator g = new VelocityTask(options, entity, task, entity.Name);
			    g.Generate();
			}

			// foreach finder
		    }
		}

		tasks = parser.Generator.FindTasksByElement("enum");
		if (tasks.Count > 0) {
		    foreach (EnumType type in parser.Enums) {
			foreach(Element.Task task in tasks) {
			    IGenerator g = new VelocityTask(options, type, task, type.Name);
			    g.Generate();
			}
		    }
		}

		tasks = parser.Generator.FindTasksByElement("collection");
		if (tasks.Count > 0) {
		    foreach (Collection collection in parser.Collections) {
			foreach(Element.Task task in tasks) {
			    IGenerator g = new VelocityTask(options, collection, task, collection.Name);
			    g.Generate();
			}
		    }
		}
	    } else {
		Console.Out.WriteLine("Parser was not in a valid state and reported the following errors:\n" + parser.Errors);
	    }
			
	    Console.Out.WriteLine(String.Empty.PadLeft(20,'='));
	}

    }
}
