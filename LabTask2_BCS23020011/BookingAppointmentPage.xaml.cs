namespace LabTask2_BCS23020011
{
    public partial class BookingAppointmentPage : ContentPage
    {
        public BookingAppointmentPage()
        {
            InitializeComponent();
        }

        // This is the button click event
        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Verification: Check if name or phone number is empty
            if (string.IsNullOrEmpty(NameEntry.Text) || string.IsNullOrEmpty(PhoneEntry.Text))
            {
                // If empty, an error popup will be displayed
                await DisplayAlert("Error", "Please fill in all fields", "OK");
            }
            else
            {
                // If not empty, a success pop-up window will be displayed
                await DisplayAlert("Success", "Your reservation has been confirmed!", "OK");

                // Reset all fields
                ResetForm();
            }
        }

        // To clear the form
        private void ResetForm()
        {
            NameEntry.Text = string.Empty;
            PhoneEntry.Text = string.Empty;

            // Reset the date to today
            AppointmentDatePicker.Date = DateTime.Today;

            // Reset the time to the current time
            AppointmentTimePicker.Time = DateTime.Now.TimeOfDay;
            // (Customization: reset to 12 noon)
            // AppointmentTimePicker.Time = new TimeSpan(12, 0, 0); 
        }
    }
}