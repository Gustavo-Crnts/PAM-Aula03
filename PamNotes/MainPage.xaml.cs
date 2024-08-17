namespace PamNotes
{//nome desse arquivo é "CodeBehind" 
    public partial class MainPage : ContentPage
    {
        string filePath = Path.Combine (FileSystem.AppDataDirectory, "guga.txt");
        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(filePath))
            {
                {
                    EditorSalvar.Text = File.ReadAllText(filePath);
                }

            }
        }
        //Para salvar em um arquivo tenho que fazer:
        // 1º Criar o arquivo
        // 2º Pegar o texto e armazenar em uma variável
        //3º Gravar o conteúdo da variável de um arquivo
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string texto = EditorSalvar.Text;

            Exibir.Text = texto;
            File.WriteAllText(filePath, texto);
            DisplayAlert("Operação concluída", "Arquivo salvo com sucesso!", "Fechar");

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
           
                string texto = EditorSalvar.Text;

            Exibir.Text = " ";
             
            EditorSalvar.Text = "Sua anotação foi apagada com sucesso! ";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Operação concluída!", "Arquivo foi apagado com sucesso!", "Fechar");
                EditorSalvar.Text = " ";
            }


            else
            {
                DisplayAlert("Alerta", "Arquivo não encontrado", "Fechar");
            }

        }


    }

}
