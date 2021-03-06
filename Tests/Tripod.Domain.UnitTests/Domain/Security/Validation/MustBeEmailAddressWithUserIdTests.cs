﻿using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Moq;
using Should;
using Xunit;

namespace Tripod.Domain.Security
{
    public class MustBeEmailAddressWithUserIdTests : FluentValidationTests
    {
        [Fact]
        public void Ctor_ThrowsArgumentNullException_WhenQueryProcessor_IsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () =>new MustBeEmailAddressWithUserId<object>(null, null));
            exception.ShouldNotBeNull();
            exception.ParamName.ShouldEqual("queries");
        }

        [Fact]
        public void Ctor_ThrowsArgumentNullException_WhenUserId_IsNull()
        {
            var queries = new Mock<IProcessQueries>(MockBehavior.Strict);
            var exception = Assert.Throws<ArgumentNullException>(
                () => new MustBeEmailAddressWithUserId<object>(queries.Object, null));
            exception.ShouldNotBeNull();
            exception.ParamName.ShouldEqual("userId");
        }

        [Fact]
        public void IsInvalid_WhenEmailAddressExists_WithDifferentUserId()
        {
            var userId = FakeData.Id();
            var otherUserId = FakeData.Id(canNotBe: userId);
            var emailAddressId = FakeData.Id();
            var queries = new Mock<IProcessQueries>(MockBehavior.Strict);
            var command = new FakeMustBeEmailAddressWithUserIdCommand
            {
                EmailAddressId = emailAddressId,
                UserId = userId,
            };
            var entity = new EmailAddress { UserId = otherUserId, };
            Expression<Func<EmailAddressBy, bool>> expectedQuery = x => x.Id == command.EmailAddressId;
            queries.Setup(x => x.Execute(It.Is(expectedQuery))).Returns(Task.FromResult(entity));
            var validator = new FakeMustBeEmailAddressWithUserIdValidator(queries.Object);

            var result = validator.Validate(command);

            result.IsValid.ShouldBeFalse();
            Func<ValidationFailure, bool> emailIdError = x => x.PropertyName == command.PropertyName(y => y.EmailAddressId);
            result.Errors.Count(emailIdError).ShouldEqual(1);
            result.Errors.Single(emailIdError).ErrorMessage.ShouldEqual(Resources.Validation_NotAuthorized_IntIdValue
                .Replace("{PropertyName}", EmailAddress.Constraints.Label.ToLower())
                .Replace("{PropertyValue}", emailAddressId.ToString(CultureInfo.InvariantCulture))
            );
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Once);
            validator.ShouldHaveValidationErrorFor(x => x.EmailAddressId, command);
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Exactly(2));
        }

        [Fact]
        public void IsValid_WhenEmailAddressExists_WithEqualUserId()
        {
            var userId = FakeData.Id();
            var emailAddressId = FakeData.Id();
            var queries = new Mock<IProcessQueries>(MockBehavior.Strict);
            var command = new FakeMustBeEmailAddressWithUserIdCommand
            {
                EmailAddressId = emailAddressId,
                UserId = userId,
            };
            var entity = new EmailAddress { UserId = userId, };
            Expression<Func<EmailAddressBy, bool>> expectedQuery = x => x.Id == command.EmailAddressId;
            queries.Setup(x => x.Execute(It.Is(expectedQuery))).Returns(Task.FromResult(entity));
            var validator = new FakeMustBeEmailAddressWithUserIdValidator(queries.Object);

            var result = validator.Validate(command);

            result.IsValid.ShouldBeTrue();
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Once);
            validator.ShouldNotHaveValidationErrorFor(x => x.EmailAddressId, command);
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Exactly(2));
        }

        [Fact]
        public void IsValid_WhenEmailAddress_DoesNotExist()
        {
            var userId = FakeData.Id();
            var emailAddressId = FakeData.Id();
            var queries = new Mock<IProcessQueries>(MockBehavior.Strict);
            var command = new FakeMustBeEmailAddressWithUserIdCommand
            {
                EmailAddressId = emailAddressId,
                UserId = userId,
            };
            Expression<Func<EmailAddressBy, bool>> expectedQuery = x => x.Id == command.EmailAddressId;
            queries.Setup(x => x.Execute(It.Is(expectedQuery))).Returns(Task.FromResult(null as EmailAddress));
            var validator = new FakeMustBeEmailAddressWithUserIdValidator(queries.Object);

            var result = validator.Validate(command);

            result.IsValid.ShouldBeTrue();
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Once);
            validator.ShouldNotHaveValidationErrorFor(x => x.EmailAddressId, command);
            queries.Verify(x => x.Execute(It.Is(expectedQuery)), Times.Exactly(2));
        }
    }

    public class FakeMustBeEmailAddressWithUserIdCommand
    {
        public int UserId { get; set; }
        public int EmailAddressId { get; set; }
    }

    public class FakeMustBeEmailAddressWithUserIdValidator : AbstractValidator<FakeMustBeEmailAddressWithUserIdCommand>
    {
        public FakeMustBeEmailAddressWithUserIdValidator(IProcessQueries queries)
        {
            RuleFor(x => x.EmailAddressId)
                .MustBeEmailAddressWithUserId(queries, x => x.UserId)
                .WithName(EmailAddress.Constraints.Label)
            ;
        }
    }
}
