using System;

using Spring2.DataTierGenerator.Attribute;

namespace StampinUp.DataObject
{

    /// <summary>
    /// EmployeeOtherControlsSubscriptionsViewData generic collection
    /// </summary>
    public class EmployeeOtherControlsSubscriptionsViewList : System.Collections.CollectionBase
    {

	[Generate]
	public static readonly EmployeeOtherControlsSubscriptionsViewList UNSET = new EmployeeOtherControlsSubscriptionsViewList(true);
	[Generate]
	public static readonly EmployeeOtherControlsSubscriptionsViewList DEFAULT = new EmployeeOtherControlsSubscriptionsViewList(true);

	[Generate]
	private Boolean immutable = false;

	[Generate]
	private EmployeeOtherControlsSubscriptionsViewList (Boolean immutable)
	{
	    this.immutable = immutable;
	}

	[Generate]
	public EmployeeOtherControlsSubscriptionsViewList()
	{
	}

	// Indexer implementation.
	[Generate]
	public EmployeeOtherControlsSubscriptionsViewData this[int index]
	{
	    get
	    {
		return (EmployeeOtherControlsSubscriptionsViewData) List[index];
	    }
	    set
	    {
		if (!immutable)
		{
		    List[index] = value;
		}
		else
		{
		    throw new System.Data.ReadOnlyException();
		}
	    }
	}

	[Generate]
	public void Add(EmployeeOtherControlsSubscriptionsViewData value)
	{
	    if (!immutable)
	    {
		List.Add(value);
	    }
	    else
	    {
		throw new System.Data.ReadOnlyException();
	    }
	}

	[Generate]
	public Boolean Contains(EmployeeOtherControlsSubscriptionsViewData value)
	{
	    return List.Contains(value);
	}

	[Generate]
	public Int32 IndexOf(EmployeeOtherControlsSubscriptionsViewData value)
	{
	    return List.IndexOf(value);
	}

	[Generate]
	public void Insert(Int32 index, EmployeeOtherControlsSubscriptionsViewData value)
	{
	    if (!immutable)
	    {
		List.Insert(index, value);
	    }
	    else
	    {
		throw new System.Data.ReadOnlyException();
	    }
	}

	[Generate]
	public void Remove(int index)
	{
	    if (!immutable)
	    {
		if (index > Count - 1 || index < 0)
		{
		    throw new IndexOutOfRangeException();
		}
		else
		{
		    List.RemoveAt(index);
		}
	    }
	    else
	    {
		throw new System.Data.ReadOnlyException();
	    }
	}

	[Generate]
	public void Remove(EmployeeOtherControlsSubscriptionsViewData value)
	{
	    if (!immutable)
	    {
		List.Remove(value);
	    }
	    else
	    {
		throw new System.Data.ReadOnlyException();
	    }
	}

	[Generate]
	public void AddRange(System.Collections.IList list)
	{
	    foreach(Object o in list)
	    {
		if (o is EmployeeOtherControlsSubscriptionsViewData)
		{
		    Add((EmployeeOtherControlsSubscriptionsViewData)o);
		}
		else
		{
		    throw new System.InvalidCastException("object in list could not be cast to EmployeeOtherControlsSubscriptionsViewData");
		}
	    }
	}

	[Generate]
	public Boolean IsDefault
	{
	    get
	    {
		return Object.ReferenceEquals(this, DEFAULT);
	    }
	}

	[Generate]
	public Boolean IsUnset
	{
	    get
	    {
		return Object.ReferenceEquals(this, UNSET);
	    }
	}

	[Generate]
	public Boolean IsValid
	{
	    get
	    {
		return !(IsDefault || IsUnset);
	    }
	}


    }
}
