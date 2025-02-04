﻿using System;
using FtpudStreamFramework.Settings.Filters;

namespace FtpudStreamFramework.Settings
{
    public class CommandLineHelper
    {
        public static String WrapInput(String input)
        {
            String init = StreamSettings.VideoEncoder.GetEncoderInitCommand();
            String videoCodec = StreamSettings.VideoEncoder.GetEncoderCommandLine();
            String audioCodec = StreamSettings.AudioEncoder.GetEncoderCommandLine();
            String filters = $" -vf \"{Decorator.instance().GetCommandLine()}\" ";
            string otherOptions = " -vsync 1 -async 1  -flags low_delay -strict strict -avioflags direct -fflags +discardcorrupt -probesize 32 -analyzeduration 0 -movflags +faststart -bsf:v h264_mp4toannexb ";
            return $"-re -loglevel error {init} {input} {videoCodec} {audioCodec} {filters} {otherOptions} -f flv tcp://127.0.0.1:{StreamSettings.InternalCommunicationPort}";
        }
    }
}