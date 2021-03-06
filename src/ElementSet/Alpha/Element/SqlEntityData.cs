using System;
using System.Collections;
using System.Text;
using System.Xml;

using Spring2.DataTierGenerator;

namespace Spring2.DataTierGenerator.Element {
    /// <summary>
    /// Summary description for SqlEntityData.
    /// </summary>
    public class SqlEntityData : SqlElementSkeleton {

	protected static readonly String KEY = "key";
	protected static readonly String SCRIPT_SINGLE_FILE = "scriptsinglefile";
	protected static readonly String SERVER = "server";
	protected static readonly String DATABASE = "database";
	protected static readonly String USER = "user";
	protected static readonly String PASSWORD = "password";
	protected static readonly String SCRIPT_DIRECTORY = "scriptdirectory";
	protected static readonly String STORED_PROC_NAME_FORMAT = "storedprocnameformat";
	protected static readonly String GENERATE_VIEW_SCRIPT = "generateviewscript";
	protected static readonly String GENERATE_TABLE_SCRIPT = "generatetablescript";
	protected static readonly String GENERATE_INSERT_STORED_PROC_SCRIPT = "generateinsertstoredprocscript";
	protected static readonly String GENERATE_UPDATE_STORED_PROC_SCRIPT = "generateupdatestoredprocscript";
	protected static readonly String GENERATE_DELETE_STORED_PROC_SCRIPT = "generatedeletestoredprocscript";
	protected static readonly String GENERATE_SELECT_STORED_PROC_SCRIPT = "generateselectstoredprocscript";
	protected static readonly String ALLOW_INSERT = "allowinsert";
	protected static readonly String ALLOW_UPDATE = "allowupdate";
	protected static readonly String ALLOW_DELETE = "allowdelete";
	protected static readonly String DEFAULT_DIRTY_READ = "defaultdirtyread";
	protected static readonly String UPDATE_CHANGED_ONLY = "updatechangedonly";
	protected static readonly String SCRIPT_DROP_STATEMENT = "scriptdropstatement";
	protected static readonly String USE_VIEW = "useview";
	protected static readonly String GENERATE_PROCS_FOR_FOREIGN_KEYS = "generateprocsforforeignkeys";
	protected static readonly String GENERATE_ONLY_PRIMARY_DELETE_STORED_PROC = "generateonlyprimarydeletestoredproc";
	protected static readonly String ALLOW_UPDATE_OF_PRIMARY_KEY = "allowupdateofprimarykey";
	protected static readonly String COMMAND_TIMEOUT = "commandtimeout";
	protected static readonly String SCRIPT_FOR_INDEXED_VIEWS = "scriptforindexedviews";
	protected static readonly String AUDIT = "audit";
			    
	protected String key = "ConnectionString";
	protected String server = String.Empty;
	protected String database = String.Empty;
	protected String user = String.Empty;
	protected String password = String.Empty;
	protected String sqlScriptDirectory = "Sql";
	protected String storedProcNameFormat = String.Empty;
	protected Boolean singleFile = false;
	protected Boolean generateSqlViewScripts = false;
	protected Boolean generateSqlTableScripts = false;
	protected Boolean useView = true;
	protected Boolean scriptDropStatement = true;
	protected Boolean generateProcsForForeignKey = false;
	protected Boolean generateInsertStoredProcScript = false;
	protected Boolean generateUpdateStoredProcScript = false;
	protected Boolean generateDeleteStoredProcScript = false;
	protected Boolean generateSelectStoredProcScript = false;
	protected Boolean allowInsert = false;
	protected Boolean allowUpdate = false;
	protected Boolean allowDelete = false;
	protected Boolean defaultDirtyRead = false;
	protected Boolean updateChangedOnly = false;
	protected Boolean generateOnlyPrimaryDeleteStoredProc = true;
	protected Boolean allowUpdateOfPrimaryKey = false;
	protected Boolean autoDiscoverEntities = true;
	protected Boolean autoDiscoverProperties = true;
	protected Boolean autoDiscoverAttributes = true;
	protected Int32 commandTimeout = 15;
	protected Boolean scriptForIndexedViews = false;
	protected Boolean audit = false;

	public String Key {
	    get { return this.key; }
	    set { this.key = value; }
	}

	public String Server {
	    get { return this.server; }
	    set { this.server = value; }
	}

	public String Database {
	    get { return this.database; }
	    set { this.database = value; }
	}

