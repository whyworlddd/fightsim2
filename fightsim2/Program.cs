
int active = 1;
int restart = 0;

while (active == 1){

active = 1;
int hp1 = 100;
int hp2 = 100;
int RoundCount = 1;
restart = 0;


Console.WriteLine("-----WELCOME TO THE FIGHT OF FIGHTS-----");
Console.ReadLine();


while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine($"----ROUND {RoundCount}---------------------");

    int KickDamage = Random.Shared.Next(11); //KAN INTE BLI 10
    int PunchDamage = Random.Shared.Next(11);
    int WrestleDamage = Random.Shared.Next(11);    

    int enemyKickDamage = Random.Shared.Next(11);
    int enemyPunchDamage = Random.Shared.Next(11);
    int enemyWrestleDamage = Random.Shared.Next(11);    

    //finns nog mer effektiva sätt att göra detta, kan också göra så att fiendens attack blir slumpad med en hög av extra kod och ett till slumptal, men jag har bara en lektion på mig för v2.

    Console.WriteLine("________________________________");

    Console.WriteLine("choose attack:");
    Console.WriteLine($"1. Hero kick damage: {KickDamage}, enemy kick damage: {enemyKickDamage}");
    Console.WriteLine($"2. Hero punch damage: {PunchDamage}, enemy punch damage: {enemyPunchDamage}");
    Console.WriteLine($"3. Hero wrestle damage: {WrestleDamage}, enemy wrestle damage: {enemyWrestleDamage}");  
    //koden under är nog inte den bästa, men jag försökte...

    string attack = Console.ReadLine();
    
    attack = attack.ToLower();

    if (attack == "1")
    {

    Console.WriteLine("________________________________");
    hp1 = hp1-enemyKickDamage;
    hp2 = hp2-KickDamage;

    Console.WriteLine($"Hero dealt {KickDamage} damage");
    Console.WriteLine($"Evil guy dealt {enemyKickDamage} damage");

    Console.WriteLine($"Hero has {hp1} health remaining");
    Console.WriteLine($"evil guy has {hp2} health remaining");
    Console.WriteLine("________________________________");
    RoundCount = RoundCount+1;

    Console.ReadLine();
    } else if (attack == "2")
    {

    Console.WriteLine("________________________________");
    hp1 = hp1-enemyPunchDamage;
    hp2 = hp2-PunchDamage;

    Console.WriteLine($"Hero dealt {PunchDamage} damage");
    Console.WriteLine($"Evil guy dealt {enemyPunchDamage} damage");

    Console.WriteLine($"Hero has {hp1} health remaining");
    Console.WriteLine($"evil guy has {hp2} health remaining");
    Console.WriteLine("________________________________");
    RoundCount = RoundCount+1;
    Console.ReadLine();
    } else if (attack == "3")
    {

    Console.WriteLine("________________________________");
    hp1 = hp1-enemyWrestleDamage;
    hp2 = hp2-WrestleDamage;

    Console.WriteLine($"Hero dealt {WrestleDamage} damage");
    Console.WriteLine($"Evil guy dealt {enemyWrestleDamage} damage");

    Console.WriteLine($"Hero has {hp1} health remaining");
    Console.WriteLine($"evil guy has {hp2} health remaining");
    Console.WriteLine("________________________________");
    RoundCount = RoundCount+1;
    Console.ReadLine();
    } else
    {
        Console.WriteLine("sluta försöka förstöra min kod, välj attack.");
        Console.WriteLine();
    }




        if(hp1<0 && hp2 > 0)
    {
        Console.WriteLine("--------Evil guy won--------");
        Console.ReadLine();  
        active = active-1;
        restart = restart+1;
    }

    if(hp2<0 && hp1 > 0)
    {
        Console.WriteLine("--------Hero won--------");
        Console.ReadLine();
        active = active-1;
        restart = restart+1;
    }

    if(hp1<0 && hp2 < 0)
    {
        Console.WriteLine("--------its a draw--------");
        Console.ReadLine();
        active = active-1;
        restart = restart+1;
    }

}


}


if (active == 0 && restart == 1)
{
    Console.WriteLine("play again?");
    
    string playAgain = Console.ReadLine();

    playAgain.ToLower();

    if (playAgain == "yes")
    {
        active++;
    }
    else
    {
        Environment.Exit(0);
    }
//funkar ej, försökte men fick slut på tid, förstör dock ej koden.
}




//Break; gör så att en loop avslutas.  

