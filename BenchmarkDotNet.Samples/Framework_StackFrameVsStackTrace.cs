﻿using System.Diagnostics;

namespace BenchmarkDotNet.Samples
{
    public class Framework_StackFrameVsStackTrace
    {
        [Benchmark]
        public StackFrame StackFrame()
        {
            return new StackFrame(1, false);
        }

        [Benchmark]
        public StackFrame StackTrace()
        {
            return new StackTrace().GetFrame(1);
        }
    }
}