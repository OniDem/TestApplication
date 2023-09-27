namespace TestApplication;

public partial class TaskList : ContentPage
{
	public TaskList()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void ToNextPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateTaskPage());
    }
}