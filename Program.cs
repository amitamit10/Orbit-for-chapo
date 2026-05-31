using System.Diagnostics;

namespace Orbit
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new orbitWin());

            //Board a = new Board();
            //a.PlaceTroop(new Location(0, 0), Troop.BLACK_TROOP);
            //a.PlaceTroop(new Location(1, 1), Troop.BLACK_TROOP);
            //a.PlaceTroop(new Location(2, 1), Troop.WHITE_TROOP);
            //a.PlaceTroop(new Location(2, 2), Troop.BLACK_TROOP);
            //a.PlaceTroop(new Location(1, 2), Troop.NO_TROOP);
            //a.PlaceTroop(new Location(0, 2), Troop.WHITE_TROOP);
            //a.PlaceTroop(new Location(3, 1), Troop.WHITE_TROOP);
            //a.PlaceTroop(new Location(3, 2), Troop.WHITE_TROOP);
            //Debug.WriteLine(a.printBoard());
            //a.rotate();
            //Debug.WriteLine(a.printBoard());
        }
    }
}