﻿using System;
using OpenQA.Selenium;

namespace ParaBankFramework.Support
{
    public static class Extensions
    {
        public static bool Exists(this IWebElement element)
        {
            try
            {
                var text = element.Text;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
