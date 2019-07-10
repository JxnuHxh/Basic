using System;
using System.Collections.Generic;

namespace 语法理解练习
{
   class Program
    {
        public static void Syntax()
        {
            Console.WriteLine(
                "Integer: " + 10 +
                " Double: " + 3.14 +
                " Boolean: " + true);
            string fooString = "\"escape \"";//给字母打引号
            Console.WriteLine(fooString);
            char charFromString = fooString[1];
            Console.WriteLine(charFromString);
            Console.WriteLine("{0}\t{1}",charFromString, fooString[2]);
          int a = string.Compare(fooString, "x", StringComparison.CurrentCultureIgnoreCase);
            //比较 不区分大小写 前面两个参数是变量
            Console.Write(a);
            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("\nhh:mm, dd MMM yyyy"));
            // 数组 - 从0开始计数
            // 声明数组时需要确定数组长度
            // 声明数组的格式如下：
            // <datatype>[] <var name> = new <datatype>[<array size>];
            int[] intArray = new int[10];
            // 声明并初始化数组的其他方式：
            int[] y = { 9000, 1000, 1337 };
           // 访问数组的元素 默认为0
            Console.WriteLine("intArray的第一个元素: " + intArray[0]);
            // 数组可以修改
            intArray[1] = 1;
            // 列表
            // 列表比数组更常用，因为列表更灵活。
            // 声明列表的格式如下：
            // List<datatype> <var name> = new List<datatype>();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            List<int> z = new List<int> { 9000, 1000, 1337 }; // i
           
            // 列表无默认值
            // 访问列表元素时必须首先添加元素
            intList.Add(1);
            intList.Add(10);
            Console.WriteLine("intList: " + z[0]+ "\n" +intList[0]+"\n"+intList[1]);
            // 操作符
           int i1 = 1, i2 = 2; // 多重声明的简写形式

            // 算术直截了当
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3

            // 取余
            Console.WriteLine("11%3 = " + (11 % 3)); // => 2

            // 比较操作符
            Console.WriteLine("3 == 2? " + (3 == 2)); // => false
            Console.WriteLine("3 != 2? " + (3 != 2)); // => true
            Console.WriteLine("3 > 2? " + (3 > 2)); // => true
            Console.WriteLine("3 < 2? " + (3 < 2)); // => false
            Console.WriteLine("2 <= 2? " + (2 <= 2)); // => true
            Console.WriteLine("2 >= 2? " + (2 >= 2)); // => true
            // 位操作符
            /*
            ~       取反
            <<      左移（有符号）
            >>      右移（有符号）
            &       与
            ^       异或
            |       或
            */

            // 自增、自减
            int i = 0;
            Console.WriteLine(i++); //i = 1. 事后自增
            Console.WriteLine(++i); //i = 2. 事先自增
            Console.WriteLine(i--); //i = 1. 事后自减
            Console.WriteLine(--i); //i = 0. 事先自减
            // 类似C的if语句
            int j = 10;
            if (j == 10)
            {
                Console.WriteLine("I get printed");
            }
            else if (j > 10)
            {
                Console.WriteLine("I don't");
            }
            else
            {
                Console.WriteLine("I also don't");
            }
            // <条件> ? <真> : <假>
            int toCompare = 17;
            string isTrue = toCompare == 17 ? "True" : "False";

