﻿namespace TestMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            
        }
        private void OnNewPageClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CharacterCreatePage());
        }
    }

}
