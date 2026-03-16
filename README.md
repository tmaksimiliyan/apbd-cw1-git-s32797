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
