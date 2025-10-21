using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace LabTask2_BCS23020011
{
    public partial class MainPage : ContentPage
    {
        // Used to track the heart button status
        private bool isHeartRed = false;
        private Color heartOriginalColor = Color.FromArgb("#F0E68C");

        // Stores the Pet object passed from HomePage
        private PetData currentPet;

        // The constructor now accepts a Pet object
        public MainPage(PetData pet)
        {
            InitializeComponent();

            // Store this pet object
            currentPet = pet;

            // Calling new methods to populate the UI
            BindDataToUI();
        }

        // Bind the pet object's data to UI controls
        private void BindDataToUI()
        {
            // Set the page title
            this.Title = currentPet.Name;

            // Populate all controls named in XAML
            PetImage.Source = currentPet.Image;
            PetNameLabel.Text = currentPet.Name;
            PetBreedLabel.Text = currentPet.Breed;
            PetLocationLabel.Text = currentPet.Location;
            PetAgeLabel.Text = currentPet.Age;
            OwnerImage.Source = currentPet.OwnerImage;
            OwnerNameLabel.Text = currentPet.OwnerName;
            PostDateLabel.Text = currentPet.PostDate;
            DescriptionLabel.Text = currentPet.Description;
            PetGenderImage.Source = currentPet.GenderSymbol;
        }

        // Heart button click event (remains unchanged)
        private void OnHeartClicked(object sender, TappedEventArgs e)
        {
            isHeartRed = !isHeartRed;

            if (isHeartRed)
            {
                HeartIcon.TextColor = Colors.Red;
            }
            else
            {
                HeartIcon.TextColor = heartOriginalColor;
            }
        }

        // Adoption button click event (navigates to BookingPage)
        private async void OnAdoptionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookingAppointmentPage());
        }
    }
}