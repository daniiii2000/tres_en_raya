namespace tres_en_raya
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;
            btn.Text = vez;
            vez = (vez == "X") ? "O" : "X";

            // Verificar ganador
            string ganador = VerificarGanador();
            if (ganador != "")
            {
                DisplayAlert("Muy bien!", $"El {ganador} ganó!", "OK");
                terminar();
            }
        }

        private string VerificarGanador()
        {
            switch (true)
            {
                case var _ when (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X"):
                case var _ when (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X"):
                case var _ when (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X"):
                case var _ when (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X"):
                case var _ when (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X"):
                case var _ when (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X"):
                case var _ when (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X"):
                case var _ when (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X"):
                    return "X";

                case var _ when (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O"):
                case var _ when (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O"):
                case var _ when (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O"):
                case var _ when (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O"):
                case var _ when (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O"):
                case var _ when (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O"):
                case var _ when (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O"):
                case var _ when (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"):
                    return "O";

                default:
                    return "";
            }
        }

        void terminar()
        {
            foreach (var btn in new Button[] { btn10, btn11, btn12, btn20, btn21, btn22, btn30, btn31, btn32 })
            {
                btn.Text = "";
                btn.IsEnabled = true;
            }
        }
    }
}
