//
//  Content Library
//  ----------------------------------------------------------------------
//  This file is part of the C-Sharp Content Library, a content formatting, 
//  validation, and sanitation library created in C#. 
//
//  Classname : Validate
//  Version   : 1.0.0-Dev.5
//  Github URL: https://github.com/jamesgober/C-Sharp-Content-Library
//
//  Author(s) : jamesgober [https://jamesgober.com]
//
//  License   : GNU General Public License v3.0; (SEE LICENSE FILE)
//  ----------------------------------------------------------------------
//  Copyright (c) 2023 JamesGober.com
//
using System;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Internal;
namespace Content.Lib
{

    /// <summary>
    ///     Content validation class
    ///     ID string generated is "T:Content.Lib.Validate".
    /// </summary>
    /// <see href="https://github.com/jamesgober/C-Sharp-Content-Library">View on Github</see>
	public class Validate : Content
    {

        /* Name (boolean)
        ************************************************************/
        /// <summary>
        ///      Verifies that the input is a valid name format.
        ///      ID string generated is "M:Content.Lib.Validate.Name(System.String, System.Boolean)".
        /// </summary>
        /// <param name="name">Name to validate.</param>
        /// <param name="allowChars">Allow special charactrs and accents.</param>
        /// <returns>Returns True if name is valid, returns False otherwise.</returns>
        public static bool Name(string name, bool allowChars = true)
        {
            if (("string" == DataType(name)) && (false == Empty(name)))
            {
                Regex regex = new Regex(((true == allowChars) ? (@"^(?!$)\p{L}+[a-zA-Z]*['-]*\p{L}+[a-zA-Z]*$") : (@"^(?!$)[a-zA-Z]*$")));
                return regex.IsMatch(name);
            }
            return false;
        }


        /* Email (boolean)
        ************************************************************/
        /// <summary>
        ///      Verifies that the input is a valid email format.
        ///      ID string generated is "M:Content.Lib.Validate.Email(System.String)".
        /// </summary>
        /// <param name="email">Email to validate.</param>
        /// <returns>Returns True if email is valid, returns False otherwise.</returns>
        public static bool Email(string email)
        {
            email = email.Trim();
            if ((email.EndsWith(".") == false) && (email.EndsWith(" ") == false))
            {
                try
                {
                    var addr = new MailAddress(email);
                    return ((addr.User.Length <= 64) && ((addr.Address == email)) ? true : false);
                }
                catch{
                    return false;
                }
            }
            return false;
        }


        /* In Range (boolean)
        ************************************************************/
        /// <summary>
        ///      Determines whether a numeric value is within the defined range.
        ///      ID string generated is "M:Content.Lib.Validate.InRange(System.Int, System.Int, System.Int)".
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <param name="min">The minimum/lowest valid number in the range.</param>
        /// <param name="max">The maximm/highest valid number in the range.</param>
        /// <returns>Returns True if number is in range, returns False otherwise.</returns>
        /// <remarks>
        ///     Verifies that the provided <paramref name="number"/> value is greater than <paramref name="min"/>
        ///     and less than <paramref name="max"/>.
        /// </remarks>
        public static bool InRange(int number, int min = 0, int max = 100)
        {
            return (((max > min) && (number >= min) && (number <= max)) ? true : false);
        }


	}
}

