namespace _7.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Executing some tests: ");
        }

        //создать две одинаковые строки и проверить что они равны;
        [Test, Retry(5),MaxTime(7), Category("stringTest"),Order(1)]
        public void Test1()
        {
            Console.WriteLine("Test1. Checking if strings are equal.. ");
            string string1 = "qwerty";
            string string2 = "qwerty";
            Assert.AreEqual(string1 ,string2, "Strings are not equal");
            Console.WriteLine("\tStrings are equal");
        }

        //создать два одинаковых списка строк и проверить что они равны;
        [Test,Category("stringTest"), Category("listTest"), Order(2)]
        public void Test2() 
        {
            Console.WriteLine("Test2. Checking if 2 lists of strings are equal.. ");
            List<string> list1 = new List<string>()
            {
                "item1",
                "item2",
                "item3"
            };
            List<string> list2 = new List<string>()
            {
                "item1",
                "item2",
                "item3"
            };
            CollectionAssert.AreEqual(list1, list2, "Lists are not equal");
            Console.WriteLine("\nLists are equal");

        }

        //создать список строк и одну отдельную строку значение которой есть и в списке. Проверить что созданная строка присутствует в списке;
        [Test, Category("stringTest"),Category("listTest"),Order(4)]
        public void Test3()
        {
            Console.WriteLine("Test3. Checking if the created string is on the list.. ");
            List<string> list = new List<string>()
            {
                "item1",
                "item2",
                "item3"
            };
            string str = "item2";
            CollectionAssert.Contains(list, str, "This string is not in the list");
            Console.WriteLine($"The string '{str}' is in the list");
        }

        //создать переменную a=10 и переменную b=5, проверить что выражение a>b возвращает true.
        [Test, TestCase, Category("intTest"), Order(3), Ignore("manual test")]
        public void Test4()
        {
            Console.WriteLine("Test4. Checking if a>b is true... ");
            int a = 10;
            int b = 5;
            Assert.True(a > b, "No, a < b");
            Console.WriteLine("\tTRUE: a > b ");
        }

    }
}