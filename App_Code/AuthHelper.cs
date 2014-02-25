using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using Microsoft.Ajax.Utilities;

/// <summary>
/// Simple static helper to provide username/password to the example app.
/// Fill in your own username / password here.
/// </summary>
public class AuthHelper
{
    /// <summary>
    /// Edit this value with your Previews API username
    /// </summary>
    public static string ApiUsername = "";
    /// <summary>
    /// Edit this value with your Previews API password
    /// </summary>
    public static string ApiPassword = "";

    static AuthHelper()
    {
        if (ApiUsername.IsEmpty() || ApiPassword.IsEmpty())
            throw new Exception("Please make sure to edit /App_Code/AuthHelper.cs to provide your litmus username and password");
    }
}