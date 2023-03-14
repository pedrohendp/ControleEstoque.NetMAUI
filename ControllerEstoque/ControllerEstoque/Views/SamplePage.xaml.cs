using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Font = Microsoft.Maui.Font;

namespace ControllerEstoque.Views;

public partial class SamplePage : ContentPage
{
	public SamplePage(SampleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	private async void OnFabButtonClicked(object sender, EventArgs e)
	{
		// Seu código para abrir as opções

		// Exibe um ActionSheet com algumas opções

		var result = await DisplayActionSheet("Adicionar item", "Cancelar", null, "Opção 1", "Opção 2", "Opção 3");

		// Verifica qual opção foi selecionada
		if (result == "Cancelar")
		{
			CancellationTokenSource cancellationTokenSource = new();

			// Seu código para lidar com a opção selecionada
			var snack = new SnackbarOptions
			{
				BackgroundColor = Colors.Red,
				TextColor = Colors.Green,
				ActionButtonTextColor = Colors.Yellow,
				CornerRadius = new CornerRadius(10),
				Font = Font.SystemFontOfSize(14),
				ActionButtonFont = Font.SystemFontOfSize(14),
				CharacterSpacing = 0.5
			};

			string text = "This is a Snackbar";
			string actionButtonText = "Click Here to Dismiss";
			Action action = async () => await DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");
			TimeSpan duration = TimeSpan.FromSeconds(3);

			var snackbar = Snackbar.Make(text, action, actionButtonText, duration, snack);

			await snackbar.Show(cancellationTokenSource.Token);
		}
	}
}
