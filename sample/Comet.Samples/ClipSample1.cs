﻿using System;
using System.Collections.Generic;
using System.Graphics;
using System.Text;

namespace Comet.Samples
{
	public class ClipSample1 : View
	{
		[Body]
		View body() => new VStack {
				new Image("turtlerock.jpg")
					.ClipShape(new Circle())
					.Overlay(new Circle().Stroke(Colors.White, lineWidth: 4))
					.Shadow(radius: 10)
			};

	}
}
