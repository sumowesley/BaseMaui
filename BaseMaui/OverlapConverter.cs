using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMaui
{
    public class OverlapConverter : IMultiValueConverter
    {
        public object Convert(object[]? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is null) return false;
            if (value[0] is null) return false;
            if (value[1] is null) return false;
            if (value[0] is not View) return false;
            if (value[1] is not View) return false;

            var firstView = (View)value[0];
            var secondView = (View)value[1];

            
            Point pos1 = GetAbsolutePosition(firstView);
            Point pos2 = GetAbsolutePosition(secondView);

            return (pos1.Y < pos2.Y + secondView.Frame.Height) && (pos1.Y + firstView.Frame.Height > pos2.Y);


        }

        public object[]? ConvertBack(object? value, Type[] targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }

        public Point GetAbsolutePosition(View view)
        {
            double x = view.Frame.X;
            double y = view.Frame.Y;

            var parent = view.Parent;
            while (parent is View parentView)
            {
                x += parentView.Frame.X;
                y += parentView.Frame.Y;
                parent = parentView.Parent;
            }

            return new Point(x, y);
        }
    }
}
