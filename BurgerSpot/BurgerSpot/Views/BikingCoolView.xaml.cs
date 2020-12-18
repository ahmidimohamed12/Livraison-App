using Xamanimation;
using BurgerSpot.Views;
using System;
using Xamarin.Forms;

namespace BurgerSpot.Views
{
	public partial class BikingCoolView : BurgerSpot.Views.IAnimatedView
    {
		public BikingCoolView()
		{
			InitializeComponent ();
		}

		public void StartAnimation()
		{
			if (Resources["BackgroundColorAnimation"] is ColorAnimation backgroundColorAnimation)
			{
				backgroundColorAnimation.Begin();
			}

			if (Resources["InfoPanelAnimation"] is StoryBoard animation)
			{
				animation.Begin();
			}
		}
	}
}