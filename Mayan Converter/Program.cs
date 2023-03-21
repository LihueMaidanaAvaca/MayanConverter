int day = 0;
int month = 0;
int year = 0;
int firstNum = 0;
int secondNum = 0;
int key = 0;
int kinNum = 0;
int moon = 0;
int sun = 0;
string tone = "";
string seal = "";

Console.WriteLine("Ingrese su fecha de nacimiento:");
day = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su mes de nacimiento:");
month = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su año de nacimiento:");
year = int.Parse(Console.ReadLine());

Console.WriteLine($"Tu nacimietno fue el {day} {month} {year}");

switch (month)
{
    case 1:
        firstNum = day + 54;
        break;
    case 2:
        firstNum = day + 85;
        break;
    case 3:
        firstNum = day + 113;
        break;
    case 4:
        firstNum = day + 144;
        break;
    case 5:
        firstNum = day + 174;
        break;
    case 6:
        firstNum = day + 205;
        break;
    case 7:
        firstNum = day + 235;
        break;
    case 8:
        firstNum = day + 6;
        break;
    case 9:
        firstNum = day + 37;
        break;
    case 10:
        firstNum = day + 67;
        break;
    case 11:
        firstNum = day + 98;
        break;
    case 12:    
        firstNum = day + 128;
        break;
    default:
        Console.WriteLine("Hubo un valor mal ingresado");
        break;
}

if (year < 1957){
    do{
        year += 52;
    } while (year < 1957);
    key = year;
    }
else if (year >= 2009){
    do{
        year -= 52;
    } while (year > 2009);
    key = year;
    }
else{
    key = year;
    }

char[] keyChars = (key - 1957).ToString().ToCharArray();

if (keyChars.Length == 1)
{
    Array.Resize(ref keyChars, keyChars.Length + 1);
    Array.Copy(keyChars, 0, keyChars, 1, keyChars.Length - 1);
}

int unit = int.Parse(keyChars[1].ToString());
int tens = int.Parse(keyChars[0].ToString()) * 10;

switch (unit)
{
    case 0: 
        secondNum = tens + 3;
        break;
    case 1:
        secondNum = tens + 108;
        break;
    case 2:
        secondNum = tens + 213;
        break;
    case 3:
        secondNum = tens + 58;
        break;
    case 4:
        secondNum = tens + 163;
        break;
    case 5:
        secondNum = tens + 8;
        break;
    case 6:
        secondNum = tens + 113;
        break;
    case 7:
        secondNum = tens + 218;
        break;
    case 8:
        secondNum = tens + 63;
        break;
    case 9:
        secondNum = tens + 168;
        break;
    default:
        Console.WriteLine("algo salio mal");
        break;
}

kinNum = firstNum + secondNum;

if (kinNum > 260)
{
    kinNum -= 260;
}

moon = kinNum;

if (moon > 13){
    do
    {moon -= 13;
    } while (moon > 13);
}

sun = kinNum;

if (sun >= 20) { 
    do
    { sun -= 20;
    } while (sun >= 20);
}



switch (moon)
{
    case 1:
        tone = "Hun";
        break;
    case 2:
        tone = "Ka";
        break;
    case 3:
        tone = "Ox";
        break;
    case 4:
        tone = "Kan";
        break;
    case 5:
        tone = "Ho";
        break;
    case 6:
        tone = "Uak";
        break;
    case 7:
        tone = "Uuk";
        break;
    case 8:
        tone = "Uaxak";
        break;
    case 9:
        tone = "Bolon";
        break;
    case 10:
        tone = "Lahun";
        break;
    case 11:
        tone = "Buluk";
        break;
    case 12:
        tone = "Lahak";
        break;
    case 13:
        tone = "Oxlahun";
        break;
    default:
        Console.WriteLine("Algo salio mal");
        break;
    }

switch (sun)
{
    case 0:
        seal = "Ahau";
        break;
    case 1:
        seal = "Imix";
        break;
    case 2:
        seal = "Ik";
        break;
    case 3:
        seal = "Akban";
        break;
    case 4:
        seal = "Kan";
        break;
    case 5:
        seal = "Chicchan";
        break;
    case 6:
        seal = "Kimi";
        break;
    case 7:
        seal = "Manik";
        break;
    case 8:
        seal = "Lamat";
        break;
    case 9:
        seal = "Muluc";
        break;
    case 10:
        seal = "Oc";
        break;
    case 11:
        seal = "Chuen";
        break;
    case 12:
        seal = "Eb";
        break;
    case 13:
        seal = "Ben";
        break;
    case 14:
        seal = "Ix";
        break;
    case 15:
        seal = "Men";
        break;
    case 16:
        seal = "Kib";
        break;
    case 17:
        seal = "Kaban";
        break;
    case 18:
        seal = "Etznab";
        break;
    case 19:
        seal = "Kauak";
        break;
    default:
        Console.WriteLine("Algo salio mal");
        break;
}

Console.WriteLine($"Tu Kin es el numero {kinNum}: {tone} {seal}");