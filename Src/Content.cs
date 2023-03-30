//  
//  Content Library
//  ----------------------------------------------------------------------
//  This file is part of the C-Sharp Content Library, a content formatting, 
//  validation, and sanitation library created in C#. 
//
//  Classname : Content
//  Version   : 1.0.0-Dev.5
//  Github URL: https://github.com/jamesgober/C-Sharp-Content-Library
// 
//  Author(s) : James Gober [https://jamesgober.com]
//  
//  License   : GNU General Public License v3.0; (SEE LICENSE FILE)
//  ----------------------------------------------------------------------
//  Copyright (C) 2023 JamesGober.com
//
using System;
namespace Content.Lib
{

    /// <summary>
    ///     The core utility class for the Content Library.
    ///     ID string generated is "T:Content.Lib.Content".
    /// </summary>
    /// <see href="https://github.com/jamesgober/C-Sharp-Content-Library">View on Github</see>
    public class Content
    {


        /// <summary>
        /// Library version.
        /// ID string generated is "F:Content.Lib.Content.version".
        /// </summary>
        private string version = "1.0.0-Dev.5";



        /* Get Version (string)
        ************************************************************/
        /// <summary>
        ///      Return library version.
        ///      ID string generated is "M:Content.Lib.Content.GetVersion()".
        /// </summary>
        /// <returns>Returns library version number.</returns>
        public string GetVersion() { return version; }



        /* IS SET (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the string is null empty.
        ///      ID string generated is "M:Content.Lib.Content.Isset(System.String)".
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Returns True if input is null or empty, returns False otherwise.</returns>
        public bool Isset(string input) { return string.IsNullOrEmpty(input); }



        /* EMPTY (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the string is empty.
        ///      ID string generated is "M:Content.Lib.Content.Empty(System.String)".
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Returns True if input string is empty, returns False otherwise.</returns>
        public bool Empty(string input) { return string.IsNullOrWhiteSpace(input); }



        /* DATA TYPE (string)
        ************************************************************/
        /// <summary>
        ///      Get the data type for the input value.
        ///      ID string generated is "M:Content.Lib.Content.DataType(System.Object)".
        /// </summary>
        /// <param name="value">Input value.</param>
        /// <returns>Returns the data type name as string.</returns>
        /// <remarks>
        ///     Overflow methods (16) for each data type that include:
        ///     Sbyte, Byte, Short, UShort, Int, UInt, Long, ULong, Float, Double, Decimal, Bool, Char, String, and Object.
        ///     Forced type matching will return the name of the type.
        /// </remarks>
        public string DataType(sbyte value) { return "byte"; }
        public string DataType(byte value) { return "byte"; }
        public string DataType(short value) { return "short"; }
        public string DataType(ushort value) { return "short"; }
        public string DataType(int value) { return "int"; }
        public string DataType(uint value) { return "int"; }
        public string DataType(long value) { return "long"; }
        public string DataType(ulong value) { return "long"; }
        public string DataType(float value) { return "float"; }
        public string DataType(double value) { return "double"; }
        public string DataType(decimal value) { return "decimal"; }
        public string DataType(bool value) { return "bool"; }
        public string DataType(char value) { return "char"; }
        public string DataType(string value) { return "string"; }
        public string DataType(Object value) { return "object"; }
        public string DataType() { return "null"; }



        /* IS NUMBER (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a byte.
        ///      ID string generated is "M:Content.Lib.Content.IsNumber(System.Dynamic)".
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>Returns True if value data type is numerical, returns False otherwise.</returns>
        /// <remarks>
        ///     Overflow methods (9) for each data type both signed and unsigned.
        ///     If the inputted value's data type matches Byte, Short, Int, or Long, this method returns true.
        /// </remarks>
        public  bool IsNumber(sbyte value) { return true; }
        public  bool IsNumber(byte value) { return true; }
        public  bool IsNumber(short value) { return true; }
        public  bool IsNumber(ushort value) { return true; }
        public  bool IsNumber(int value) { return true; }
        public  bool IsNumber(uint value) { return true; }
        public  bool IsNumber(long value) { return true; }
        public  bool IsNumber(ulong value) { return true; }
        public  bool IsNumber(dynamic value) { return false; }


        /* IS BYTE (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a byte.
        ///      ID string generated is "M:Content.Lib.Content.IsByte(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is byte, returns False otherwise.</returns>
        public  bool IsByte(dynamic input) { return ("byte" == DataType(input)) ? true : false; }



        /* IS SHORT (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a short.
        ///      ID string generated is "M:Content.Lib.Content.IsShort(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is short, returns False otherwise.</returns>
        public  bool IsShort(dynamic input) { return ("short" == DataType(input)) ? true : false; }



        /* IS INT (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a integer.
        ///      ID string generated is "M:Content.Lib.Content.IsInt(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is integer, returns False otherwise.</returns>
        public  bool IsInt(dynamic input) { return ("int" == DataType(input)) ? true : false; }



        /* IS LONG (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a long.
        ///      ID string generated is "M:Content.Lib.Content.IsLong(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is long, returns False otherwise.</returns>
        public  bool IsLong(dynamic input) { return ("long" == DataType(input)) ? true : false; }



        /* IS FLOAT (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a float.
        ///      ID string generated is "M:Content.Lib.Content.IsFloat(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is float, returns False otherwise.</returns>
        public  bool IsFloat(dynamic input) { return ("float" == DataType(input)) ? true : false; }



        /* IS DOUBLE (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a double.
        ///      ID string generated is "M:Content.Lib.Content.IsDouble(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is double, returns False otherwise.</returns>
        public  bool IsDouble(dynamic input) { return ("double" == DataType(input)) ? true : false; }



        /* IS DECIMAL (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a decimal.
        ///      ID string generated is "M:Content.Lib.Content.IsDecimal(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is decimal, returns False otherwise.</returns>
        public  bool IsDecimal(dynamic input) { return ("decimal" == DataType(input)) ? true : false; }



        /* IS BOOL (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a boolean.
        ///      ID string generated is "M:Content.Lib.Content.IsBool(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is boolean, returns False otherwise.</returns>
        public  bool IsBool(dynamic input) { return ("bool" == DataType(input)) ? true : false; }



        /* IS CHAR (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a char.
        ///      ID string generated is "M:Content.Lib.Content.IsChar(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is char, returns False otherwise.</returns>
        public  bool IsChar(dynamic input) { return ("char" == DataType(input)) ? true : false; }



        /* IS STRING (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a string.
        ///      ID string generated is "M:Content.Lib.Content.IsString(System.Dynamic)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is string, returns False otherwise.</returns>
        public  bool IsString(dynamic input) { return ("string" == DataType(input)) ? true : false; }



        /* IS OBJECT (boolean)
        ************************************************************/
        /// <summary>
        ///      Check if the input variable type is a object.
        ///      ID string generated is "M:Content.Lib.Content.IsObject(System.Object)".
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Returns True if input data type is object, returns False otherwise.</returns>
        public  bool IsObject(Object input) { return ("object" == DataType(input)) ? true : false; }



    }

}