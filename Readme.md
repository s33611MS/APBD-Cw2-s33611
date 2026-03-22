Projekt stanowi wypożyczalnię sprzętu.

Zostały w nim jasno rozdzielone różne elementy:
- enumy
- wyjątki
- modele
- serwisy

Wśród modeli istnieje podział grupujący te powiązane między sobą:
- urządzenia i użytkownicy zawierają klasy abstrakcyjne oraz dziedziczące po nich specyficzne typy urządzeń/użytkowników
- modele mają za zadanie przechowywać informacje na swój temat

Serwisy zajmują się obsługą wydarzeń związanych z modelami.

Wysoka kohezja, każdy element pełni swoje jedno konkretne zadanie.
Są zaimplementowane modele odpowiedzialne za informacje, serwisy zapewniają obsługę wydarzeń etc.

Niski coupling, elementy są niezależne, zmiany w jednym nie skutkują potrzebą zmian w innym.
Nie są tworzone zbedne instancje które uzależniały by od siebie klasy. Łatwo można pracować nad zmianami bez efektu domina.
Widać to między innymi w serwisach.

Zastosowałem przedstawiony podział dla porządku i przejrzystości w projekcie.
Rozbicie projektu na klasy zajmujące się poszczególnymi problemami ułatwia skupianie się zadaniu jakie mają one pełnić.
Dodatkowo brak zależności ułatwia edycję i testowanie, nie wymagając niepotrzebnych zmian w pośrednich klasach.

Uruchomienie:
Cały scenariusz wymagany w zadaniu znajduje się w pliku Program.cs