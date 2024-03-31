namespace SyncfusionMAUIAppProduct.Phonebook;

public partial class ContactEntry : ContentPage
{
	public Contact Contact { get; set; }
	public ContactEntry()
	{
		InitializeComponent();
	}

	private async void sfButton_Clicked(object sender, EventArgs e)
	{
		try
		{

			ContactFormViewModel ContactFormViewModel = (ContactFormViewModel)this.BindingContext;


			if (ContactFormViewModel.Contact != null)
			{
				ContactGridViewModel cv = new();

				cv.AddContact(ContactFormViewModel.Contact);
				//Navigation.
				await Shell.Current.GoToAsync("//ContactListPage");
			}
		}
		catch (Exception ex)
		{

			await Shell.Current.DisplayAlert("ERROR", ex.Message, "X");
		}





	}
}