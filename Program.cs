using System;
using System.IO;


for(;;)
{
System.Console.WriteLine(@"""1. Показать информацию о дисках
2. Управление каталогами
3. Управление файлами
4. Выход""");
Console.Write("Ваш выбор: ");
    int choise=int.Parse(Console.ReadLine());
    if(choise==0 || choise>4)
    {
        System.Console.WriteLine("Не конкретное действие!");
        return 0;
    }
    if(choise==4)
    {
        System.Console.WriteLine("Вы вишли из программы!");
        return 0;
    }
    if(choise==1)
    {
        System.Console.WriteLine(@"""При выборе этого пункта программа:

- Выводит список всех доступных дисков.
- Для каждого диска отображает:
- Метку тома
  - Тип файловой системы
  - Общий размер диска
  - Доступное место
  - Состояние диска (готов/не готов)""");

 
  
    DriveInfo[] drives = DriveInfo.GetDrives();
    foreach (var drive in drives)
    {
        Console.WriteLine($"Диск: {drive.Name}");
        if (drive.IsReady)
        {
            Console.WriteLine($"  Метка тома: {drive.VolumeLabel}");
            Console.WriteLine($"  Тип файловой системы: {drive.DriveFormat}");
            Console.WriteLine($"  Общий размер: {drive.TotalSize} байт");
            Console.WriteLine($"  Доступное место: {drive.AvailableFreeSpace} байт");
        }
        else
        {
            Console.WriteLine("  Диск не готов.");
        }
    }

 }
  if(choise==2)
  {
    string path="D:\\Dapper\\";
    DirectoryInfo directoryInfo=new DirectoryInfo(path);
    DirectoryInfo[] directories =new DirectoryInfo[]{};
    directoryInfo.Create();
    directoryInfo.Delete();
    foreach(DirectoryInfo d in directories)
    {
        System.Console.WriteLine(d.Attributes);
        System.Console.WriteLine(d.FullName);
        System.Console.WriteLine(d.Extension);
        System.Console.WriteLine(d.CreationTime);
        System.Console.WriteLine(d.LastWriteTime);
    }
      }
      if(choise==3)
      {
        string path="D:\\Dapper\\File";
        File.Create(path);
        File.OpenText(path);
        File.Delete(path);
       FileInfo[] files=new FileInfo[]{};
       foreach(FileInfo f in files)
       {
            System.Console.WriteLine(f.FullName);
            System.Console.WriteLine(f.DirectoryName);
            System.Console.WriteLine(f.Length);
            System.Console.WriteLine(f.CreationTime);
       }
        
      }

}
    
