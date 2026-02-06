namespace Digitalis_NyomozoIroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Személy sz1 = new Személy("Bekre Pál",28,"Fekete rövid haj, kb: 190cm, fehér bőrű férfi");
			Személy sz2 = new Személy("Lakatos Márió", 20, "kopasz, kb: 175cm, barna bőrű férfi");
			Személy sz3 = new Személy("Kiss András", 29, "szőke haj, kb: 190cm, fehér bőrű férfi");
			Bizonyíték b1 = new Bizonyíték("FEGYVER1","kamerafelvétel","maroklőfegyver, valószínűleg GLOCK-19-es típusú",4);
			Bizonyíték b2 = new Bizonyíték("Újlenyomat1","fotó","nagymennyiségű újlenyomat található a bolton belül",5);
			Felhasználó nyomozó = new Felhasználó("Bendős Dávid","IEA38234","Nyomozó");
            Ügy boltibünügy = new Ügy("BOLT001","Sarki bolti rablás","Délután 5-kor kettő lőfegyverrel rendelkező maszkos féri 20.000ft értékben tulajdonított el árut a sakri boltbol.","folyamatban");
			boltibünügy.szemelyhozzaadas(sz1);
			boltibünügy.szemelyhozzaadas(sz2);
			boltibünügy.bizonyitekhozzaadas(b1);
			boltibünügy.bizonyitekhozzaadas(b2);
			Console.WriteLine(boltibünügy);
			Gyanusított gy1 = new Gyanusított(sz2,90,"megfigyelt");
			Tanú t1 = new Tanú(sz3, "A rablás során egy bokor mögött megbújva, szemtanúja voltam az egész büncselekménynek. A telefonommal rögzítettem az egészet",2026,02,14);
			Console.WriteLine(gy1);
			Console.WriteLine(t1);
		}
    }
}
