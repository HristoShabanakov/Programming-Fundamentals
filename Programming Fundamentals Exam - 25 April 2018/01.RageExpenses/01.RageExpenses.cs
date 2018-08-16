using System;


class RageExpenses
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int trashedHeadset = 0;
        int trashedMouse = 0;
        int trashedKeybord = 0;
        int trashedDisplay = 0;

        for (int i = 0; i < lostGames; i++)
        {   //Every second lost game, Pesho trashes his headset.
            trashedHeadset = lostGames / 2;
            //Every third lost game, Pesho trashes his mouse.
            trashedMouse = lostGames / 3;
            //When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard
            trashedKeybord = lostGames / 6;
            //Every second time, when he trashes his keyboard, he also trashes his display.
            trashedDisplay = lostGames / 12;

        }
        double total = trashedHeadset * headsetPrice + trashedMouse * mousePrice + keyboardPrice * trashedKeybord + trashedDisplay * displayPrice;
        Console.WriteLine($"Rage expenses: {total:f2} lv.");
    }
}
