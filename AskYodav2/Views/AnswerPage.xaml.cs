using AskYodav2.ViewModels;
namespace AskYodav2.Views;

public partial class AnswerPage : ContentPage
{
	AnswerViewModel _viewModel;
	public AnswerPage(AnswerViewModel vm)
	{
		_viewModel = vm;

		InitializeComponent();

        BindingContext = _viewModel;
    }
}