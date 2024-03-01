namespace Workshop2;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        MyList list = new MyList();

        while (true) {
            Menu.DisplayMenu();
            choice = Menu.GetChoice();
            Menu.ProcessChoice(choice, list);
        }
    }
}

