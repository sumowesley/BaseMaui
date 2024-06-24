using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMaui
{

    public  partial class MainPageViewModel : BaseViewModel
    {
        public List<Team> TeamList { get; set; } = new List<Team>();
        // add all the NBA teams to the list using their abbreviations and names
        public MainPageViewModel()
        {
            TeamList.Add(new Team { Abbreviation = "ATL", Name = "Atlanta Hawks" });
            TeamList.Add(new Team { Abbreviation = "BOS", Name = "Boston Celtics" });
            TeamList.Add(new Team { Abbreviation = "BKN", Name = "Brooklyn Nets" });
            TeamList.Add(new Team { Abbreviation = "CHA", Name = "Charlotte Hornets" });
            TeamList.Add(new Team { Abbreviation = "CHI", Name = "Chicago Bulls" });
            TeamList.Add(new Team { Abbreviation = "CLE", Name = "Cleveland Cavaliers" });
            TeamList.Add(new Team { Abbreviation = "DAL", Name = "Dallas Mavericks" });
            TeamList.Add(new Team { Abbreviation = "DEN", Name = "Denver Nuggets" });
            TeamList.Add(new Team { Abbreviation = "DET", Name = "Detroit Pistons" });
            TeamList.Add(new Team { Abbreviation = "GSW", Name = "Golden State Warriors" });
            TeamList.Add(new Team { Abbreviation = "HOU", Name = "Houston Rockets" });
            TeamList.Add(new Team { Abbreviation = "IND", Name = "Indiana Pacers" });
            TeamList.Add(new Team { Abbreviation = "LAC", Name = "Los Angeles Clippers" });
            TeamList.Add(new Team { Abbreviation = "LAL", Name = "Los Angeles Lakers" });
            TeamList.Add(new Team { Abbreviation = "MEM", Name = "Memphis Grizzlies" });
            TeamList.Add(new Team { Abbreviation = "MIA", Name = "Miami Heat" });
            TeamList.Add(new Team { Abbreviation = "MIL", Name = "Milwaukee Bucks" });
            TeamList.Add(new Team { Abbreviation = "MIN", Name = "Minnesota Timberwolves" });
            TeamList.Add(new Team { Abbreviation = "NOP", Name = "New Orleans Pelicans" });
            TeamList.Add(new Team { Abbreviation = "NYK", Name = "New York Knicks" });
            TeamList.Add(new Team { Abbreviation = "OKC", Name = "Oklahoma City Thunder" });
            TeamList.Add(new Team { Abbreviation = "ORL", Name = "Orlando Magic" });
            TeamList.Add(new Team { Abbreviation = "PHI", Name = "Philadelphia 76ers" });
            TeamList.Add(new Team { Abbreviation = "PHX", Name = "Phoenix Suns" });
            TeamList.Add(new Team { Abbreviation = "POR", Name = "Portland Trail Blazers" });
            TeamList.Add(new Team { Abbreviation = "SAC", Name = "Sacramento Kings" });
            TeamList.Add(new Team { Abbreviation = "SAS", Name = "San Antonio Spurs" });
            TeamList.Add(new Team { Abbreviation = "TOR", Name = "Toronto Raptors" });
            TeamList.Add(new Team { Abbreviation = "UTA", Name = "Utah Jazz" });
            TeamList.Add(new Team { Abbreviation = "WAS", Name = "Washington Wizards" });

            
        }



        [RelayCommand]
        public async Task ButtonOneClicked()
        {
            await AppShell.Current.DisplayAlert("", "Button One Clicked", "OK");
        }

        [RelayCommand]
        public async Task ButtonTwoClicked()
        {
            await AppShell.Current.DisplayAlert("", "Button Two Clicked", "OK");
        }

        [RelayCommand]
        public async Task GridClicked()
        {
            await AppShell.Current.DisplayAlert("", "Grid Clicked using toolkit TouchBehavior", "OK");
        }

        [RelayCommand]
        public async Task ScreenOneClicked() {
            await Shell.Current.GoToAsync("ScreenOnePage");
        }

        [RelayCommand]
        public async Task ScreenTwoClicked()
        {
            await AppShell.Current.GoToAsync("ScreenTwoPage");
        }

    }


}
