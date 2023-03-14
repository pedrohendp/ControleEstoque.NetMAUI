namespace ControllerEstoque;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
		SaudacaoAtual = Saudacoes();
	}
	public string SaudacaoAtual { get; set; }
	private string Saudacoes()
	{
		var now = DateTime.Now;
		var hour = now.Hour;
		if (hour < 12)
		{
			return "Bom dia";
		}
		else if (hour < 18)
		{
			return "Boa tarde";
		}
		else
		{
			return "Boa noite";
		}
	}
}
