using System.Collections.Generic;

namespace LabTask2_BCS23020011
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            // Loading our pet data into the grid
            PetsCollectionView.ItemsSource = GetPets();
        }

        // When the user clicks on any item in the grid
        private async void OnPetTapped(object sender, TappedEventArgs e)
        {
            // Get the clicked control (Border)
            var border = sender as Border;

            // Get the data it is bound to (Pet object) from the control's "BindingContext"
            var pet = border?.BindingContext as PetData;

            if (pet != null)
            {
                // Navigate to MainPage and pass the "pet" object
                await Navigation.PushAsync(new MainPage(pet));
            }
        }

        // Creating our data list
        private List<PetData> GetPets()
        {
            return new List<PetData>
            {
                // Adding a first pet
                new PetData
                {
                    Name = "Tuo Tuo",
                    Breed = "Pug",
                    Image = "pet1.jpeg",
                    Location = "Brorte B. Tamuin, Raritau Panjat",
                    GenderSymbol = "symbolmale.png",
                    Age = "1 year old",
                    OwnerName = "Jeon Jungkook",
                    OwnerImage = "owner1.png",
                    PostDate = "1/1/2024",
                    Description = "Yo, Tuo the Pug is simply a tiny tornado of fun, wrinkles, and endless charm."
                },
                // Adding a second pet
                new PetData
                {
                    Name = "Sparky",
                    Breed = "Golden Retriever",
                    Image = "pet2.jpg",
                    Location = "Taman Sentosa, Sibu",
                    GenderSymbol = "symbolfemale.png",
                    Age = "2 years old",
                    OwnerName = "Jane Doe",
                    OwnerImage = "owner2.jpeg",
                    PostDate = "10/10/2024",
                    Description = "Sparky is a loyal and loving friend who loves to play fetch."
                }
            };
        }
    }
}