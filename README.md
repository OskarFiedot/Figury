# Figury

## Opis 
Powyższy program jest prostą grą matematyczną typu serious game, polegającą na dopasowywaniu odpowiednich wartości liczbowych, do odpowiadających im figur. 
Została napisana w ramach projektu programistycznego na studia, z myślą o możliwych walorach edukacyjnych dla dzieci na poziomie podstawówki, które chciałyby
w pewien sposób "wyrobić sobie" poczucie co do wielkości liczb, zapisanych na różne sposoby. Pojawiać mogą się też liczby z potęgami, logarytmy lub silnie, 
co mogłoby też w pewien sposób zachęcić do wykraczania ze swoją wiedzą poza ramowy program nauki w szkołach podstawowych. Na wyższych poziomach, liczby są przedstawiane
w postaci obliczeń, w których pojawia się mnożenie, dzielenie, potęgowanie, silnie oraz logarytmy, co wymaga pewnej zdolności do, chociaż przybliżonych, szybkich obliczeń
w pamięci oraz szacowania wyniku. 

## Zasady
Po odpaleniu gry, na ekranie wyświetla się okno, w którym w górnej części znajdują się trzy figury, w lewym górnym rogu numer poziomu, a w prawym górnym roku stoper,
odliczający czas, spędzony nad danym poziomem. W dolnej części okna znajdują się dwa pola do porównywania figur (a konkretnie liczb, które są im przypisane),
poniżej liczby, które należy przypisać do odpowiednich figur (przesunąć je kursorem do pól, nad odpowiednimi figurami), oraz w prawym dolnym rogu przyciski do zresetowania
pozycji figur oraz liczb, zakończenia gry oraz do sprawdzenia czy przypisanie jest poprawne. 

![image](https://user-images.githubusercontent.com/100859707/157265578-c705f0da-6410-45be-bc7b-fde7fe5908fa.png)

Gra zaczyna się zawsze od poziomu pierwszego (z dziesięciu), postępy nie są zapisywane, gracz ma za zadanie w określonym czasie przyporządkować liczby, wyświetlane w dolnej
części okna, do odpowiednich figur. Figury można przeciągać myszką, należy przeciągać po jednej figurze w puste pole po lewej i prawej stronie okna, aby zobaczyć, która
figura ma przypisaną większą liczbę. W ten sposób, drogą dedukcji, należy określić, której figurze trzeba przypisać największą liczbę, której najmniejszą, itp. 
Jest to oczywiście bardzo proste, jednak z każdym następnym poziomem, może być coraz trudniej określić, która z wyświetlonych na dole okna liczb jest największa, a która
najmniejsza. Liczby należy również przeciągać myszką, do odpowiednich pól nad figurami, jednak te liczby nie podążają za myszką, tak jak figury, a są kopiowane, do tych pól. 

![image](https://user-images.githubusercontent.com/100859707/157271477-dc28db44-d380-4c4e-a8db-499dc358b97d.png)

Każdy poziom ma swój limit czasowy, przekroczenie tego limitu nie przerywa gry, jednak nawet jeśli gracz dobrze przypisze wszystkie liczby, będzie musiał powtórzyć
ten poziom i zmieścić się w limicie czasowym, aby przejść dalej. Na koniec gry, czyli po przejściu wszystkich poziomów, lub po naciśnięciu przycisku zakończenia,
wyświetlają się ogólne statystyki rozgrywki, takie jak czas całej gry, liczba popełnionych błędów, liczba pokonanych oraz pozostałych poziomów. Pojawia się również opcja
rozpoczęcia gry od nowa. 

#### Gra została napisana w całości w języku C#, z .Net 5, z zastosowaniem Windows Forms. W programie został użyty NuGet 'Control.Draggable', autorstwa intrueder. 
