using MauiAppShowDoMilhão.Models;
using Plugin.Maui.Audio;

namespace MauiAppShowDoMilhão
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void toca_som()
        {
            string track = "";

            switch(pergunta_count)
            {
                case 1:
                    track = "1000.wav";
                break;

                case 2:
                    track = "2000.wav";
                break;

                case 3:
                    track = "3000.wav";
                break;

                case 4:
                    track = "4000.wav";
                break;

                case 5:
                    track = "5000.wav";
                break;

                case 6:
                    track = "10000.wav";
                break;

                case 7:
                    track = "20000.wav";
                break;

                case 8:
                    track = "30000.wav";
                break;

                case 9:
                    track = "40000.wav";
                break;

                case 10:
                    track = "50000.wav";
                break;

                case 11:
                    track = "100000.wav";
                break;

                case 12:
                    track = "200000.wav";
                break;

                case 13:
                    track = "300000.wav";
                break;

                case 14:
                    track = "400000.wav";
                break;

                case 15:
                    track = "500000.wav";
                break;

                case 16:
                    track = "1000000.wav";
                break;
            }
            AudioManager.Current.CreatePlayer(
                FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private async void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ( (bool) alt0.Value )
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }

            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
                Stream track = FileSystem.OpenAppPackageFileAsync("parabens.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();

                await DisplayAlert("Acertou!", resp, "Ok");
                pergunta_count++;
                toca_som();
                avanca_pergunta();
            }
            else
            {
                Stream track = FileSystem.OpenAppPackageFileAsync("errou.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();

                await DisplayAlert("Errou!", "Você perdeu!", "Ok");
                premio = 0;
                pergunta_count = 1;
                avanca_pergunta();
            }
        }

        void avanca_pergunta()
        {
            //PERGUNTAS QUE VALE DE 1.000 A 5.000
            if(pergunta_count <= 5)
            {
                premio = premio += 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
                lbl_nivel.Text = "Facil";
            }

            //PERGUNTAS QUE VALE RS 10.000
            if(pergunta_count == 6)
            {
                premio = 10000;
                this.BindingContext = App.getRandomPerguntaMedia();
                lbl_nivel.Text = "Media";
            }

            //PERGUNTAS DE 20.000 A 50.000
            if(pergunta_count > 6 && pergunta_count <= 10)
            {
                premio = premio + 10000;
                this.BindingContext= App.getRandomPerguntaMedia();
                lbl_nivel.Text = "Media";
            }

            //PERGUNTA QUE VALE 100.000
            if (pergunta_count == 11)
            {
                premio = 100000;
                this.BindingContext = App.getRandomPerguntaDificil();
                lbl_nivel.Text = "Dificil";
            }

            //PERGUNTAS DE 200.000 A 500.000
            if (pergunta_count > 11 && pergunta_count <= 15)
            {
                premio = premio + 100000;
                this.BindingContext = App.getRandomPerguntaDificil();
                lbl_nivel.Text = "Dificil";
            }

            //PERGUNTA QUE VALE 1.000.000
            if (pergunta_count == 16)
            {
                premio = 1000000;
                this.BindingContext = App.getRandomPerguntaFinal();
                lbl_nivel.Text = "Final";
            }

            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();
        }
    }

}
