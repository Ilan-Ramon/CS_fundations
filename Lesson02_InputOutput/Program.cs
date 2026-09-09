Console.WriteLine("מה השם שלך?");
string name = Console.ReadLine();

Console.WriteLine("באיזו שנה נולדת?");
int birthYear = int.Parse(Console.ReadLine());

int age = 2026 - birthYear;

Console.WriteLine($"שלום {name}, אתה בן {age}");

// TODO משימה 1: הוסיפו קלט לתחביב (string), ושלבו אותו בהודעה

// TODO משימה 2: הוסיפו קלט לגובה בסנטימטרים (double), וחשבו את הגובה במטרים

// TODO משימה 3: חשבו בערך כמה ימים חייתם (הגיל כפול 365)

// TODO אתגר: בקשו שני מספרים, והדפיסו את הסכום, ההפרש, המכפלה והמנה שלהם