	public String User {
	    get { return this.user; }
	    set { this.user = value; }
	}

	public String Password {
	    get { return this.password; }
	    set { this.password = value; }
	}

	public String SqlScriptDirectory {
	    get { return this.sqlScriptDirectory; }
	    set { this.sqlScriptDirectory = value; }
	}

	public String StoredProcNameFormat {
	    get { return this.storedProcNameFormat; }
	    set { this.storedProcNameFormat = value; }
	}

	public Boolean SingleFile {
	    get { return this.singleFile; }
	    set { this.singleFile = value; }
	}

	public Boolean GenerateSqlViewScripts {
	    get { return this.generateSqlViewScripts; }
	    set { this.generateSqlViewScripts = value; }
	}

	public Boolean GenerateSqlTableScripts {
	    get { return this.generateSqlTableScripts; }
	    set { this.generateSqlTableScripts = value; }
	}

	public Boolean UseView {
	    get { return this.useView; }
	    set { this.useView = value; }
	}

	public Boolean ScriptDropStatement {
	    get { return this.scriptDropStatement; }
	    set { this.scriptDropStatement = value; }
	}

	public Boolean GenerateProcsForForeignKey {
	    get { return this.generateProcsForForeignKey; }
	    set { this.generateProcsForForeignKey = value; }
	}

	public Boolean GenerateInsertStoredProcScript {
	    get { return this.generateInsertStoredProcScript; }
	    set { this.generateInsertStoredProcScript = value; }
	}
	public Boolean GenerateUpdateStoredProcScript {
	    get { return this.generateUpdateStoredProcScript; }
	    set { this.generateUpdateStoredProcScript = value; }
	}
	public Boolean GenerateDeleteStoredProcScript {
	    get { return this.generateDeleteStoredProcScript; }
	    set { this.generateDeleteStoredProcScript = value; }
	}
	public Boolean GenerateSelectStoredProcScript {
	    get { return this.generateSelectStoredProcScript; }
	    set { this.generateSelectStoredProcScript = value; }
	}

	public Boolean AllowInsert 
	{
	    get { return this.allowInsert; }
	    set { this.allowInsert = value; }
	}
	public Boolean AllowUpdate 
	{
	    get { return this.allowUpdate; }
	    set { this.allowUpdate = value; }
	}
	public Boolean AllowDelete 
	{
	    get { return this.allowDelete; }
	    set { this.allowDelete = value; }
	}
	public Boolean DefaultDirtyRead
	{
	    get { return this.defaultDirtyRead; }
	    set { this.defaultDirtyRead = value; }
	}
	public Boolean UpdateChangedOnly
	{
	    get { return this.updateChangedOnly; }
	    set { this.updateChangedOnly = value; }
	}

	public Boolean GenerateOnlyPrimaryDeleteStoredProc {
	    get { return this.generateOnlyPrimaryDeleteStoredProc; }
	    set { this.generateOnlyPrimaryDeleteStoredProc = value; }
	}

	public Boolean AllowUpdateOfPrimaryKey {
	    get { return this.allowUpdateOfPrimaryKey; }
	    set { this.allowUpdateOfPrimaryKey = value; }
	}

	public Boolean AutoDiscoverEntities {
	    get { return this.autoDiscoverEntities; }
	    set { this.autoDiscoverEntities = value; }
	}

	public Boolean AutoDiscoverProperties {
	    get { return this.autoDiscoverProperties; }
	    set { this.autoDiscoverProperties = value; }
	}

	public Boolean AutoDiscoverAttributes {
	    get { return this.autoDiscoverAttributes; }
	    set { this.autoDiscoverAttributes = value; }
	}

	public Int32 CommandTimeout {
	    get { return this.commandTimeout; }
	    set { this.commandTimeout = value; }
	}

	public Boolean ScriptForIndexedViews {
	    get { return this.scriptForIndexedViews; }
	    set { this.scriptForIndexedViews = value; }
	}

	public Boolean Audit {
	    get { return this.audit; }
	    set { this.audit = value; }
	}

	public String ConnectionString {
	    get { 			
		StringBuilder objStringBuilder = new StringBuilder(255);
		objStringBuilder.Append("Data Source = " + server + ";");
		objStringBuilder.Append("Initial Catalog = " + database + ";");
		objStringBuilder.Append("User ID = " + user + ";");
		objStringBuilder.Append("Password = " + password + ";");
		return objStringBuilder.ToString();
	    }
	}

    }
}
