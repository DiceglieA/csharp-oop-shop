//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//-codice(numero intero)
//- nome
//- descrizione
//- prezzo
//- iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.
using csharp_oop_shop;

Prodotto penna = new Prodotto("Penna", "Penna nera", 3, 0.23f);
Prodotto latte = new Prodotto("Latte", "Bevanda", 2, 0.04f);
Prodotto macchinina = new Prodotto("Giocattolo", "Macchinina radiocomandata", 10, 0.23f);

Console.WriteLine(penna.ToString());
Console.WriteLine(latte.ToString());
Console.WriteLine(macchinina.ToString());

Console.WriteLine(penna.nomeEsteso());
Console.WriteLine(latte.nomeEsteso());
Console.WriteLine(macchinina.nomeEsteso());
