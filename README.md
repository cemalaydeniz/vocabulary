<img src="https://img.shields.io/badge/Win%20Form-0078D4?style=for-the-badge&logo=windows&logoColor=white" />

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

# Screenshots
![01](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/01.png)\
![02](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/02.png)\
![03](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/03.png)\
![04](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/04.png)\
![05](https://raw.githubusercontent.com/cemalaydeniz/vocabulary/main/Screenshots/05.png)
