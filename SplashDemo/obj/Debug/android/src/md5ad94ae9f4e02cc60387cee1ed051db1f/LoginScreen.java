package md5ad94ae9f4e02cc60387cee1ed051db1f;


public class LoginScreen
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SplashAndroide.LoginScreen, SplashDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LoginScreen.class, __md_methods);
	}


	public LoginScreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LoginScreen.class)
			mono.android.TypeManager.Activate ("SplashAndroide.LoginScreen, SplashDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
