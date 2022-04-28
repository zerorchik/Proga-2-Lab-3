using System;
using System.Collections.Generic;

namespace proga_2_lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            bool choosed = false;

            Folder[] _folder =
            {
                new Folder() { Name = "C:\\", Num = 0 },
                new Folder() { Name = "Download", Num = 1 },
                new Folder() { Name = "Users", Num = 2 },
                new Folder() { Name = "ProgramData", Num = 3 },
                new Folder() { Name = "Documents", Num = 4 },
                new Folder() { Name = "Windows", Num = 5 },
                new Folder() { Name = "TelegramDesctop", Num = 6 },
                new Folder() { Name = "Admin", Num = 7 },
                new Folder() { Name = "Common", Num = 8 },
                new Folder() { Name = "Apps", Num = 9 },
                new Folder() { Name = "MyDocuments", Num = 10 },
                new Folder() { Name = "Microsoft", Num = 11 },
                new Folder() { Name = "Intel", Num = 12 },
                new Folder() { Name = "...", Num = 13 },
                new Folder() { Name = "", Num = 14 },
            };
            _folder[0].PreviousFolder = _folder[13];
            _folder[1].PreviousFolder = _folder[0];
            _folder[2].PreviousFolder = _folder[0];
            _folder[3].PreviousFolder = _folder[0];
            _folder[4].PreviousFolder = _folder[0];
            _folder[5].PreviousFolder = _folder[0];
            _folder[6].PreviousFolder = _folder[1];
            _folder[7].PreviousFolder = _folder[2];
            _folder[8].PreviousFolder = _folder[2];
            _folder[9].PreviousFolder = _folder[5];
            _folder[10].PreviousFolder = _folder[4];
            _folder[11].PreviousFolder = _folder[3];
            _folder[12].PreviousFolder = _folder[3];
            _folder[13].PreviousFolder = _folder[14];
            _folder[14].PreviousFolder = _folder[14];

            while (true)
            {
                if (choosed)
                {
                    Console.Clear();
                    if (index > 12 || index < 0) Console.WriteLine("No such folder!");
                    else
                    {
                        Console.WriteLine("You entered \"" + _folder[index].Name + "\" folder:");
                        if (_folder[index].PreviousFolder.Num <= 5 && _folder[index].PreviousFolder.Num >= 1) Console.WriteLine("No included folders!");
                        foreach (Folder fol in _folder)
                            if (fol.PreviousFolder == _folder[index]) Console.WriteLine(fol);
                    }
                }
                Console.WriteLine("\n--------------------Catalog---------------------");
                foreach (Folder fol in _folder)
                    if (fol.PreviousFolder.Num == 0 || fol.PreviousFolder.Num == 13) Console.WriteLine(fol);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Choose the folder to see it's included folders: ");
                index = Convert.ToInt32(Console.ReadLine());
                choosed = true;
            }
        }
    }
}
