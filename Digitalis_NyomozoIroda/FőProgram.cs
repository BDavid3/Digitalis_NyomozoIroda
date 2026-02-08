using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class FőProgram
	{
		public static void Main(string[] args)
		{
			bool runningMain = true;
            string mainInput;
			ÜgyKezelő ugyKezelő = new ÜgyKezelő();
			SzemélyKezelő szemelyKezelő = new SzemélyKezelő();
			BizonyitekKezelő bizonyitekKezelő = new BizonyitekKezelő();

            while (runningMain)
			{
                // FŐMENÜ
                Console.WriteLine("\n╔══════════════════════════════════╗");
                Console.WriteLine("║   DIGITÁLIS NYOMOZÓ IRODA        ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("1. Ügyek kezelése");
                Console.WriteLine("2. Személyek kezelése");
                Console.WriteLine("3. Bizonyítékok kezelése");
                Console.WriteLine("4. Idővonal megtekintése");
                Console.WriteLine("5. Elemzés/döntések");
                Console.WriteLine("6. Kilépés");
                Console.Write("\nVálasszon (1-6): ");

                mainInput = Console.ReadLine();
				switch (mainInput)
				{
					case "1":
						
						bool runningUgy = true;
						while (runningUgy)
						{
                            Console.WriteLine($"\n--- ÜGYEK KEZELÉSE ---");
                            Console.WriteLine("1. Új ügy létrehozása");
                            Console.WriteLine("2. Ügyek listázása");
                            Console.WriteLine("3. Vissza a főmenübe");
                            Console.Write("\nVálasszon (1-3): ");

                            string ugyInput = Console.ReadLine();

                            switch (ugyInput)
                            {
                                case "1":
                                    ugyKezelő.ujUgyLetrehozas();
                                    break;
                                case "2":
                                    ugyKezelő.ugyekListazasa();
                                    break;
                                case "3":
									runningUgy = false;
                                    break;
                            }
                        }
						break;
					case "2":

						bool runningszemelyek = true;
						while (runningszemelyek)
						{
                            Console.WriteLine($"\n--- SZEMÉLYEK KEZELÉSE ---");
                            Console.WriteLine("1.Személy hozzáadása egy ügyhöz");
                            Console.WriteLine("2. Vissza a főmenübe");
                            Console.Write("\nVálasszon (1-2): ");

							string szemelyInput = Console.ReadLine();

							switch (szemelyInput)
							{
								case "1":
									szemelyKezelő.szemelyHozzaAdas(ugyKezelő);
                                    break;
								case "2":
									runningszemelyek = false;
                                    break;
                            }
                        }
                            break;
					case "3":
						bool runningbizonyitek = true;
						while (runningbizonyitek)
						{
                            Console.WriteLine($"\n--- BIZONYÍTÉKOK KEZELÉSE ---");
                            Console.WriteLine("1.Bizonyíték hozzáadása egy ügyhöz");
                            Console.WriteLine("2.Vissza a főmenübe");
                            Console.Write("\nVálasszon (1-2): ");

							string bizonyitekInput = Console.ReadLine();

							switch (bizonyitekInput)
							{
								case "1":
									bizonyitekKezelő.bizonyitekHozzaAdas(ugyKezelő);
									break;
								case "2":
									runningbizonyitek = false;
									break;
                            }
                        }
                            break;
                }    
            }

	    }

	}
}

