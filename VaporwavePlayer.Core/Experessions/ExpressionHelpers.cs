using System;
using System.Linq.Expressions;
using System.Reflection;

namespace VaporwavePlayer.Core { 


    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expression and gets the function return value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }

        /// <summary>
        /// Sets the property to given value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            //converts the lambda
            var expression = lambda.Body as MemberExpression;

            //Get the property information so we can set it

            if (expression != null)
            {
                var propertyInfo = (PropertyInfo) expression.Member;
                var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

                //set the property value
                propertyInfo.SetValue(target, value);
            }
        }

    }
}
