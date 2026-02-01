using System.IO.Pipes;
using Vet_Lib.View.Membre;
using Vet_Lib.View.Membre.Connexion;
using Vet_Lib.View.Membre.Page;

namespace Vet_Lib.View.Class
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil_principal());
        }
    }
}


