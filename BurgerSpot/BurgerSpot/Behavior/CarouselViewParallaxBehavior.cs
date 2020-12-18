using System;
using System.Linq;
using BurgerSpot.Behavior;
using BurgerSpot.ViewModel;
using BurgerSpot.Model;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms;


namespace BurgerSpot.Behavior
{
    public class CarouselViewParallaxBehavior : Behavior<Xamarin.Forms.CarouselView>
    {
        public static readonly BindableProperty ParallaxOffsetProperty =
          BindableProperty.Create(nameof(ParallaxOffset), typeof(double), typeof(CarouselViewParallaxBehavior), 200.0d,
              BindingMode.TwoWay, null);

        public double ParallaxOffset
        {
            
            get { return (double)GetValue(ParallaxOffsetProperty); }
            set { SetValue(ParallaxOffsetProperty, value); }
        }

        protected override void OnAttachedTo(Xamarin.Forms.CarouselView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Scrolled += new EventHandler<ItemsViewScrolledEventArgs>(OnScrolled);
        }

        protected override void OnDetachingFrom(Xamarin.Forms.CarouselView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.Scrolled -= new EventHandler<ItemsViewScrolledEventArgs>(OnScrolled);
        }

        private void OnScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            Xamarin.Forms.CarouselView v = new Xamarin.Forms.CarouselView();
            var carousel = (Xamarin.Forms.CarouselView)sender;
            var carouselItems = carousel.ItemsSource.Cast<object>().ToList();
            var currentIndex = e.CenterItemIndex;
            var lastIndex = e.LastVisibleItemIndex;
            var layout = carousel.ItemsLayout;
            var adjust = Device.RuntimePlatform == Device.Android ? 3 : 1;

            /*
            if (layout is Xamarin.Forms.CarouselView.li listItemsLayout)
            {
                if (listItemsLayout.Orientation == ItemsLayoutOrientation.Horizontal)
                {
                    var carouselWidth = carousel.Width;
                    var offset = (carouselWidth * (currentIndex + 1)) - (e.HorizontalOffset / adjust);
                    var position = (offset * ParallaxOffset / carouselWidth) - ParallaxOffset;
                    var scale = (offset * 100 / carouselWidth) / 100;

                    var lastItem = carouselItems[lastIndex] as CarouselItem;
                    lastItem.Position = position + ParallaxOffset;
                    lastItem.Scale = 1 - scale;

                    var currentItem = carouselItems[currentIndex] as CarouselItem;
                    currentItem.Position = position;
                    currentItem.Scale = scale;
                }

                if (listItemsLayout.Orientation == ItemsLayoutOrientation.Vertical)
                {
                    var carouselHeight = carousel.Height;
                    var offset = (carouselHeight * (currentIndex + 1)) - (e.VerticalOffset / adjust);
                    var position = (offset * ParallaxOffset / carouselHeight) - ParallaxOffset;
                    var scale = offset * 100 / carouselHeight / 100;

                    var lastItem = carouselItems[lastIndex] as CarouselItem;
                    lastItem.Position = position + ParallaxOffset;
                    lastItem.Scale = 1 - scale;

                    var currentItem = carouselItems[currentIndex] as CarouselItem;
                    currentItem.Position = position;
                    currentItem.Scale = scale;
                }
                */
   


        }
    }
}
