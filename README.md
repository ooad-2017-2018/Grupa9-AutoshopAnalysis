# Tema: AutoShopAnalysis :car::dash:

![Alt Text](https://media.giphy.com/media/l2R0e9y6A304JkFOg/giphy.gif)

![Alt Text](https://i.imgur.com/NbDovdB.gif)

## Članovi tima:
1. Ćazim Rahić
2. Mustafa Zukić
3. Nejira Musić

## Opis teme
Aplikacija **AutoshopAnalysis** ima za cilj da pojednostavi kupovinu i prodaju automobila. Kupovinu i prodaju automobila olakšava detaljna analiza i statistika prodaje, cijena, kvarova i drugih, kupcima važnih, osobina automobila. Korisnici aplikacije, nakon registracije, mogu kupovati ili prodavati automobile po želji, a također učešćem u anketi mogu pomoći i u analizi statistike. Također, registrovani korisnici mogu međusobno komunicirati putem privatnih poruka ili postavljati jedni drugim javna pitanja vezana za kupovinu/prodaju, kao i ulaziti u diskusije i razgovore vezane za određene automobile. Omogućeno je online plaćanje karticom ili gotovinom na adresi autoshop-a. Analizom i statistikom se bavi uposlenik, koji ima uvid u kupovinu i prodaju. 

## Procesi
- ### Pregled aplikacije

Na početnoj stranici prikazuje se izbornik: posjetitelj može pristupiti kao gost i pogledati statistiku i automobile u ponudi, ili se može registrirati.

- ### Registracija korisnika

Da bi posjetitelj mogao prodavati ili kupovati automobile, učestovati u anketi ili uspostaviti komunikaciju sa drugim korisnicima, prethodno se mora registrirati. Od korisnika koji se želi registrirati traže se sljedeći podaci:

  1. Ime
  2. Prezime
  3. Username
  4. Password
  5. E-mail
  6. Kontakt telefon
  7. Podaci o kreditnoj kartici
  
  - ### Registracija autosalona
  
  Da bi ostvarili bolju i jednostavniju prodaju, autosaloni se također mogu registrirati. Sve što je potrebno je da unesu:
  
  1. Naziv autosalona
  2. Username
  3. Password
  4. Adresu
  5. Podatke o bankovnom računu
  
  Registrovani autosaloni mogu učestovati i u analizi.
  
  - ### Prodaja automobila
  
  Da bi objavili automobil koji žele prodati, potrebno je da korisnici unesu sljedeće informacije o automobilu: 
  
  1. Proizvođač
  2. Model
  3. Stanje (novo ili korišteno)
  4. Godište
  5. Kilometraža
  6. Gorivo
  7. Kubikaža
  8. Konjskih snaga
  9. Pogon
  10. Tip
  11. Broj vrata
  12. Veličina felgi
  13. Emisioni standard
  14. Transmisija
  15. Boja
  16. Ozvučenje/Muzika
  17. Broj prethodnih vlasnika (ako je vozilo korišteno)
  18. Airbag
  19. ABS
  20. Alu felge
  21. Centralna brava
  22. Daljinsko otključavanje
  23. ESP
  24. Električni podizači stakla
  25. Električni retrovizori
  26. ISOFIX
  27. Klima
  28. Metalik
  29. Ocarinjen
  30. Servisna knjiga
  31. Servo volan
  32. Start-Stop sistem
  33. Tempomat
  34. Touchscreen
  35. Turbo
  36. Garancija
  
  Potrebno je još dodati i slike vozila, a po želji se može dodati i detaljniji opis. Garancija se može odrediti na osnovu statističkih podataka o kvarovima na određenom modelu automobila. Nakon prodaje, korisnik treba ažurirati artikal, odnosno naznačiti da je prodat, nakon čega se briše iz baze i ažurira se statistika.
  
  - ### Kupovina automobila
  
  Kupovina automobila se vrši jednostavno odabirom automobila, uplatom na navedeni račun ili plaćenjem gotovinom na adresi autoshop-a, nakon čega se u dogovoru sa prodavaocem vrši preuzimanje istog. 
  
  - ### Pretraživanje 
  
  Svi korisnici aplikacije, kako registrirani tako i neregistrirani, su u mogućnosti da pretražuju automobile tako što upišu naziv traženog automobila nakon čega se pojavi lista automobila sa navedenim nazivom. Također su u mogućnosti da filtriraju pretragu tako što izaberu željene osobine automobila. 
  
  - ### Pregled statistike
  
  Korisnici aplikacije su u mogućnosti da pregledaju statistiku o najprodavanijim i najmanje prodavanim automobilima, najčešćim vrstama kvarova i popravki i sl. Statistiku ažurira uposlenik na osnovu podataka o kupovini i prodaji, te na osnovu rezultata ankete. 
  
  ## Funkcionalnosti
  
  Funkcionalnosti aplikacije:
  - Pregled automobila
  - Pregled statistike i analize
  - Pretraga po raznim parametrima (model, cijena, godište...)
  - Mogućnost učestovanja u anketi
  - Kupovina automobila
  - Prodaja automobila
  - Komunikacija sa ostalim korisnicima aplikacije
  - Učestovanje u javnim diskusijama vezanim za određene artikle
  - Online plaćanje
  
  ## Akteri
  1. Administrator: Održava stranicu,  
  2. Gost korisnik: Pregled objavljenih automobila, pregled statistike, 
  3. Registrirani korisnik: Prodaja i kupovina automobila, učestovanje u anketi, slanje privatnih poruka ostalim registriranim korisnicima, učestovanje u javnim razgovorima/diskusijama, 
  4. Registrirani autosalon (pravno lice): Prodaja i kupovina automobila, učestovanje u anketama, slanje izvještaja o izvršenim prodajama koje nisu izvršene putem aplikacije, komunikacija sa ostalim registriranim korisnicima, 
  5. Uposlenik: Odobrava prodaju i kupovinu automobila, briše prodate artikle, vrši ažuriranje statistike na osnovu kupovine, prodaje i rezultata ankete, 
  6. Sistem za autorizaciju i naplatu karticom: Provjerava validnost uplate
