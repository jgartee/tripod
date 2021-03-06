﻿using System;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Should;
using Xunit;
using Xunit.Extensions;

namespace Tripod.Domain.Security
{
    public class MustNotContainInvalidUserNameTextTests : FluentValidationTests
    {
        [Theory]
        [InlineData("asdf&asdf")]
        [InlineData("a(*^sdf")]
        [InlineData("asdf\r\nasdf")]
        public void IsInvalid_WhenUserName_ContainsUnallowedCharacters(string userName)
        {
            var command = new FakeMustNotContainInvalidUserNameTextCommand
            {
                UserName = userName,
            };
            var validator = new FakeMustNotContainInvalidUserNameTextValidator();

            var result = validator.Validate(command);

            result.IsValid.ShouldBeFalse();
            Func<ValidationFailure, bool> userNameError = x => x.PropertyName == command.PropertyName(y => y.UserName);
            result.Errors.Count(userNameError).ShouldEqual(1);
            result.Errors.Single(userNameError).ErrorMessage.ShouldEqual(Resources.Validation_UserName_AllowedCharacters
                .Replace("{PropertyName}", User.Constraints.NameLabel)
            );
            validator.ShouldHaveValidationErrorFor(x => x.UserName, command.UserName);
        }

        [Fact]
        public void IsValid_WhenUserName_IsEmailAddress()
        {
            var userName = FakeData.Email();
            var command = new FakeMustNotContainInvalidUserNameTextCommand
            {
                UserName = userName,
            };
            var validator = new FakeMustNotContainInvalidUserNameTextValidator();

            var result = validator.Validate(command);

            result.IsValid.ShouldBeTrue();
            validator.ShouldNotHaveValidationErrorFor(x => x.UserName, command.UserName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsValid_WhenUserName_IsEmpty(string userName)
        {
            var command = new FakeMustNotContainInvalidUserNameTextCommand
            {
                UserName = userName,
            };
            var validator = new FakeMustNotContainInvalidUserNameTextValidator();

            var result = validator.Validate(command);

            result.IsValid.ShouldBeTrue();
            validator.ShouldNotHaveValidationErrorFor(x => x.UserName, command.UserName);
        }
    }

    public class FakeMustNotContainInvalidUserNameTextCommand
    {
        public string UserName { get; set; }
    }

    public class FakeMustNotContainInvalidUserNameTextValidator : AbstractValidator<FakeMustNotContainInvalidUserNameTextCommand>
    {
        public FakeMustNotContainInvalidUserNameTextValidator()
        {
            RuleFor(x => x.UserName)
                .MustNotContainInvalidUserNameText()
                .WithName(User.Constraints.NameLabel)
            ;
        }
    }
}
