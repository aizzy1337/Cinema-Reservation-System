# Cinema-Reservation-System
Application that implements a cinema ticket reservation system with SQL Server and LiteDB. UI created with WinForms C#. University Project ~Arkadiusz Zając


## Schemat głównej bazy danych w SQL Server


Obsługa systemu rezerwacji biletów w kinie.

Opis tabeli:
- Movie - tabela przechowująca informacje o filmach (tytuł, długość itp.)
- Screening - tabela łącząca cała bazę, przechowuje informacje o seansach wyświetlanych w kinie, pobiera informacje o filmach, rezerwacjach, salach.
- Reservation - tabela przechowująca rezerwacje dokonane przez użytkownika, pobiera informacje o seansach i zarezerwowanych miejscach
- Seats_reserved - tabela przechowująca informacje o zarezerwowanych miejsca, pobiera informację o siedzeniach na sali
- Seats - tabela przechowująca numery wszystkich siedzeń na posczegółnych salach
- Room - tabela przechowująca informacje o sali i ilości miejsc

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/e956d980-4ad5-4d8d-a6f9-96e5965af9aa)


## Sposób połączenia z aplikacją (Procedury składujące)


Pobieranie i wstawianie informacji wkonałem w całości poprzez procedury składujące i triggery, aby jak najbardziej rozdzielić aplikację od bazy danych tym samym nadać większe bezpieczeństwo przechowywanym informacjom.

Przykłady:

Trigger obliczający czas zakończenia seansu na podstawie godziny rozpoczęcia i czasu trwania filmu.
![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/aa08019a-eced-4957-8f28-d6aa2a6d7f68)

Procedura wstawiająca informacje o seansie do bazy danych.
![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/7f3de6c8-25d1-4cd0-a026-83e7bbe4dfe0)

Lista procedur.

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/ddcf336f-1193-4908-aa38-bcbcd86714af)


## Dwie dodatkowe bazy danych NoSQL w LiteDB


Pierwsza baza przechowuje zdjęcia, które służa jako plakaty filmów.
![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/d5ea2164-b24a-4bed-b37c-2163ada6943d)

Druga baza przechowuje login i zaszyfrowane hasło (salt+hash)
![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/93ff9f44-f0c4-40fd-ba82-b9d3e623e27c)


## Połączenie baz do C# (ConnectionStrings)


![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/bc40b787-c500-4bee-a38f-614216838d30)


## Przykład klasy imitującej pola z bazy danych


![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/1593d5c8-d695-4a18-b8f0-c1b7007767aa)


## Przykład połączenia z SQL Server (z użyciem Dapper'a)


![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/946cb477-ce4f-44cf-b54a-f419a8f50ef3)


## Przykład połączenia z LiteDB


![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/ad355b7f-4451-4fb1-ad7a-70b0d6cd58c7)


# Aplikacja

Logowanie do panelu administratora

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/c6ea553e-0eaf-42a4-956a-e22adc1578ca)

Dodawanie filmu

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/b84ab3fc-107a-4edb-bdd5-ddbf2ff608bd)

Dodawanie sali kinowej

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/d80ff266-f6da-475e-9a44-ecf162212f55)

Dodawanie seansu

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/fbd5efb1-27e5-41f7-a55b-9ad7e8b19bcf)

Wybieraniu filmu

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/807fd262-26a2-4769-843a-3628ea49f843)

Wybieranie miejsc (Zielone - wolne, Czerwone - zarezerwowane, Pomarańczowe - obecnie wybrane)

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/e7a5aeeb-8c1c-48a1-aa82-ed2ad79bc7cc)

Potwierdzenie rezerwacji

![image](https://github.com/aizzy1337/Cinema-Reservation-System/assets/31189382/64ca63bf-cbc5-453f-bdc2-0094e481beff)

Arkadiusz Zając
