// показать директорию
string path = "C:/Users/User/Desktop/learning/code.mu/typescript";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string ident = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{ident}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, ident + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{ident}{files[i].Name}");
    }
}

Console.Clear();
// string inputPath = Console.ReadLine();
// CatalogInfo(inputPath);
CatalogInfo(path);