﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

public partial class Test3D : Window
{
    public Test3D()
    {
        InitializeComponent();
        CompositionTarget.Rendering += CompositionTarget_Rendering;
    }

    static TimeSpan lastRenderTime = new TimeSpan();

    void CompositionTarget_Rendering(object sender, EventArgs e)
    {
        if (lastRenderTime == ((RenderingEventArgs)e).RenderingTime)
            return;

        lastRenderTime = ((RenderingEventArgs)e).RenderingTime;

        GeneralTransform2DTo3D transform = TestButton.TransformToAncestor(Container);
        Point3D point = transform.Transform(new Point(0, 0));

        cube_translation.OffsetX = point.X;
        cube_translation.OffsetY = point.Y;
        cube_translation.OffsetZ = point.Z;
    }
}