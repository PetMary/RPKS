using System;
using System.Globalization;
using System.Windows;
using Petrova.WPF.MVVM.Core;

namespace Petrova.WPF.MVVM
{
    public sealed class BoolConverter : ConverterBase<BoolConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var one_param = (dynamic)value;
            if (one_param is not bool)
            {
                throw new ArgumentException("argument is not bool", nameof(value));
            }
            return one_param ? "Yes" : "No";
        }

    }
}
