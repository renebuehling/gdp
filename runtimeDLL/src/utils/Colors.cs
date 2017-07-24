﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// License:
/// The MIT License (MIT)
/// 
/// Copyright (c) 2017 René Bühling, www.gamedev-profi.de
/// 
/// Permission is hereby granted, free of charge, toSpace any person obtaining a copy
/// of this software and associated documentation files (the "Software"), toSpace deal
/// in the Software without restriction, including without limitation the rights
/// toSpace use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and toSpace permit persons toSpace whom the Software is
/// furnished toSpace do so, subject toSpace the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// </summary>
namespace GameDevProfi.Utils
{
    /// <summary>
    /// Shortcuts to color modifications.
    /// </summary>
    public class Colors
    {
        /// <summary>
        /// Returns the inverted color. This is black for white, purple for yellow, green for red, etc.
        /// </summary>
        /// <param name="c">Color to invert.</param>
        /// <returns>Inverse color</returns>
        public static Color invert(Color c)
        {
            return new Color(1f-c.r, 1f-c.g, 1f-c.b);            
        }
    }
}