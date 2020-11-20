Здравствуйте укажаемые коллеги!

Так как я давно занимаюсь программированием, то часть технологий, используемых в работе, применил и для написания/хранения лекций и методических материалов. Чем и хочу с Вами поделиться.

Набор используемых технологий:

* система контроля версий
* язык текстовой разметки [MarkDown](https://ru.wikipedia.org/wiki/Markdown)
* визуальный текстовый редактор Visual Studio Code

## Система контроля версий Git

> Вообще, эта технология используется для отслеживания версий программного обеспечения и возможности её намного шире тех, которые я опишу дальше.

1. Публичный репозиторий (хранилище) проектов. Т.е. доступ к проекту (в нашем случае текст лекции) доступен всем в интернете (есть еще приватные репозитории, если вдруг вы захотите использовать СКВ в других целях)

2. Поддержка языка текстовой разметки MarkDown

Таким образом, используя репозиторий на GitHab-е мы избавляемся от необходимости печатать лекции на бумаге, таскать их на флешке или пересылать по почте.

## Язык текстовой разметки MarkDown

**Markdown** (произносится маркда́ун) — облегчённый язык разметки, созданный с целью обозначения форматирования в простом тексте, с максимальным сохранением его читаемости человеком, и пригодный для машинного преобразования (на GitHub-е как раз и отображается преобразованный текст)

Раз это *простой текст*, то редактировать его можно даже в блокноте, но есть и более удобные редакторы, про которые я расскажу позже.

Примеры разметки:

### Текст с выделением

\*выделение\* (например, *курсив*)

\*\*сильное выделение\*\* (например, **полужирное** начертание)

\_\*\*_**комбинация**_\*\*\_ курсива и полужирного начертания

>Причем без разницы в каком порядке использовать символы ``*`` и ``_``

\~\~~~зачёркнутый~~\~\~ текст

### Программный код

Выделяется знаком апострофа "\`", может быть как `внутри строки`

\`\`\`
```
так 
и 
отдельным
блоком
```
\`\`\`

>Так можно оформлять не только программный код, но и любой текст, в котором нужно сохранить оригинальное форматирование. Дело в том, что MarkDown, как и практически любой язык верстки обрезает пустые строки и пробелы

### Списки

1. 1\. Нумерованные
2. 2\. Причем порядок цифр
9. 9\. На результат не влияет

* обычные списки
    - с любым уровнем вложенности
        1. можно комбинировать нумерованные и не нумерованные списки 

### Заголовки

Создание заголовков производится путём помещения знака решетки перед текстом заголовка. Количество знаков «#» соответствует уровню заголовка. Поддерживается 6 уровней заголовков.

# \# Заголовок первого уровня
...
### \#\#\# Заголовок третьего уровня
...
###### \#\#\#\#\#\# Заголовок шестого уровня

### Цитаты (комментарии)

>Любой элемент разметки (текст, список, картинка) могут быть помечены как цитата, если добавить в начале строки знак "\>"

### Ссылки

* Ссылки на внешние ресурсы

    ```
    [Текст ссылки](http://example.com/ "Необязательный заголовок ссылки")
    ```

* Ссылки внутри документа

    ```
    [Текст ссылки](#якорь)
    ```

    В качестве "якоря" может выступать [заголовок](#Заголовки) или html-тег \<a\> (но это уже нетривиальное использование разметки)

* Ссылки внутри репозитория

    ```
    [Текст ссылки](относительный путь на файл внутри репозитория)
    ```

### Таблицы

столбец 1 | столбец 2
:---:|---:
1 | sfbvstb
2 | sbstbn

Как это выглядит в разметке (обратите внимание, содержимое столбцов можно центрировать или выравнивать по правому краю):

```
столбец 1 | столбец 2
:---:|---:
1 | sfbvstb
2 | sbstbn
```

### Изображения

С помощью MarkDown-а нельзя нарисовать схему или формулу, в таком случае можно использовать картинки

```
![Alt-текст](http://example.com/ "Заголовок изображения")
```

> Ссылка может быть и на рисунок расположенный в репозитории


## Редактор кода

И последний компонент из набора технологий - редактор **Visual Studio Code** (VSC). Как я писал выше редактировать MarkDown можно и в обычном блокноте (но не в Word-e), но VSC позволяет сразу видеть получившийся результат и автоматизировать работу с репозиторием.

![](../img/doklad01.png)


## P.S.

Для самого MarkDown тоже есть расширения. 

### Math

Позволяет рисовать простые формулы

```
$a^2+b^2=c^2$
```

$a^2+b^2=c^2$


### KaTeX

[KaTeX](https://github.com/KaTeX/KaTeX) является подмножеством [LaTeX](https://ru.wikipedia.org/wiki/LaTeX) и позволяет "рисовать" сложные формулы (но при этом уже страдает простота написания):

% \f is defined as #1f(#2) using the macro
\f\relax{x} = \int_{-\infty}^\infty
    \f\hat\xi\,e^{2 \pi i \xi x}
    \,d\xi

### Mermaid

[Mermaid](https://github.com/mermaid-js/mermaid) позволяет "рисовать" диаграммы: 

```
```mermaid
graph TD;
    A-->B;
    A-->C;
    B-->D;
    C-->D;
```

```mermaid
graph TD;
    A-->B;
    A-->C;
    B-->D;
    C-->D;
```


```
```mermaid
sequenceDiagram
    participant Alice
    participant Bob
    Alice->>John: Hello John, how are you?
    loop Healthcheck
        John->>John: Fight against hypochondria
    end
    Note right of John: Rational thoughts <br/>prevail!
    John-->>Alice: Great!
    John->>Bob: How about you?
    Bob-->>John: Jolly good!
```


```mermaid
sequenceDiagram
    participant Alice
    participant Bob
    Alice->>John: Hello John, how are you?
    loop Healthcheck
        John->>John: Fight against hypochondria
    end
    Note right of John: Rational thoughts <br/>prevail!
    John-->>Alice: Great!
    John->>Bob: How about you?
    Bob-->>John: Jolly good!
```

```
```mermaid
gantt
dateFormat  YYYY-MM-DD
title Adding GANTT diagram to mermaid
excludes weekdays 2014-01-10

section A section
Completed task            :done,    des1, 2014-01-06,2014-01-08
Active task               :active,  des2, 2014-01-09, 3d
Future task               :         des3, after des2, 5d
Future task2               :         des4, after des3, 5d
```

```mermaid
gantt
dateFormat  YYYY-MM-DD
title Adding GANTT diagram to mermaid
excludes weekdays 2014-01-10

section A section
Completed task            :done,    des1, 2014-01-06,2014-01-08
Active task               :active,  des2, 2014-01-09, 3d
Future task               :         des3, after des2, 5d
Future task2               :         des4, after des3, 5d
```

```
```mermaid
classDiagram
Class01 <|-- AveryLongClass : Cool
Class03 *-- Class04
Class05 o-- Class06
Class07 .. Class08
Class09 --> C2 : Where am i?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
Class08 <--> C2: Cool label
```

```mermaid
classDiagram
Class01 <|-- AveryLongClass : Cool
Class03 *-- Class04
Class05 o-- Class06
Class07 .. Class08
Class09 --> C2 : Where am i?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
Class08 <--> C2: Cool label
```

```
```mermaid
erDiagram
    CUSTOMER ||--o{ ORDER : places
    ORDER ||--|{ LINE-ITEM : contains
    CUSTOMER }|..|{ DELIVERY-ADDRESS : uses
```


```mermaid
erDiagram
    CUSTOMER ||--o{ ORDER : places
    ORDER ||--|{ LINE-ITEM : contains
    CUSTOMER }|..|{ DELIVERY-ADDRESS : uses
```
