﻿using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Subsonic8.Framework.Services;

namespace Client.Tests.Framework.Services
{
    [TestClass]
    public class NotificationOptionsTests
    {
        [TestMethod]
        public void TitleReturnsUnknownIfItIsSetToNull()
        {
            var options = new NotificationOptions
                              {
                                  Title = null
                              };

            options.Title.Should().Be("Unknown");
        }

        [TestMethod]
        public void TitleReturnsUnknownIfItIsSetToEmpty()
        {
            var options = new NotificationOptions
            {
                Title = string.Empty
            };

            options.Title.Should().Be("Unknown");   
        }

        [TestMethod]
        public void TitleRerturnsValueSet()
        {
            const string title = "title";
            var options = new NotificationOptions
                              {
                                  Title = title
                              };

            options.Title.Should().Be(title);
        }

        [TestMethod]
        public void SubtitleReturnsUnknownIfSetToNull()
        {
            var options = new NotificationOptions
            {
                Subtitle = null
            };

            options.Subtitle.Should().Be("Unknown");
        }

        [TestMethod]
        public void SubtitleReturnsUnknownIfSetToEmpty()
        {
            var options = new NotificationOptions
            {
                Subtitle = string.Empty
            };

            options.Subtitle.Should().Be("Unknown");
        }

        [TestMethod]
        public void SubtitleRerturnsValueSet()
        {
            const string subtitle = "subtitle";
            var options = new NotificationOptions
            {
                Subtitle = subtitle
            };

            options.Subtitle.Should().Be(subtitle);
        }
    }
}
