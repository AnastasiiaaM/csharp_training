﻿using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace addressbook_tests_white
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [SetUp]
        public void SetupAppGroupRemovalTest()
        {
            app.Groups.CheckGroupExist();
        }

        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);

            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
