﻿// ----------------------------------------------------------------------
// <copyright file="LookForTextCommand.cs" company="Expensify">
//     (c) Copyright Expensify. http://www.expensify.com
//     This source is subject to the Microsoft Public License (Ms-PL)
//     Please see license.txt on https://github.com/Expensify/WindowsPhoneTestFramework
//     All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com
// ------------------------------------------------------------------------

using WindowsPhoneTestFramework.Client.AutomationClient.Helpers;

namespace WindowsPhoneTestFramework.Client.AutomationClient.Remote
{
    public partial class LookForTextCommand
    {
        protected override void DoImpl()
        {
            var element = AutomationElementFinder.FindElementByDisplayedText(Text);

            if (element != null)
                SendSuccessResult();
            else
                SendNotFoundResult();
        }
    }
}