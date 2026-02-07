using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;
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
                }
            }

			
			/*if (bekeres == "1")
			{
				Console.WriteLine("Az ügyek kezelését választotta:\n");
				string ugy;
				Console.WriteLine("1. Új ügy létrehozása\n2. Ügyek listázása\n3. Vissza");
				Console.Write("Adjon meg egy számot a felsoroltak közül: ");
				ugy = Console.ReadLine();
				if (ugy == "1")
				{
					Console.WriteLine("Kérem adja meg az ügy azonosítóját: ");
					string azonosito = Console.ReadLine();
					Console.WriteLine("Kérem adja meg a címét: ");
					string cim = Console.ReadLine();
					Console.WriteLine("Kérem adja meg a leírását: ");
					string leiras = Console.ReadLine();
					Console.WriteLine("Kérem adja meg az állapotát: ");
					string allapot = Console.ReadLine();
					Ügy ugynev = new Ügy(azonosito, cim, leiras, allapot);
					Console.WriteLine("Kérem adja meg a hozzá tartozó személyek számát: ");
					int szemelyekszama = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i < szemelyekszama; i++);
					{
						Console.WriteLine("Személy neve: ");
						string neve = Console.ReadLine();
						Console.WriteLine("Személy életkora: ");
						int eletkor = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Megjegyzés: ");
						string megjegyzes = Console.ReadLine();
						Személy letrehozott = new Személy(neve, eletkor, megjegyzes);
						ugynev.szemelyhozzaadas(letrehozott);
					}
					Console.WriteLine("Kérem adja meg a hozzá tartozó bizonyítékok számát: ");
					int bizonyitekokszama = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i < bizonyitekokszama; i++) ;
					{
						Console.WriteLine("Bizonyíték azonosítója: ");
						string azonosit = Console.ReadLine();
						Console.WriteLine("Típusa: ");
						string tipus = Console.ReadLine();
						Console.WriteLine("Leírás: ");
						string leir = Console.ReadLine();
						Console.WriteLine("Megbizhatósági érték(1-5): ");
						int megbizhat = Convert.ToInt32(Console.ReadLine());
						Bizonyíték létrehozott = new Bizonyíték(azonosit, tipus, leir, megbizhat);
						ugynev.bizonyitekhozzaadas(létrehozott);
					}


				}
				else if (ugy == "2")
				{

				}
				else if (ugy == "3")
				{
					Console.WriteLine("\n");
					Main(args);
				}
				else
				{
					Console.WriteLine("Rossz értéket adtál meg!\n");
					Main(args);
				}
			}
			else if (bekeres == "2")
			{

			}
			else if (bekeres == "3")
			{

			}
			else if (bekeres == "4")
			{

			}
			else if (bekeres == "5")
			{

			}
			else if (bekeres == "6")
			{
				Environment.Exit(0);
			}
			else
			{
				Console.WriteLine("Rossz értéket adtál meg!\n");
				Main(args);
			}*/
			Felhasználó elemző = new Felhasználó("Bendős Dávid", "IEA38234", "elemző");
			Személy artatlan = new Személy("Bekre Pál", 28, "Fekete rövid haj, kb: 190cm, fehér bőrű férfi");
			Személy gyanusitott = new Személy("Lakatos Márió", 20, "kopasz, kb: 175cm, barna bőrű férfi");
			Személy tanu = new Személy("Kiss András", 29, "szőke haj, kb: 190cm, fehér bőrű férfi");
			Bizonyíték fegyverbiz = new Bizonyíték("FEGYVER1", "kamerafelvétel", "maroklőfegyver, valószínűleg GLOCK-19-es típusú", 4);
			Bizonyíték ujlenyomatbiz = new Bizonyíték("Újlenyomat1", "fotó", "nagymennyiségű újlenyomat található a bolton belül", 5);
			Ügy boltibünügy = new Ügy("BOLT001", "Sarki bolti rablás", "Délután 5-kor lőfegyverrel rendelkező maszkos féri 20.000ft értékben tulajdonított el árut a sakri boltbol.", "folyamatban");
			boltibünügy.szemelyhozzaadas(artatlan);
			boltibünügy.szemelyhozzaadas(gyanusitott);
			boltibünügy.bizonyitekhozzaadas(fegyverbiz);
			boltibünügy.bizonyitekhozzaadas(ujlenyomatbiz);


		/*
		Tanú t1 = new Tanú(sz3, "A rablás során egy bokor mögött megbújva, szemtanúja voltam az egész büncselekménynek. A telefonommal rögzítettem az egészet", 2026, 02, 14);
		Gyanusított gy1 = new Gyanusított(sz2, 90, "megfigyelt");
		IdővonalEsemény i1 = new IdővonalEsemény(2026, 02, 12, "Bolt körüli szokatlan viselkedések");
		Console.WriteLine(boltibünügy);
		Console.WriteLine(gy1);
		Console.WriteLine(t1);
		Console.WriteLine(i1); */
	}

	}
}

