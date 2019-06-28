using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 角色创建者：抽象建造者
    /// </summary>
    abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();

        //工厂方法,返回一个完整的游戏角色对象
        public Actor CreateActor()
        {
            return actor;
        }
    }
}
