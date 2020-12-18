package crc64bac9ec500e110235;


public class RoundedCornerOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("BurgerSpot.Droid.Renderers.RoundedCornerOutlineProvider, BurgerSpot.Android", RoundedCornerOutlineProvider.class, __md_methods);
	}


	public RoundedCornerOutlineProvider ()
	{
		super ();
		if (getClass () == RoundedCornerOutlineProvider.class)
			mono.android.TypeManager.Activate ("BurgerSpot.Droid.Renderers.RoundedCornerOutlineProvider, BurgerSpot.Android", "", this, new java.lang.Object[] {  });
	}

	public RoundedCornerOutlineProvider (float p0, int p1)
	{
		super ();
		if (getClass () == RoundedCornerOutlineProvider.class)
			mono.android.TypeManager.Activate ("BurgerSpot.Droid.Renderers.RoundedCornerOutlineProvider, BurgerSpot.Android", "System.Single, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

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
