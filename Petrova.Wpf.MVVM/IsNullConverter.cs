using System;
using System.Globalization;
using System.Windows;
using Petrova.WPF.MVVM.Core;

namespace Petrova.WPF.MVVM
{
    public sealed class IsNullConverter : ConverterBase<IsNullConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is null;
        }

    }

}