            // While 循环
            int fooWhile = 0;
            while (fooWhile < 10)
            {
                //迭代 10 次, fooWhile 0->9
                fooWhile++;
                Console.Write(fooWhile+"\t");
            }
            Console.Write("\n");
            // Do While 循环
            int fooDoWhile = 0;
            do
            {
                //迭代 10次, fooDoWhile 0->9               
                fooDoWhile++;
                Console.Write(fooDoWhile + "\t");
            } while (fooDoWhile < 10);
            Console.Write("\n");
            for (int fooFor = 0; fooFor < 10; fooFor++)
            {
                Console.Write(fooFor + "\t");
            }
            Console.Write("\n");
            // foreach循环
            // foreach 循环结构 => foreach(<迭代器类型> <迭代器> in <可枚举结构>)
            // foreach 循环适用于任何实现了 IEnumerable 或 IEnumerable<T> 的对象。
            // .Net 框架下的集合类型(数组, 列表, 字典...)
            // 都实现了这些接口
            // (下面的代码中，ToCharArray()可以删除，因为字符串同样实现了IEnumerable)
            foreach (char character in "Hello World".ToCharArray())
            {
                //迭代字符串中的所有字符
                Console.Write(character + "\t");
            }
            Console.Write("\n");
            // Switch 语句
            // switch 适用于 byte、short、char和int 数据类型。
            // 同样适用于可枚举的类型
            // 包括字符串类, 以及一些封装了原始值的类：
            // Character、Byte、Short和Integer。
            int month = 3;
            switch (month)
            {
                case 1:
                    Console.WriteLine("1月");
                    break;
                case 2:
                    Console.WriteLine("2月");
                    break;
                case 3:
                    Console.WriteLine("3月");
                    break;
                // 你可以一次匹配多个case语句
                // 但是你在添加case语句后需要使用break
                // （否则你需要显式地使用goto case x语句）
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("678月");
                    break;
                default:
                    Console.WriteLine("其他月");
                    break;
            }
            // 转换类型
            // 转换字符串为整数
            // 转换失败会抛出异常
            Console.WriteLine(int.Parse("123"));//返回整数类型的"123"

            // TryParse会尝试转换类型，失败时会返回缺省类型
            // 例如 0
            int tryInt;
            if (int.TryParse("123", out tryInt)) // Funciton is boolean
                Console.WriteLine(tryInt);       // 123

            // 转换整数为字符串
            // Convert类提供了一系列便利转换的方法
            Convert.ToString(123);
            // or
            tryInt.ToString();
        }
        // 类
        public class Bicycle
        {
            // 自行车的字段、变量
            private int cadence;
            public int Cadence
            {
                // get - 定义获取属性的方法
                get { return this.cadence; }
                // set - 定义设置属性的方法
                set {  this.cadence = value; }
                //value是被传递给setter的值
            }
            protected virtual int Gear // 类和子类可以访问
            {
                get; // 创建一个自动属性，无需成员字段
                set;
            }
            internal int Wheels // Internal:在同一程序集内可以访问
            {
                get;
                private set; // 可以给get/set方法添加修饰符
            }
            private int _speed; // 默认为private: 只可以在这个类内访问，你也可以使用`private`关键词
            public string Name { get; set; }
            // enum类型包含一组常量
            // 它将名称映射到值（除非特别说明，是一个整型）
            // enmu元素的类型可以是byte、sbyte、short、ushort、int、uint、long、ulong。
            // enum不能包含相同的值。
            public enum BikeBrand
            {
                AIST,
                BMC,
                Electra = 42, //你可以显式地赋值
                Gitane // 43
            }
            // 我们在Bicycle类中定义的这个类型，所以它是一个内嵌类型。
            // 这个类以外的代码应当使用`Bicycle.Brand`来引用
            public BikeBrand Brand; // 声明一个enum类型之后，我们可以声明这个类型的字段
                         // 静态方法的类型为自身，不属于特定的对象。
                         // 你无需引用对象就可以访问他们。
                         // Console.WriteLine("Bicycles created: " + Bicycle.bicyclesCreated);
            public static int BicyclesCreated = 0;
            // 只读值在运行时确定
            // 它们只能在声明或构造器内被赋值
            private readonly bool _hasCardsInSpokes = false;
            // 构造器是创建类的一种方式
            // 下面是一个默认的构造器
            public Bicycle()
            {
                Gear = 1; // 你可以使用关键词this访问对象的成员
                Cadence = 50;  // 不过你并不总是需要它
                this._speed = 5;
                Name = "Bontrager";
                this.Brand = BikeBrand.AIST;
                BicyclesCreated++;
            }
            // 另一个构造器的例子（包含参数）
            public Bicycle(int startCadence, int startSpeed, int startGear,
                           string name, bool hasCardsInSpokes, BikeBrand brand)
                : base() // 首先调用base
            {
                Gear = startGear;
                Cadence = startCadence;
                this._speed = startSpeed;
                Name = name;
                this._hasCardsInSpokes = hasCardsInSpokes;
                this.Brand = brand;
            }
            // 构造器可以连锁使用
        public Bicycle(int startCadence, int startSpeed, BikeBrand brand) :
            this(startCadence, startSpeed, 0, "big wheels", true, brand)
            {
            }
            // 函数语法
            // <public/private/protected> <返回值> <函数名称>(参数)
            // 类可以为字段实现 getters 和 setters 方法 for their fields
            // 或者可以实现属性（C#推荐使用这个）
            // 方法的参数可以有默认值
            // 在有默认值的情况下，调用方法的时候可以省略相应的参数
            public void SpeedUp(int increment = 1)
            {
                this._speed += increment;
            }

