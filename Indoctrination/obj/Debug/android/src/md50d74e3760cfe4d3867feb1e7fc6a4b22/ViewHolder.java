package md50d74e3760cfe4d3867feb1e7fc6a4b22;


public class ViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Indoctrination.Menu.ViewHolder, Indoctrination, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewHolder.class, __md_methods);
	}


	public ViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ViewHolder.class)
			mono.android.TypeManager.Activate ("Indoctrination.Menu.ViewHolder, Indoctrination, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
