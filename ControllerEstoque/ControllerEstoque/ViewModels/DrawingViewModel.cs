﻿using CommunityToolkit.Maui.Core;

namespace ControllerEstoque.ViewModels;

public partial class DrawingViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}