            public void SlowDown(int decrement = 1)
            {
                this._speed -= decrement;
            }
            // 属性可以访问和设置值
            // 当只需要访问数据的时候，考虑使用属性。
            // 属性可以定义get和set，或者是同时定义两者
            private bool hasTassles; // private variable
            public bool HasTassles // public accessor
            {
                get { return this.hasTassles; }
                set { this.hasTassles = value; }
            }
            // 你可以在一行之内定义自动属性
            // 这个语法会自动创建后备字段
            // 你可以给getter或setter设置访问修饰符
            // 以便限制它们的访问
            public bool IsBroken { get; private set; }
            // 属性的实现可以是自动的
            public int FrameSize
            {
                get;
                private set;
            }
            //显示对象属性的方法
            public virtual string Info()
            {
                return "Gear: " + Gear +
                        " Cadence: " + Cadence +
                        " Speed: " + this._speed +
                        " Name: " + Name +
                        " Cards in Spokes: " + (this._hasCardsInSpokes ? "yes" : "no") +
                        "\n------------------------------\n"
                        ;
            }
            // 方法可以是静态的。通常用于辅助方法。
            public static bool DidWeCreateEnoughBycles()
            {
                // 在静态方法中，你只能引用类的静态成员
                return BicyclesCreated > 9000;
            } // 如果你的类只需要静态成员，考虑将整个类作为静态类。
        }
        // PennyFarthing是Bicycle的一个子类
        internal class PennyFarthing : Bicycle
        {
            // (Penny Farthings是一种前轮很大的自行车。没有齿轮。）

            // 调用父构造器
            public PennyFarthing(int startCadence, int startSpeed) :
                base(startCadence, startSpeed, 0, "PennyFarthing", true, BikeBrand.Electra)
            {
            }

            protected override int Gear
            {
                get
                {
                    return 0;
                }
                set
                {
                    throw new ArgumentException("你不可能在PennyFarthing上切换齿轮");
                }
            }

            public override string Info()
            {
                string result = "PennyFarthing bicycle ";
                result += base.ToString(); // 调用父方法
                return result;
            }

            // 接口只包含成员的签名，而没有实现。
            private interface IJumpable
            {
                void Jump(int meters); // 所有接口成员是隐式地公开的
            }

            private interface IBreakable
            {
                bool Broken { get; } // 接口可以包含属性、方法和事件
            }

            // 类只能继承一个类，但是可以实现任意数量的接口

            private int damage = 0;

            public void Jump(int meters)
            {
                this.damage += meters;
            }

            public bool Broken
            {
                get
                {
                    return this.damage > 100;
                }
            }
        }
        public static void Classes()
        {
            // 使用new初始化对象
            Bicycle trek = new Bicycle();

            // 调用对象的方法
            trek.SpeedUp(3); // 你应该一直使用setter和getter方法
            trek.Cadence = 100;

            // 查看对象的信息.
            Console.WriteLine("trek info: " + trek.Info());

            // 实例化一个新的Penny Farthing
            PennyFarthing funbike = new PennyFarthing(1, 10);
            Console.WriteLine("funbike info: " + funbike.Info());

            Console.Read();
        }
        public static int/*允许直接调用类，无需先创建实例*/
        MethodSignatures(
            int maxCount, // 第一个变量，类型为整型
            int count = 0, // 如果没有传入值，则缺省值为0
            int another = 3,
            params string[] otherParams // 捕获其他参数
        )
        {
            return -1;
        }
        // 方法可以重名，只要签名不一样
        public static void MethodSignature(string maxCount)
        {
        }

        static void Main(string[] args)
        {
            Syntax();
            
        }
    }
}
