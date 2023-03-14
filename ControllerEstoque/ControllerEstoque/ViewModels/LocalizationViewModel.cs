namespace ControllerEstoque.ViewModels;

public partial class LocalizationViewModel : BaseViewModel
{
	public string LocalizedText => ControllerEstoque.Resources.Strings.AppResources.HelloMessage;
}
