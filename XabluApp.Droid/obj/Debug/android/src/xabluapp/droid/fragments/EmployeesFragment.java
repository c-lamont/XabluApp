package xabluapp.droid.fragments;


public class EmployeesFragment
	extends md5f7cb7a2ff636e30e7a6d290df6f6b60b.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XabluApp.Droid.Fragments.EmployeesFragment, XabluApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EmployeesFragment.class, __md_methods);
	}


	public EmployeesFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EmployeesFragment.class)
			mono.android.TypeManager.Activate ("XabluApp.Droid.Fragments.EmployeesFragment, XabluApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
