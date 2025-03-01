﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactGuide.Shared.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        public Result(bool success)
        {
            Success = success;
        }
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
    }
}
