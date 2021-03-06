using System;
using System.Collections;

using Spring2.DataTierGenerator.Element;
using Spring2.DataTierGenerator.Generator;

namespace Spring2.DataTierGenerator.Parser {

    public class Task : ITask {

	AbstractParser parser;
	TaskElement task;

	public Task(AbstractParser parser, TaskElement task) {
	    this.parser = parser;
	    this.task = task;
	}

	public ElementList Elements {
	    get { 
		ElementList list = new ElementList();

		if (task.Element.Equals("sqlentity")) {
		    foreach (DatabaseElement database in parser.Databases) {
			foreach (SqlEntityElement sqlentity in database.SqlEntities) {
			    if (task.IsIncluded(sqlentity.Name)) {
				list.Add(sqlentity);
			    }
			}
		    }
		}

		if (task.Element.Equals("entity")) {
		    foreach (EntityElement entity in parser.Entities) {
			if (task.IsIncluded(entity.Name)) {
			    list.Add(entity);
			}
		    }
		}

		if (task.Element.Equals("enum")) {
		    foreach (EnumElement type in parser.Enums) {
			if (task.IsIncluded(type.Name)) {
			    list.Add(type);
			}
		    }
		}

		if (task.Element.Equals("collection")) {
		    foreach (CollectionElement collection in parser.Collections) {
			if (task.IsIncluded(collection.Name)) {
			    list.Add(collection);
			}
		    }
		}

		if (task.Element.Equals("reportextraction")) {
		    foreach (ReportExtractionElement reportExtraction in parser.ReportExtractions) {
			if (task.IsIncluded(reportExtraction.Name)) {
			    list.Add(reportExtraction);
			}
		    }
		}

		if (task.Element.Equals("message")) {
		    foreach (MessageElement message in parser.Messages) {
			if (task.IsIncluded(message.Name)) {
			    list.Add(message);
			}
		    }
		}

		// the entire list of entities as a list
		if (task.Element.Equals("entities")) {
		    ListElement element = new ListElement();
		    element.Name = "entities";
		    element.List = parser.Entities;
		    list.Add(element);
		}

		// the entire list of sql entities as a list
		if (task.Element.Equals("sqlentities")) {
		    ArrayList sqlentities = new ArrayList();

		    foreach (DatabaseElement database in parser.Databases) {
			sqlentities.AddRange(database.SqlEntities);
		    }
		    ListElement element = new ListElement();
		    element.Name = "sqlentities";
		    element.List = sqlentities;
		    list.Add(element);
		}

		// the entire list of collections as a list
		if (task.Element.Equals("collections")) {
		    ListElement element = new ListElement();
		    element.Name = "collections";
		    element.List = parser.Collections;
		    list.Add(element);
		}

		// the entire list of enums as a list
		if (task.Element.Equals("enums")) {
		    ListElement element = new ListElement();
		    element.Name = "enums";
		    element.List = parser.Enums;
		    list.Add(element);
		}

		// the entire list of messasges as a list
		if (task.Element.Equals("messages")) {
		    ListElement element = new ListElement();
		    element.Name = "messages";
		    element.List = parser.Messages;
		    list.Add(element);
		}

		return list;
	    }
	}

	public String FileNameFormat {
	    get { return task.FileNameFormat; }
	}

	public String Directory {
	    get { return ((Configuration)parser.Configuration).RootDirectory + "\\" + task.Directory; }
	}

	public String BackupDirectory 
	{
	    get { return ((Configuration)parser.Configuration).RootDirectory + "\\" + task.BackupDirectory; }
	}

	public Hashtable Parameters 
	{
	    get 
	    { 
		Hashtable parameters = new Hashtable();
		foreach(ParameterElement parameter in task.Parameters) 
		{
		    parameters.Add(parameter.Name, parameter.Value);
		}
		return parameters;
	    }
	}

	public String Writer {
	    get { return task.Writer; }
	}

	public String Styler {
	    get { return task.Styler; }
	}

    	public String Name {
    		get { return task.Name; }
    	}

    	public String Template {
	    get { return task.Template; }
	}


    }
}
