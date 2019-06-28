using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;


namespace BuilderSample
{
    class Program
    {
        /// <summary>
        /// 建造者模式应用实例
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ActorBuilder ab;    //针对抽象建造者编程
            // 读取配置文件
            string builderType = ConfigurationManager.AppSettings["builder"];
            //反射生成对象
            ab = (ActorBuilder)Assembly.Load("BuilderSample").CreateInstance(builderType);
            ActorController ac = new ActorController();
            Actor actor;
            actor = ac.Construct(ab);   // 通过指挥者创建完整的建造者对象

            Console.WriteLine("{0}的外观", actor.Type);
            Console.WriteLine("性别：{0}", actor.Sex);
            Console.WriteLine("面容：{0}", actor.Face);
            Console.WriteLine("服装：{0}", actor.Costume);
            Console.WriteLine("发型：{0}", actor.HairStyle);

            Console.ReadLine();
        }
    }
}
