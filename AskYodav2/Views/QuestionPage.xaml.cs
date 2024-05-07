namespace AskYodav2.Views;
using AskYodav2.Model;
using AskYodav2.ViewModels;

public partial class QuestionPage : ContentPage
{
    QuestionViewModel _viewModel;
	public QuestionPage(QuestionViewModel vm)
	{
        InitializeComponent();

        _viewModel = vm;

        BindingContext = _viewModel;
    }
}