package crc642d3db7ebc5cde2c8;


public class AppRedirectAndroid
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("botonFlotante.AppRedirectAndroid, botonFlotante.Android", AppRedirectAndroid.class, __md_methods);
	}


	public AppRedirectAndroid ()
	{
		super ();
		if (getClass () == AppRedirectAndroid.class)
			mono.android.TypeManager.Activate ("botonFlotante.AppRedirectAndroid, botonFlotante.Android", "", this, new java.lang.Object[] {  });
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
