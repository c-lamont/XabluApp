package md5d026ccbeb01179189483b91bac95cbbb;


public abstract class BaseActivity_1
	extends md5d026ccbeb01179189483b91bac95cbbb.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XabluApp.Droid.Activities.BaseActivity`1, XabluApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseActivity_1.class, __md_methods);
	}


	public BaseActivity_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseActivity_1.class)
			mono.android.TypeManager.Activate ("XabluApp.Droid.Activities.BaseActivity`1, XabluApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
