[English](#english)\
[Deutsch](#deutsch)\
[Screenshots / Bildschrimfotos](#screenshots--bildschrimfotos)

# English

## German Vocabulary
This is a Windows Form App created with C#. The program is for learning new German words and studying them. It has text coloring (depending on the gender of nouns) and text-to-speech features

## Getting Started
### Dependencies
- The program was made with .Net 5.0. If you use .Net 3.1 or an older version to compile the project, make sure you change the file paths in the `StringLibrary` class

```csharp
public static readonly string CardsPath = "..\\..\\..\\data\\cards.xml";
public static readonly string OptionsPath = "..\\..\\..\\data\\options.txt";
```

- To be able to use the text-to-speech feature, the computer that the program is on must have German language feature installed

### How to Use
There are 2 types of studying features in the program. The first feature gives you random unstudied flashcards or old flashcards in order to study. The second feature gives you an option to review the flashcards that you studied in specific date(s)

While adding a new word to the program, the gender of the word affects which part(s) should be read by the text-to-speech feature. If the word has no gender then the text-to-speech feature only reads the singular form of the word. If the word has a gender then it reads the both singular and plural forms of the word

## License
This project is licensed under the MIT License - see the LICENSE.md file for details


# Deutsch

## Deutscher Wortschatz
  Das ist eine Windows-Form-App, die mittels C# erstellt wurde. Die Anwendung ist zum Lernen neuer deutscher Wörter. Sie hat eine Textfarbeneigenschaft (je nach dem Geschlecht von Nomen) und eine Text-to-Speech-Funktion

## Erste Schritte
### Abhängigkeiten
- Die Application wurde mit .Net 5.0 erstellt. Wenn Sie .Net 3.1 oder eine ältere Version verwenden, um das Projekt zu kompilieren, stellen Sie sicher, dass Sie die Dateipfad in der Klasse `StringLibrary` ändern

```csharp
public static readonly string CardsPath = "..\\..\\..\\data\\cards.xml";
public static readonly string OptionsPath = "..\\..\\..\\data\\options.txt";
```

- Um die Text-to-Speech-Funktion zu verwenden, muss der Computer, auf dem die Application läuft, die deutsche Sprache unterstützen

### Wie zu Verwenden
Es gibt 2 Typen von Lernfunktionen in der Application. Die erste Funktion gibt Ihnen zufällige ungelernte Karteikarten oder alte Karteikarten zu lernen. Die zweite Funktion gibt Ihnen eine Möglichkeit, um die Karteikarten zu lernen, die Sie in bestimmen Daten gelernt haben.

Beim Hinzufügen eines neuen Wort zur Application beeinflusst das Geschlecht vom Wort, welcher Teil durch der Text-to-Speech-Funktion gelesen wird. Wenn das Wort kein Geschlecht hat, liest die Text-to-Speech Funktion nur die Singularform vom Wort. Wenn das Wort ein Geschlecht hat, liest sie beide die Singular- und Pluralform vom Wort

## Lienz
Das Projekt wird unter der MIT-Lizenz lizenziert - sehen Sie die LICENSE.md Datei für Details

# Screenshots / Bildschrimfotos
![01](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/01.png)\
![02](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/02.png)\
![03](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/03.png)\
![04](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/04.png)\
![05](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/05.png)
