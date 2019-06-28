using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 英雄角色建造者，充当具体建造者
    /// </summary>
    class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "盔甲";
        }

        public override void BuildFace()
        {
            actor.Face = "英俊";
        }

        public override void BuildHairstyle()
        {
            actor.HairStyle = "飘逸";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "英雄";
        }
    }
}
