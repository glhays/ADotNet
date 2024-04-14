﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace ADotNet.Models.Foundations.Files.Exceptions
{
    public class FailedFileServiceException : Xeption
    {
        public FailedFileServiceException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}