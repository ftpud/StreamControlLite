﻿using System;

namespace FtpudStreamFramework.Settings.Encoders
{
    public class BaseAudioEncoder
    {
        public virtual String GetEncoderCommandLine()
        {
            throw new NotImplementedException();
        }
    }
}