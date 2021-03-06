﻿using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity;
using Moq;
using Should;
using Xunit;

namespace Tripod.Domain.Security
{
    public class RemoteMembershipByUserTests
    {
        #region RemoteMembershipByUser Id

        [Fact]
        public void Query_IntCtor_SetsUserIdProperty_AndUserLoginInfoProperty()
        {
            var userId = FakeData.Id();
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var query = new RemoteMembershipByUser(userId, userLoginInfo);
            query.UserId.ShouldEqual(userId);
            query.UserName.ShouldBeNull();
            query.UserLoginInfo.ShouldEqual(userLoginInfo);
        }

        [Fact]
        public void Handler_ReturnsNullRemoteMembership_WhenUserLoginInfoIsNull_ByUserId()
        {
            var userId = FakeData.Id();
            var otherUserId = FakeData.Id(userId);
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { UserId = otherUserId, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { UserId = userId, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userId, null);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldBeNull();
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Never);
        }

        [Fact]
        public void Handler_ReturnsNullRemoteMembership_WhenNotFound_ByUserId()
        {
            var userId = FakeData.Id();
            var otherUserId = FakeData.Id(userId);
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { UserId = otherUserId, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { UserId = userId, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userId, userLoginInfo);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldBeNull();
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Once);
        }

        [Fact]
        public void Handler_ReturnsNonNullRemoteMembership_WhenFound_ByUserId()
        {
            var userId = FakeData.Id();
            var otherUserId = FakeData.Id(userId);
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { UserId = otherUserId, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { UserId = userId, },
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { UserId = userId, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userId, userLoginInfo);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldNotBeNull();
            Func<ProxiedRemoteMembership, bool> expectedRemoteMembership =
                x => x.UserId == userId &&
                    x.LoginProvider == loginProvider &&
                    x.ProviderKey == providerKey;
            result.ShouldEqual(remoteMemberships.Single(expectedRemoteMembership));
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Once);
        }

        #endregion
        #region RemoteMembershipByUser Name

        [Fact]
        public void Query_StringCtor_SetsUserNameProperty_AndUserLoginInfoProperty()
        {
            var userName = FakeData.String();
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var query = new RemoteMembershipByUser(userName, userLoginInfo);
            query.UserId.ShouldBeNull();
            query.UserName.ShouldEqual(userName);
            query.UserLoginInfo.ShouldEqual(userLoginInfo);
        }

        [Fact]
        public void Handler_ReturnsNullRemoteMembership_WhenUserLoginInfoIsNull_ByUserName()
        {
            var userName = FakeData.String();
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var user = new User { Name = userName };
            var otherUser = new User { Name = FakeData.String() };
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { User = otherUser, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { User = user, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userName, null);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldBeNull();
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Never);
        }

        [Fact]
        public void Handler_ReturnsNullRemoteMembership_WhenNotFound_ByUserName()
        {
            var userName = FakeData.String();
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var user = new User { Name = userName };
            var otherUser = new User { Name = FakeData.String() };
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { User = otherUser, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { User = user, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userName, userLoginInfo);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldBeNull();
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Once);
        }

        [Fact]
        public void Handler_ReturnsNonNullRemoteMembership_WhenFound_ByUserName()
        {
            var userName = FakeData.String();
            var loginProvider = FakeData.String();
            var providerKey = FakeData.String();
            var userLoginInfo = new UserLoginInfo(loginProvider, providerKey);
            var user = new User { Name = userName };
            var otherUser = new User { Name = FakeData.String() };
            var remoteMemberships = new[]
            {
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { User = otherUser, },
                new ProxiedRemoteMembership(FakeData.String(), FakeData.String())
                    { User = user, },
                new ProxiedRemoteMembership(loginProvider, providerKey)
                    { User = user, },
            };
            var data = remoteMemberships.AsQueryable();
            var query = new RemoteMembershipByUser(userName, userLoginInfo);
            var dbSet = new Mock<DbSet<RemoteMembership>>(MockBehavior.Strict).SetupDataAsync(data);
            var entities = new Mock<IReadEntities>(MockBehavior.Strict);
            var entitySet = new EntitySet<RemoteMembership>(dbSet.Object, entities.Object);
            entities.Setup(x => x.Query<RemoteMembership>()).Returns(entitySet);
            var handler = new HandleRemoteMembershipByUserQuery(entities.Object);

            RemoteMembership result = handler.Handle(query).Result;

            result.ShouldNotBeNull();
            Func<ProxiedRemoteMembership, bool> expectedRemoteMembership =
                x => x.User.Name == userName &&
                    x.LoginProvider == loginProvider &&
                    x.ProviderKey == providerKey;
            result.ShouldEqual(remoteMemberships.Single(expectedRemoteMembership));
            entities.Verify(x => x.Query<RemoteMembership>(), Times.Once);
        }

        #endregion
    }
}
