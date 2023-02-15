# MechanicWebService
Nasza aplikacja to system zarządzania rezerwacjami w warsztacie samochodowym. Aplikacja umożliwia rezerwowanie usług przez klientów, a zarządzanie tymi usługami przez mechaników oraz pracowników warsztatu.

## Funkcjonalności

Aplikacja posiada następujące funkcjonalności:

+ Konta użytkowników: Klienci, mechanicy oraz pracownicy warsztatu mogą się zarejestrować i logować do systemu za pomocą swojego konta.
+ Rezerwacje: Klienci mogą przeglądać dostępne usługi oraz rezerwować terminy wizyty w warsztacie.
+ Zarządzanie rezerwacjami: Mechanicy i pracownicy warsztatu mogą przeglądać rezerwacje, edytować ich szczegóły, a także usuwać rezerwacje w razie potrzeby.
+ Usługi: W systemie zdefiniowane są usługi świadczone przez warsztat, a także ceny za poszczególne usługi.
+ Płatności: Klienci mogą dokonywać płatności za rezerwowane usługi. W systemie dostępne są różne metody płatności, takie jak karta kredytowa czy przelew.
+ Wypożyczalnia: Klienci mogą zobaczyć jakie samochody są dostępne

## Technologie

Aplikacja została napisana w technologii ASP.NET, z wykorzystaniem języka programowania C#. W bazie danych użyto SQLLite Aplikacja wykorzystuje także framework ASP.NET Identity, który umożliwia autoryzację oraz uwierzytelnienie użytkowników.

Instalacja
Aby uruchomić aplikację lokalnie, należy sklonować repozytorium oraz zainstalować niezbędne zależności poprzez menadżer pakietów NuGet. Następnie, jeśli aplikacja nie uruchamia się poprawnie usunąć aktualną bazę oraz migracje następnie należy utworzyć bazę danych oraz wprowadzić niezbędne migracje. Po wykonaniu tych kroków, aplikacja powinna działać poprawnie.
