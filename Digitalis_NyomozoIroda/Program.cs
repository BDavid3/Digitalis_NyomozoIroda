namespace Digitalis_NyomozoIroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Személy sz1 = new Személy("Bekre Pál",28,"Fekete rövid haj, kb: 190cm, fehér bőrű férfi");
			Személy sz2 = new Személy("Lakatos Márió", 20, "kopasz, kb: 175cm, barna bőrű férfi");
			Felhasználó nyomozó = new Felhasználó("Bendős Dávid","IEA38234","Nyomozó");
            Ügy bünügy = new Ügy("IEZD2393672","Sarki bolti rablás","Délután 5-kor lőfegyverrel rendelkező, maszkos féri 20.000ft értékben tulajdonított el árut a sakri boltbol.","folyamatban");
			Console.WriteLine(nyomozó);
			bünügy.szemelyhozzaadas(sz1);
            //bünügy.szemelyeklekerdezese();
		}
    }
}
