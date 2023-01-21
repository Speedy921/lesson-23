Console.WriteLine("****A First Look at Interfaces****\n");
CloneableExample();

static void CloneableExample()
{
    //все эти классы поддерживют интерфейс ICloneable
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

    //все они могут быть переданы методу
    //применяющему параметр типа ICloneable
    CloneMe(myStr);
    CloneMe(unixOS);

    static void CloneMe(ICloneable c)
    {
        //клонирвать то, что получено и вывести имя
        object theClone = c.Clone();
        Console.WriteLine("YOur clone is a: {0}", theClone.GetType().Name);
    }
}
