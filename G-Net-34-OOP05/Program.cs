namespace G_Net_34_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Par1 
            #region Q1
            //interface : is An interface defines a contract that a class must follow. It specifies what a class can do, not how it does it.
            // In programming, we use interfaces instead of relying on concrete classes for several reasons related to software design and scalability. Interfaces offer greater flexibility and allow you to reduce dependencies between different parts of the system, thus enhancing maintainability and scalability.
            // Decoupling of Code  -  Code Reusability and Flexibility - Testability and Mocking
            // Why avoid relying on tangible classes?: If you rely directly on tangible classes, you create a strong link between classes, making it difficult to change part of the code without affecting other parts.

            #endregion
            #region Q2
            //    interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello / Ahlan");
            //    }
            //}

            // A) المشكلة في هذا التصميم هي أن كل من الواجهتين IEnglishSpeaker و IArabicSpeaker تحتويان على دالة بنفس الاسم (Greet())، وعندما تقوم الكلاس Translator بتنفيذ كلا الواجهتين، فهي تقوم بتوفير دالة واحدة فقط (Greet())، ولكن C# لا تعرف أي دالة من الدوال يجب أن تُنفذ: هل هي IEnglishSpeaker.Greet() أم IArabicSpeaker.Greet()؟ هذا يسبب تضاربًا في الكود، حيث يكون هناك غموض حول أي دالة يتم استدعاؤها.
            // B) لحل هذه المشكلة، يمكننا استخدام التنفيذ الصريح للواجهات (Explicit Interface Implementation)، حيث نقوم بتوفير تنفيذ منفصل لكل دالة من دوال الواجهات. عند استخدام التنفيذ الصريح، يجب عليك استدعاء الدالة من خلال الواجهة نفسها وليس من خلال الكلاس.
            // c) لا، لا يمكنك استدعاء دالة Greet() مباشرة على كائن من نوع Translator لان الكمبيلر مش هيعرف الميثود وعشان اناديها لازم اعمل obj من Translator واروح اعمل intrface اللي عايز استخدم الميثود بتاعته واسوايه بي obj Translator زي كدا
            //Translator translator = new Translator();
            //IEnglishSpeaker englishSpeaker = translator;
            //englishSpeaker.Greet(); // ستطبع: Hello
            #endregion
            #region Q3
            // Shallow Copy: لو عايز انسخ نسخ سطحي بحيث ان هيشاور علي نفس الريفرنس يعني لو جيت سويت obj بي obj بيشاور علي نفس الريفرنس عشان كدا لو جيت غيرت قيمه في اي obj بيسمع في ال obj التاني مباشره
            // Deep Copy: لو عايز انسخ نسخ عميق بحيث ان كل obj بيكون ليه رفرنس خاص بيه يعني لو جيت سويت obj بي obj بيكون ليه رفرنس خاص بيه يعني لو جيت غيرت قيمه في اي obj مش هيأثر علي ال obj التاني
            // يمكن استخدام shallow copy عندما يكون لديك كائنات بسيطة لا تحتوي على مراجع إلى كائنات أخرى، أو عندما لا تهتم بتأثير التغييرات على الكائنات الأخرى. أما
            // deep copy فيستخدم عندما يكون لديك كائنات معقدة تحتوي على مراجع إلى كائنات أخرى، وتريد التأكد من أن التغييرات في نسخة واحدة لا تؤثر على النسخ الأخرى.
            // المخاطر من استخدام shallow copy هو أنه إذا قمت بتغيير كائن في النسخة المنسوخة، فقد يؤثر ذلك على الكائن الأصلي إذا كان يشير إلى نفس المرجع. أما deep copy فيتجنب هذا المشكلة لأنه ينشئ نسخة مستقلة تمامًا من الكائن، مما يعني أن التغييرات في النسخة المنسوخة لا تؤثر على الكائن الأصلي.
            #endregion
            #endregion

        }
    }
}
