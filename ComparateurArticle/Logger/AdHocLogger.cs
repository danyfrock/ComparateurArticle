using System;
using System.IO;

namespace ComparateurArticle.Logger
{
    internal class AdHocLogger
    {
        private readonly string _logFilePath;

        public AdHocLogger()
        {
            // Définissez ici le chemin du fichier de log, par exemple dans le répertoire courant.
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logfile.txt");
        }

        // Méthode pour enregistrer un message avec un niveau d'information
        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        // Méthode pour enregistrer un avertissement
        public void LogWarning(string message)
        {
            Log("WARNING", message);
        }

        // Méthode pour enregistrer une erreur
        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        // Méthode générique pour écrire le log avec un niveau spécifique
        private void Log(string level, string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            WriteToFile(logMessage);
        }

        // Méthode pour écrire dans le fichier
        private void WriteToFile(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_logFilePath, true))
                {
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'écriture du log : {ex.Message}");
            }
        }
    }
}
