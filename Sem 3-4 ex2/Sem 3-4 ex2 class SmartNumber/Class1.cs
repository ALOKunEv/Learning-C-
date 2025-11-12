using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sem_3_4_ex2_class_SmartNumber
{
    public class SmartNumber
    {
        public double _value { get; private set; }

        //Переопределение операторов
        public static SmartNumber operator +(SmartNumber left, SmartNumber right)
        {
            return new SmartNumber(left._value + right._value);
        }
        public static SmartNumber operator -(SmartNumber left, SmartNumber right)
        {
            return new SmartNumber(left._value - right._value);
        }
        public static SmartNumber operator *(SmartNumber left, SmartNumber right)
        {
            return new SmartNumber(left._value * right._value);
        }
        public static SmartNumber operator /(SmartNumber left, SmartNumber right)
        {
            return new SmartNumber(left._value / right._value);
        }
        public static bool operator ==(SmartNumber left, SmartNumber right)
        {
            return left._value == right._value;
        }
        public static bool operator !=(SmartNumber left, SmartNumber right)
        {
            return left._value != right._value;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Приведение Implicit
        public static implicit operator SmartNumber(int num) =>
            new SmartNumber(num);
        public static implicit operator SmartNumber(double num) =>
            new SmartNumber(num);


        //Explicit
        public static explicit operator int(SmartNumber num) =>
            (int)num._value;

        public static explicit operator double(SmartNumber num) =>
            (double)num._value;

        public static explicit operator decimal(SmartNumber num) =>
            (decimal)num._value;
        public static explicit operator SmartNumber(string? str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (!double.TryParse(str, out double value)) {
                throw new ArgumentException("Неверный формат");
            }
            return new SmartNumber(value);
        }
        public static implicit operator String(SmartNumber num)
        {
            return num._value.ToString();
        }
            
        

        public SmartNumber(double _value)
        {
            this._value = _value;
        }
    }
}
