using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace MauiTabbedApp
{
	/// <summary>
	/// Custom card control.
	/// </summary>
	public class Card : Border
    {
        /// <summary>
		/// Initializes a new instance of <see cref="Card"/>.
		/// </summary>
        public Card() : base()
        {
            this.Padding = 15;
            this.StrokeThickness = 0;

            // HACK-014 
            //this.Shadow = new Shadow
            //{
            //    Brush = Colors.Black,
            //    Opacity = 0.16f,
            //    Offset = new Point(0, 0.5),
            //    Radius = 2
            //};

            this.StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(12)
            };
        }
    }
}