namespace teli_hogomb
{
    internal class Program
    {
        static List<string> cucc = new List<string>();
        static List<int> cuccSzam = new List<int>();
        static void Main()
        {
            bool fut = true;
            while (fut)
            {
                Console.WriteLine("Ez egy Téli Hógömb Készítő, amelyben különböző elemeket (pl. hópelyheket, fákat, házakat) adhatsz hozzá egy virtuális hógömbhöz.");
                Console.WriteLine("1.: Elemek hozzáadása\t2.: Tartalom megtekintése\n3.: Elem eltávolítása\t4.: Befejezés");
                int opcio = Convert.ToInt32(Console.ReadLine());

                switch (opcio)
                {
                    case 1:
                        Console.Clear();
                        Hozzaadas();
                        break;

                    case 2:
                        Console.Clear();
                        Megtekintes();
                        break;

                    case 3:
                        Console.Clear();
                        Torles();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Köszönjük hogy elkészített velünk egy hógömböt");
                        Console.WriteLine("Viszlát!");
                        fut = false;
                        break;

                }
            }
        }

        static void Hozzaadas()
        {
            Console.WriteLine("Mit szeretnél belerakni?");
            try
            {

                string ize = Convert.ToString(Console.ReadLine());

                if (string.IsNullOrEmpty(ize))
                {
                    throw new Exception("Az elem neve nem lehet üres!");
                }

                Console.WriteLine("Add meg hogy mennyi szertnél belőle");
                int izeSzam = Convert.ToInt32(Console.ReadLine());
            
                if (izeSzam <= 0)
                {
                    throw new Exception("A szám nem lehet 0 vagy negatív");
                }

                cucc.Add(ize);
                cuccSzam.Add(izeSzam);
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Nem fér ennyi a hógömbbe");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás formátum! Az elemek számát számként kell megadni.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
            
        }
    
        static void Megtekintes()
        {
            for (int i = 0; i < cucc.Count; i++)
            {
                Console.WriteLine($"{i+1}. {cucc[i]} - {cuccSzam[i]}");
            }
        }
    
        static void Torles()
        {
            try
            {
                Console.WriteLine("Mit szeretnél törölni?: ");
                string torolni = Console.ReadLine();

                if (string.IsNullOrEmpty(torolni))
                {
                    throw new Exception("A semmit nem tudom törölni");
                }
                if (cucc.Contains(torolni))
                {
                    for (int i = 0;i < cucc.Count;i++)
                    {
                    
                        if (cucc[i] == torolni)
                        {
                            Console.WriteLine($"Eltávolítva: {cucc[i]}");
                            int index = i;
                            cucc.RemoveAt(i);
                            cuccSzam.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    throw new Exception("Ez az elem nem található a hógömbben.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
        }
    }
}
