using System;
using System.Drawing;
using ObjCRuntime;
using Foundation;
using UIKit;
using CoreMedia;
using CoreVideo;
using CoreGraphics;
using CoreAnimation;
using AVFoundation;

namespace MonoTouch.GpuImage
{
    // @interface GPUImageOutput : NSObject
    [BaseType (typeof(NSObject))]
    interface GPUImageOutput
    {
        // -(UIImage *)imageByFilteringImage:(UIImage *)imageToFilter;
        [Export ("imageByFilteringImage:")]
        UIImage ImageByFilteringImage (UIImage imageToFilter);
    }
    // @interface GPUImageFilterGroup : GPUImageOutput <GPUImageInput>
    [BaseType (typeof(GPUImageOutput))]
    interface GPUImageFilterGroup
    {
    }

    // @interface GPUImageAdaptiveThresholdFilter : GPUImageFilterGroup
    [BaseType (typeof(GPUImageFilterGroup))]
    interface GPUImageAdaptiveThresholdFilter
    {
        // @property (readwrite, nonatomic) CGFloat blurRadiusInPixels;
        [Export ("blurRadiusInPixels", ArgumentSemantic.Assign)]
        nfloat BlurRadiusInPixels { get; set; }
    }
}