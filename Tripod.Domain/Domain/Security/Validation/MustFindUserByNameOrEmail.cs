﻿using System;
using FluentValidation;
using FluentValidation.Validators;

namespace Tripod.Domain.Security
{
    public class MustFindUserByNameOrEmail : PropertyValidator
    {
        private readonly IProcessQueries _queries;

        internal MustFindUserByNameOrEmail(IProcessQueries queries)
            : base(() => Resources.Validation_CouldNotFind)
        {
            if (queries == null) throw new ArgumentNullException("queries");
            _queries = queries;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var nameOrEmail = (string)context.PropertyValue;
            if (string.IsNullOrWhiteSpace(nameOrEmail)) return false;

            var entity = _queries.Execute(new UserBy(nameOrEmail)).Result;
            return entity != null;
        }
    }

    public static class MustFindUserByNameOrEmailExtensions
    {
        public static IRuleBuilderOptions<T, string> MustFindUserByNameOrEmail<T>
            (this IRuleBuilder<T, string> ruleBuilder, IProcessQueries queries)
        {
            return ruleBuilder.SetValidator(new MustFindUserByNameOrEmail(queries));
        }
    }
}