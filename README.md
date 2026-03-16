# APBD CW1 Git
Ćwiczenia z Git i Github

## Merge bez fast-forward

Ten merge nie był `fast-forward`, ponieważ po utworzeniu gałęzi `feature-max`
pojawiły się nowe commity zarówno na `feature-max`, jak i na main.
Git nie mógł więc tylko przesunąć wskaźnika main i musiał utworzyć osobny commit merge.

## Zadanie 6 - Rebase

Po rebase commity z gałęzi `feature-min` zostały przeniesione na aktualny koniec `main`, dlatego historia stała się bardziej liniowa. Po połączeniu `feature-min` z `main` Git wykonał merge typu fast-forward, bez tworzenia osobnego commita merge.

### Krótkie porównanie merge i rebase

Po merge historia zachowuje rozgałęzienie i może zawierać osobny commit merge. Po rebase commity z gałęzi roboczej są przenoszone na aktualny koniec `main`, dzięki czemu historia staje się bardziej liniowa i uporządkowana.

## Odpowiedzi do oddania

### 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Git wykona **fast-forward**, gdy gałąź docelowa nie ma nowych commitów od momentu utworzenia drugiej gałęzi. Wtedy Git nie musi tworzyć osobnego commita merge, tylko przesuwa wskaźnik gałęzi do przodu.

**Merge commit** powstaje wtedy, gdy obie gałęzie mają własne nowe commity i ich historia się rozeszła. W takiej sytuacji Git musi utworzyć dodatkowy commit łączący obie linie historii.

### 2. Czym w praktyce różni się merge od rebase?

**Merge** łączy dwie gałęzie i zachowuje informację, że historia była rozgałęziona. W efekcie może powstać osobny commit merge.

**Rebase** przenosi commity z gałęzi roboczej na aktualny koniec innej gałęzi, najczęściej `main`. Dzięki temu historia staje się bardziej liniowa i uporządkowana, ale zmieniają się hashe commitów.

W praktyce:
- merge lepiej pokazuje rzeczywisty przebieg pracy na gałęziach,
- rebase daje czystszą i bardziej liniową historię.

### 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt został wywołany celowo na gałęzi `feature-conflict` i na `main` przez zmianę tego samego fragmentu w pliku `Program.cs`, czyli komunikatu wyświetlanego użytkownikowi.

Został rozwiązany świadomie, a nie losowo: obie wersje komunikatu zostały przeanalizowane i połączone w jedną końcową wersję `Console.WriteLine("Podaj liczby oddzielone spacjami, aby obliczyć średnią, więc wpisz taki przykład(np. 2 4 6) :");`, która zachowuje sens obu zmian. Następnie usunięto markery konfliktu, sprawdzono poprawność działania programu, dodano poprawiony plik do Git i zakończono merge commitem rozwiązującym konflikt.
