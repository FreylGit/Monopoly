using Monopoly;
ApplicationDbContext context = new ApplicationDbContext();
PalletServices palletServices = new PalletServices(context);

while (true)
{
    int btn;
    Menu();
    Console.Write("Ввод: ");
    btn = Convert.ToInt32(Console.ReadLine());
    switch (btn)
    {
        case 1:
            context.LoadDate();
            Console.WriteLine("Тестовые данные загрузились");
            break;
        case 2:
            ShowPallet(context);
            break;
        case 3:
            ShowGroupByExpiryDate(palletServices);
            break;
        case 4:
            ShowSortByExpirationDate(palletServices);
            break;
        case 5:
            ShowSortedGroupsByWeight(palletServices);
            break;
        case 6:
            ShowPalletMaxExpiryDateSortWigth(palletServices);
            break;
        default:
            break;
    }
}


static void Menu()
{
    Console.WriteLine("1 - Загрузить тестовые данные (Генерация прямо в приложении)");
    Console.WriteLine("2 - Показать все паллеты");
    Console.WriteLine("3 - Сгруппировать все паллеты по сроку годности ");
    Console.WriteLine("4 - Отсортировать по возрастанию срока годности");
    Console.WriteLine("5 - В каждой группе отсортировать паллеты по весу");
    Console.WriteLine("6 - 3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема");
}
static void ShowPallet(ApplicationDbContext context)
{
    var pallets = context.Pallets;
    foreach (var pallet in pallets)
    {
        Console.WriteLine(pallet);
    }
}
static void ShowGroupByExpiryDate(PalletServices palletServices)
{
    var groupedByExpiryDate = palletServices.GroupByExpirationDate();

    foreach (var group in groupedByExpiryDate)
    {
        Console.WriteLine($"Срок годности: {group.Key}");
        foreach (var pallet in group)
        {
            Console.WriteLine($"  Pallet ID: {pallet.ID}");
            foreach (var box in pallet.Boxes)
            {
                Console.WriteLine($"    Box ID: {box.ID}");
            }
        }
    }
}
static void ShowSortByExpirationDate(PalletServices palletServices)
{
    var palletsSort = palletServices.SortByExpirationDate();
    foreach (var pallet in palletsSort)
    {
        Console.WriteLine(pallet);
    }
}
static void ShowSortedGroupsByWeight(PalletServices palletServices)
{
    var groupedByExpiryDate = palletServices.GroupByExpirationDate();

    foreach (var group in groupedByExpiryDate)
    {
        Console.WriteLine($"Срок годности: {group.Key}");
        foreach (var pallet in group.OrderBy(p => p.Weight))
        {
            Console.WriteLine($"  Pallet ID: {pallet.ID}");
            Console.WriteLine($"  Вес: {pallet.Weight}");
        }
    }
}
static void ShowPalletMaxExpiryDateSortWigth(PalletServices palletServices)
{
    var pallets = palletServices.Pallets.OrderByDescending(p => p.ExpirationDate).Take(3).OrderBy(p => p.Weight);
    foreach (var pallet in pallets)
    {
        Console.WriteLine(pallet);
    }
}