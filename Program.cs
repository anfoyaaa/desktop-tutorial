using System;

namespace TimesYear
{
    enum Seasons
    {
        winter =1,
        spring = 2,
        summer = 3,
        autumn = 4
    }

    class TimesYear
    {
        class Seasons
        {
            public static Seasons[] a;
            public string wthr;
            public string name;

            public Seasons(string wthr, string name)
            {
                this.wthr = wthr;
                this.name = name;

            }


            public static Seasons[] CreateArray()

            {

               Seasons sdt;

                a = new Seasons[4];

                for (int j = 0; j < 4; j++)

                {



                    string wthr = "";



                    string name = "";



                    sdt = new Seasons (wthr, name);

                    a[j] = sdt;

                    Console.WriteLine();

                }

                return a;

            }

            public static void print(Seasons[] a)

            {

                a[0].wthr = "Температура 45*";

                a[1].wthr = "Температура -40*";

                a[2].wthr = "Температура 20*";

                a[3].wthr "Температура 13*";

                a[0].name = "Лето — одно из четырёх времён года, между весной и осенью, характеризующееся наиболее высокой температурой окружающей среды.";

                a[1].name = "Зима — одно из четырёх времён года, между периодами годового цикла осенью и весной.";

                a[3].name = "Осень (родственно др.-прусск. assanis — «осень», гот. аsans — «жатва», этимологически — «время жатвы»; по толкованию Даля — от «осенять» — затенять: наступление сумрака)";

                a[2].name = "Весна — одно из четырёх времён года, переходный сезон между зимой и летом";

                for (int i = 0; i < a.Length; i++)

                {

                    Console.WriteLine("-------------------------------------------------------------------");

                    Console.WriteLine(a[i].wthr);

                    Console.WriteLine(a[i].name);

                    Console.WriteLine("-------------------------------------------------------------------");



                }



                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {
            string s;

            Console.WriteLine("Ваше любимая пора года?(лето,зима,осень,весна)");

            s = Console.ReadLine();
            if (s == "лето")

            {

                Console.Write("Лето — одно из четырёх времён года, между весной и осенью, характеризующееся наиболее высокой температурой окружающей среды.");

                Console.WriteLine("В день летнего солнцестояния дни самые длинные, а ночи самые короткие.");

            }

            else if (s == "зима")

            {

                Console.Write("Зима — одно из четырёх времён года, между периодами годового цикла осенью и весной.Основной признак этого времени ");

                Console.WriteLine("года — устойчивая низкая температура(ниже 0 градусов по Цельсию) во многих районах Земли, на поверхность земли выпадает и ложится снег.");

            }

            else if (s == "осень")

            {

                Console.Write("Осень (родственно др.-прусск. assanis — «осень», гот. аsans — «жатва», этимологически — «время жатвы»; по толкованию Даля — от «осенять» — затенять: наступление сумрака)");

                Console.WriteLine(" — одно из четырёх времен года, между летом и зимой.");

            }
            else if(s==" весна")
            {
                Console.Write("Весна — одно из четырёх времён года, переходный сезон между зимой и летом");

                Console.WriteLine(" . Существуют различные методы определения начал и окончания весны, отличающиеся в зависимости от местного климата, культур и обычаев. Когда в Северном полушарии весна, то в Южном полушарии осень и наоборот.");

            }
            else

            {

                Console.WriteLine("Неправильная пора года выхожу!");

                Console.ReadKey();

                Environment.Exit(0);

            }



            Console.WriteLine("1-лето");

            Console.WriteLine("2-зима");

            Console.WriteLine("3-весна");

            Console.WriteLine("4-осень");

            int mb = int.Parse(Console.ReadLine());

            TellAboutPoriGoda(mb);

            Console.WriteLine("Введите лето или зима");

            string mb1 = Console.ReadLine();

            getDescription(mb1);

            Seasons[] a;

            a = Seasons.CreateArray();

        a: Seasons.print(a);



            Console.ReadKey();

        }

        private static void TellAboutPoriGoda(int mb)
        {
            throw new NotImplementedException();
        }

        private static void getDescription(string s)

        {

            if (s == "лето") Console.WriteLine("Теплое время года");

            else

            if (s == "зима") Console.WriteLine("Холодное время года");

        }

        private static void TellAboutSeasons(int mb)

        {

            double sr = 0;

            switch (mb)

            {

                case (int)Seasons.summer:

                    sr = 45; Console.WriteLine("Я люблю лето " + sr + "*"); break;

                case (int)Seasons.winter:

                    sr = -40; Console.WriteLine("Я люблю зиму " + sr + "*"); break;

                case (int)Seasons.spring:

                    sr = 20; Console.WriteLine("Я люблю весну " + sr + "*"); break;

                case (int)Seasons.autumn:

                    sr = 13; Console.WriteLine("Я люблю осень " + sr + "*"); break;

            }
        }

}