﻿namespace FtpudStreamFramework.Settings.Filters
{
    public class Deinterlace : VideoFilter
    {
        public override string GetFilterCommandLine()
        {
            return "yadif";
        }
    }
}