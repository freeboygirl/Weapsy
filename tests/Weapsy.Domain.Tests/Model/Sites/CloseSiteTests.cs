﻿using System.Linq;
using NUnit.Framework;
using Weapsy.Domain.Model.Sites;
using Weapsy.Domain.Model.Sites.Events;
using System;

namespace Weapsy.Domain.Tests.Sites
{
    [TestFixture]
    public class CloseSiteTests
    {
        [Test]
        public void Should_throw_exception_when_already_closed()
        {
            var site = new Site();

            site.Close();
            
            Assert.Throws<Exception>(() => site.Close());
        }

        [Test]
        public void Should_set_site_status_to_closed()
        {
            var site = new Site();

            site.Close();

            Assert.AreEqual(true, site.Status == SiteStatus.Closed);
        }

        [Test]
        public void Should_add_site_closed_event()
        {
            var site = new Site();

            site.Close();

            var @event = site.Events.OfType<SiteClosed>().SingleOrDefault();

            Assert.IsNotNull(@event);
        }

        [Test]
        public void Should_set_id_in_site_closed_event()
        {
            var site = new Site();

            site.Close();

            var @event = site.Events.OfType<SiteClosed>().SingleOrDefault();

            Assert.AreEqual(site.Id, @event.AggregateRootId);
        }
    }
}
