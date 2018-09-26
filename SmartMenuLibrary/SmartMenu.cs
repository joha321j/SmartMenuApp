using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        //Variables
        string menuName = string.Empty;
        string menuDescription = string.Empty;
        List<string> menuList = new List<string>();
        List<string> menuId = new List<string>();

        public void LoadMenu(string path)
        {
            int lineCounter = 0;
            string line;


            //Create an instance of StreamReader, because it is not a static class.
            System.IO.StreamReader menuFile = new System.IO.StreamReader(@path);

            while ((line = menuFile.ReadLine()) != null)
            {
                menuList.Add(line);
                if (menuList[lineCounter].Contains(";"))
                {
                    string[] tempStringArray = menuList[lineCounter].Split(';');
                    menuList[lineCounter] = tempStringArray[0];
                    menuId.Add(tempStringArray[1]);
                }
                lineCounter++;
            }

            menuFile.Close();

            //Moving the first 2 items in menuList to ensure that menuId and menuList should have same dimensions.
            menuName = menuList[0];
            menuDescription = menuList[1];
            menuList.RemoveAt(0);
            menuList.RemoveAt(0);
        }
        public void Activate()
        {
            int userInput = 1;

            //Print the loaded menu

            while (userInput != 0)
            {
                Console.Clear();
                Console.WriteLine(menuName);
                Console.WriteLine(menuDescription);
                for (int lineCount = 0; lineCount < menuList.Count; lineCount++)
                {
                    Console.WriteLine("{0}. {1}", lineCount + 1, menuList[lineCount]);
                }

                Console.WriteLine("Tast linie nummeret for at tilgå den undermenu.");
                Console.WriteLine("Tast 0 for at afslutte.");

                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Indtast venligst et tal.");
                }
            }
        }
    }
}
