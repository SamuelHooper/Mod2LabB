namespace Mod2LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TimeUntillAlcohol(object sender, EventArgs e)
        {
            DateTime birthday = Birthday.Date.ToLocalTime();
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
            {
                age--;
            }

            string country = "United States of America";
            try
            {
                country = Country.SelectedItem.ToString();
            } catch { }

            int yearsUntillAlcohol = 0;

            if (country == "United States of America")
            {
                yearsUntillAlcohol = 21 - age;
            } else if (country == "China" || country == "United Kingdom")
            {
                yearsUntillAlcohol = 18 - age;
            } else if (country == "Germany")
            {
                yearsUntillAlcohol = 16 - age;
            }

            if (yearsUntillAlcohol > 0)
            {
                TimeUntillAlcoholOutput.Text = $"You can drink Alcohol in {yearsUntillAlcohol} year(s)";
            }
            else
            {
                TimeUntillAlcoholOutput.Text = "You can drink Alcohol now";
            }
        }
    }

}
