int determinant = 0;      //определитель для выбора единицы массива
string? temp, revNum = "",resote = ""; 
string[] single = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
string[] dozens = { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шесдесят", "семдесят", "восемдесят", "девяносто" };
string[] binomial = { "одиннадцать", "двеннадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семьмяндцать", "восемьнадцать", "девятнадцать" };
string[] hundrs = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "десятьсот" };

Console.WriteLine("Ввидите число от 0 до 9999");//ввод числа
string? num = Console.ReadLine();
int trynum = Convert.ToInt32(num);
if (0 < trynum && trynum < 10000)
{ 
    foreach (char i in num) // инвертирование массива(типа)
    revNum = i + revNum;

    foreach (char item in revNum)
    {
        ++determinant;
        if (item -'0'  != 0) //проверка на нуль
        {
            temp = determinant switch           //выборка единицы массивов
            {
                1 => single[(item - '0') - 1],
                2 => dozens[(item - '0') - 1],
                3 => hundrs[(item - '0') - 1],
                4 => single[(item - '0') - 1],
                _ => "Вы маслов?" 
            }; 

            if (revNum[0] != 0 && item - '0' == 1 && determinant == 2)   //двучисленные числа
             resote = binomial[(revNum[0] - '0') - 1]; 
            else if (determinant == 4) 
            {
                temp = (item - '0') switch           //выборка единицы массивов
                {
                    1 => "одна тысяча ",
                    2 => "две тысячи ",
                    _ => temp + " тысячь "
                } ;
                    resote = temp  + resote;
                    
            }
               
            else
            resote = temp + " " + resote;
        }
    }
    Console.WriteLine(resote);
}
else 
{
    Console.WriteLine("Вы маслов?");
}






