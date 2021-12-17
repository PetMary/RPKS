using System;
using System.Globalization;
using System.Windows;
using Petrova.WPF.MVVM.Core;

namespace Petrova.WPF.MVVM
{
    public sealed class ArithmeticConverter : MultiConverterBase<ArithmeticConverter>
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(parameter is string operation))
            {
                throw new ArgumentException("parameter must be type string", nameof(parameter));
            }

            if (values.Length != 2)
            {
                throw new ArgumentException("the number of arguments must be 2", nameof(values));
            }

            if (values[0] == DependencyProperty.UnsetValue ||
                values[1] == DependencyProperty.UnsetValue)
            {
                return DependencyProperty.UnsetValue;
            }

            var left_param = (dynamic)values[0];
            var right_param = (dynamic)values[1];

            switch (operation)
            {
                case "+":
                    return left_param + right_param;
                case "-":
                    return left_param - right_param;
                case "*":
                    return left_param * right_param;
                case "/":
                    return left_param / right_param;
                case "%":
                    return left_param % right_param;
                default:
                    throw new ArgumentException("wrong operation", nameof(parameter));
            }
        }

    }

}