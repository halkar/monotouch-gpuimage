using System;
using ObjCRuntime;

[assembly: LinkWith ("libGPUImage.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, Frameworks = "CoreMedia CoreVideo OpenGLES AVFoundation QuartzCore")]
