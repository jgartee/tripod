﻿using System;
using FluentValidation;
using FluentValidation.Validators;

namespace Tripod
{
    public class MinLength : PropertyValidator
    {
        private readonly int _minLength;

        internal MinLength(int minLength) : base(() => ValidationResources.Validation_MinLength)
        {
            if (minLength < 1) throw new ArgumentOutOfRangeException("minLength",
                ValidationResources.Exception_ArgumentOutOfRange_CannotBeLessThanOne);
            _minLength = minLength;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var text = (string)context.PropertyValue;

            // assert that text satisfies character limit
            if (text == null || text.Length >= _minLength) return true;

            context.MessageFormatter.AppendArgument("MinLength", _minLength);
            context.MessageFormatter.AppendArgument("TotalLength", text.Length);
            return false;
        }
    }

    public static class MinLengthExtensions
    {
        public static IRuleBuilderOptions<T, string> MinLength<T>
            (this IRuleBuilder<T, string> ruleBuilder, int minLength)
        {
            return ruleBuilder.SetValidator(new MinLength(minLength));
        }
    }
}
