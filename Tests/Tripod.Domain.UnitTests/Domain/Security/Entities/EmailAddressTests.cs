﻿using Should;
using Xunit;

namespace Tripod.Domain.Security
{
    public class EmailAddressTests
    {
        [Fact]
        public void Ctor_InitializesNothing()
        {
            var entity = new EmailAddress();
            entity.Id.ShouldEqual(0);
            entity.User.ShouldBeNull();
            entity.UserId.ShouldBeNull();
            entity.Value.ShouldBeNull();
            entity.IsPrimary.ShouldBeFalse();
            entity.IsVerified.ShouldBeFalse();
        }
    }
}
