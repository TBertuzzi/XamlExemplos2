using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamlExemplos2.Model;

namespace XamlExemplos2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<GameGroup> Games { get; set; } = new ObservableCollection<GameGroup>();

        public MainPage()
        {
            InitializeComponent();

            Games.Add(new GameGroup("PS4", new[]{ new Game
                {
                      Nome = "God of War",
                    TituloBR = "O bom da guerra"
                },
                new Game
                {
                    Nome = "The last of us",
                    TituloBR = "Nois que sobramus"
                }}));

            Games.Add(new GameGroup("Nintendo Switch", new[]{ new Game
                {
                      Nome = "Mario Kart 8",
                    TituloBR = "Correndo com meus Amig..Inimigos"
                },
                new Game
                {
                    Nome = "Super Mario Odyssey",
                    TituloBR = "As viagens do Bigode"
                }}));

            Games.Add(new GameGroup("Xbox One", new[]{ new Game
                {
                      Nome = "Halo",
                    TituloBR = "E eu passei metiolate"
                },
               }));

            BindingContext = this;
        }
    }
}
