using System.Drawing.Printing;
using System.Windows.Forms;

namespace CleanerPC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            limpezaArquivosBtn_Click(sender, e);

        }


        private void limpezaArquivosBtn_Click(object sender, EventArgs e)
        {
            CleanTemporaryFilesBtn.Visible = true;
            RemoveDuplicateFilesBtn.Visible = true;
            CleanBrowserCachesBtn.Visible = true;
            CleanLogFilesBtn.Visible = true;
            DisplayMessageAndChangeBackground("Limpeza de Arquivos", Color.LightBlue);

        }


        private void programasBtn_Click(object sender, EventArgs e)
        {
            DisplayMessageAndChangeBackground("Programas", Color.LightYellow);
            HideCleaningButtons();



        }

        private void limpezaSistemaBtn_Click(object sender, EventArgs e)
        {
            DisplayMessageAndChangeBackground("Limpeza do sistema", Color.LightGreen);
            HideCleaningButtons();



        }

        private void ConfiguracoesButton_Click(object sender, EventArgs e)
        {
            DisplayMessageAndChangeBackground("Configurações", Color.LightGray);
            HideCleaningButtons();


        }

        private void DisplayMessageAndChangeBackground(string message, Color backgroundColor)
        {
            messageLabel.Text = message;
            this.BackColor = backgroundColor;
        }

        private void HideCleaningButtons()
        {
            CleanTemporaryFilesBtn.Visible = false;
            RemoveDuplicateFilesBtn.Visible = false;
            CleanBrowserCachesBtn.Visible = false;
            CleanLogFilesBtn.Visible = false;
            progressBar.Visible = false;

        }



        private void CleanBrowserCachesBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void CleanLogFilesBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveDuplicateFilesBtn_Click(object sender, EventArgs e)
        {

        }

        private async void CleanTemporaryFilesBtn_Click_1(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            await CleanOperations.CleanTempFilesAsync(outputText, progressBar);
        }

        
    }
}
