﻿using System;
using System.Collections.Generic;
using System.Graphics;

namespace Comet.Samples
{
	public class TextFieldSample3 : View
	{
		class MyBindingObject : BindingObject
		{
			public string Text
			{
				get => GetProperty<string>();
				set => SetProperty(value);
			}
		}

		[State] private readonly MyBindingObject _state = new MyBindingObject { Text = "Edit Me" };

		[Body]
		View Build() => new VStack()
		{
			new TextField(_state.Text, "Name"),
			new HStack()
			{
				new Text("Current Value:")
					.Color(Colors.Grey),
				new Text(_state.Text),
				new Spacer()
			},
		}.FillHorizontal();
	}

}
