
using Microsoft.VisualBasic.FileIO;
using System.Text;
using SearchOption = System.IO.SearchOption;

namespace CleanerPC
{
    public class CleanOperations
    {
        public static async Task CleanTempFilesAsync(Label outputText, ProgressBar progressBar)
        {
            string tempPath = Path.GetTempPath(); // points to the %TEMP% or %TMP% -> \AppData\Local\Temp
            List<string> deletedFiles = new List<string>();
            List<string> failedFiles = new List<string>();
            int filesProcessed = 0;

            try
            {
                // Get the total count of files and directories
                int totalFilesAndDirs = Directory.GetFiles(tempPath, "*", SearchOption.AllDirectories).Length +
                                        Directory.GetDirectories(tempPath, "*", SearchOption.AllDirectories).Length;

                // Initialize progress bar
                progressBar.Minimum = 0;
                progressBar.Maximum = totalFilesAndDirs;
                progressBar.Value = 0;

                await Task.Run(() => ProcessDirectory(tempPath, deletedFiles, failedFiles, ref filesProcessed, progressBar));

                StringBuilder message = new StringBuilder();
                message.AppendLine($"Arquivos temporários processados: {filesProcessed}");
                message.AppendLine("Arquivos temporários limpados com sucesso!");
                message.AppendLine("Arquivos deletados:");

                outputText.Text = message.ToString();


                foreach (string deletedFile in deletedFiles)
                {
                    message.AppendLine(deletedFile);
                }

                message.AppendLine("\nArquivos que não puderam ser deletados:");

                foreach (string failedFile in failedFiles)
                {
                    message.AppendLine(failedFile);
                }


                MessageBox.Show("Processamento de arquivos temporários completo!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar arquivos temporários: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ProcessDirectory(string path, List<string> deletedFiles, List<string> failedFiles, ref int filesProcessed, ProgressBar progressBar)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                filesProcessed++;
                try
                {
                    if (!IsFileInUse(file))
                    {
                        File.SetAttributes(file, FileAttributes.Normal); // removing any read-only, hidden, or system attributes that the file might have
                        FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        deletedFiles.Add(file);
                    }
                    else
                    {
                        failedFiles.Add(file);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao deletar arquivo: {ex.Message}");
                    failedFiles.Add(file);
                }
                // Update progress bar
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
                }));
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                ProcessDirectory(dir, deletedFiles, failedFiles, ref filesProcessed, progressBar);
                try
                {
                    Directory.Delete(dir, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao deletar diretório: {ex.Message}");
                    failedFiles.Add(dir);
                }
                // Update progress bar
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
                }));
            }
        }


        private static bool IsFileInUse(string filePath)
        {
            try
            {
                using (FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    fileStream.Close();
                }
                return false;
            }
            catch (IOException) 
            {
                return true;
            }
        }
    }
}
