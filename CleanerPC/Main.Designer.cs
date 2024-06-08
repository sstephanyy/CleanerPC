using System.Windows.Forms;

namespace CleanerPC
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            limpezaArquivosBtn = new Button();
            programasBtn = new Button();
            limpezaSistemaBtn = new Button();
            ConfiguracoesButton = new Button();
            messageLabel = new Label();
            CleanTemporaryFilesBtn = new Button();
            CleanBrowserCachesBtn = new Button();
            RemoveDuplicateFilesBtn = new Button();
            CleanLogFilesBtn = new Button();
            outputText = new Label();
            progressBar = new ProgressBar();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(limpezaArquivosBtn);
            flowLayoutPanel1.Controls.Add(programasBtn);
            flowLayoutPanel1.Controls.Add(limpezaSistemaBtn);
            flowLayoutPanel1.Controls.Add(ConfiguracoesButton);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 30, 0, 0);
            flowLayoutPanel1.Size = new Size(200, 450);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // limpezaArquivosBtn
            // 
            limpezaArquivosBtn.BackColor = Color.FromArgb(23, 24, 29);
            limpezaArquivosBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpezaArquivosBtn.ForeColor = Color.White;
            limpezaArquivosBtn.Location = new Point(8, 33);
            limpezaArquivosBtn.Margin = new Padding(3, 3, 3, 13);
            limpezaArquivosBtn.Name = "limpezaArquivosBtn";
            limpezaArquivosBtn.Size = new Size(181, 44);
            limpezaArquivosBtn.TabIndex = 2;
            limpezaArquivosBtn.Text = "Limpeza de Arquivos";
            limpezaArquivosBtn.UseVisualStyleBackColor = false;
            limpezaArquivosBtn.Click += limpezaArquivosBtn_Click;
            // 
            // programasBtn
            // 
            programasBtn.BackColor = Color.FromArgb(23, 24, 29);
            programasBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programasBtn.ForeColor = Color.White;
            programasBtn.Location = new Point(8, 93);
            programasBtn.Margin = new Padding(3, 3, 3, 13);
            programasBtn.Name = "programasBtn";
            programasBtn.Size = new Size(181, 44);
            programasBtn.TabIndex = 3;
            programasBtn.Text = "Programas";
            programasBtn.UseVisualStyleBackColor = false;
            programasBtn.Click += programasBtn_Click;
            // 
            // limpezaSistemaBtn
            // 
            limpezaSistemaBtn.BackColor = Color.FromArgb(23, 24, 29);
            limpezaSistemaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpezaSistemaBtn.ForeColor = Color.White;
            limpezaSistemaBtn.Location = new Point(8, 153);
            limpezaSistemaBtn.Margin = new Padding(3, 3, 3, 13);
            limpezaSistemaBtn.Name = "limpezaSistemaBtn";
            limpezaSistemaBtn.Size = new Size(181, 44);
            limpezaSistemaBtn.TabIndex = 4;
            limpezaSistemaBtn.Text = "Limpeza do sistema";
            limpezaSistemaBtn.UseVisualStyleBackColor = false;
            limpezaSistemaBtn.Click += limpezaSistemaBtn_Click;
            // 
            // ConfiguracoesButton
            // 
            ConfiguracoesButton.BackColor = Color.FromArgb(23, 24, 29);
            ConfiguracoesButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfiguracoesButton.ForeColor = Color.White;
            ConfiguracoesButton.Location = new Point(8, 213);
            ConfiguracoesButton.Name = "ConfiguracoesButton";
            ConfiguracoesButton.Size = new Size(181, 44);
            ConfiguracoesButton.TabIndex = 5;
            ConfiguracoesButton.Text = "Configurações";
            ConfiguracoesButton.UseVisualStyleBackColor = false;
            ConfiguracoesButton.Click += ConfiguracoesButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(453, 33);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(112, 47);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "label1";
            // 
            // CleanTemporaryFilesBtn
            // 
            CleanTemporaryFilesBtn.BackColor = Color.IndianRed;
            CleanTemporaryFilesBtn.Cursor = Cursors.Hand;
            CleanTemporaryFilesBtn.ForeColor = Color.White;
            CleanTemporaryFilesBtn.Location = new Point(285, 116);
            CleanTemporaryFilesBtn.Name = "CleanTemporaryFilesBtn";
            CleanTemporaryFilesBtn.Size = new Size(206, 32);
            CleanTemporaryFilesBtn.TabIndex = 3;
            CleanTemporaryFilesBtn.Text = "Limpar Arquivos Temporários";
            CleanTemporaryFilesBtn.UseVisualStyleBackColor = false;
            CleanTemporaryFilesBtn.Click += CleanTemporaryFilesBtn_Click_1;
            // 
            // CleanBrowserCachesBtn
            // 
            CleanBrowserCachesBtn.BackColor = Color.Green;
            CleanBrowserCachesBtn.Cursor = Cursors.Hand;
            CleanBrowserCachesBtn.ForeColor = Color.White;
            CleanBrowserCachesBtn.Location = new Point(285, 185);
            CleanBrowserCachesBtn.Name = "CleanBrowserCachesBtn";
            CleanBrowserCachesBtn.Size = new Size(206, 32);
            CleanBrowserCachesBtn.TabIndex = 4;
            CleanBrowserCachesBtn.Text = "Limpar Cache de Navegadores";
            CleanBrowserCachesBtn.UseVisualStyleBackColor = false;
            CleanBrowserCachesBtn.Click += CleanBrowserCachesBtn_Click_1;
            // 
            // RemoveDuplicateFilesBtn
            // 
            RemoveDuplicateFilesBtn.BackColor = Color.DarkGoldenrod;
            RemoveDuplicateFilesBtn.Cursor = Cursors.Hand;
            RemoveDuplicateFilesBtn.ForeColor = Color.White;
            RemoveDuplicateFilesBtn.Location = new Point(529, 116);
            RemoveDuplicateFilesBtn.Name = "RemoveDuplicateFilesBtn";
            RemoveDuplicateFilesBtn.Size = new Size(206, 32);
            RemoveDuplicateFilesBtn.TabIndex = 5;
            RemoveDuplicateFilesBtn.Text = "Limpar Arquivos Duplicados";
            RemoveDuplicateFilesBtn.UseVisualStyleBackColor = false;
            RemoveDuplicateFilesBtn.Click += RemoveDuplicateFilesBtn_Click;
            // 
            // CleanLogFilesBtn
            // 
            CleanLogFilesBtn.BackColor = Color.MediumPurple;
            CleanLogFilesBtn.Cursor = Cursors.Hand;
            CleanLogFilesBtn.ForeColor = Color.White;
            CleanLogFilesBtn.Location = new Point(529, 185);
            CleanLogFilesBtn.Name = "CleanLogFilesBtn";
            CleanLogFilesBtn.Size = new Size(206, 32);
            CleanLogFilesBtn.TabIndex = 6;
            CleanLogFilesBtn.Text = "Limpar Arquivos de Logs";
            CleanLogFilesBtn.UseVisualStyleBackColor = false;
            CleanLogFilesBtn.Click += CleanLogFilesBtn_Click;
            // 
            // outputText
            // 
            outputText.AutoSize = true;
            outputText.Location = new Point(469, 242);
            outputText.Name = "outputText";
            outputText.Size = new Size(62, 15);
            outputText.TabIndex = 9;
            outputText.Text = "Resultado:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(344, 312);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(319, 48);
            progressBar.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputText);
            Controls.Add(progressBar);
            Controls.Add(CleanLogFilesBtn);
            Controls.Add(RemoveDuplicateFilesBtn);
            Controls.Add(CleanBrowserCachesBtn);
            Controls.Add(CleanTemporaryFilesBtn);
            Controls.Add(messageLabel);
            Controls.Add(flowLayoutPanel1);
            Name = "Main";
            Text = "Cleaner";
            Load += Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button limpezaArquivosBtn;
        private Button programasBtn;
        private Button limpezaSistemaBtn;
        private Button ConfiguracoesButton;
        private Label messageLabel;
        private Button CleanTemporaryFilesBtn;
        private Button CleanBrowserCachesBtn;
        private Button RemoveDuplicateFilesBtn;
        private Button CleanLogFilesBtn;
        private ProgressBar progressBar;
        private Label outputText;
    }
}
