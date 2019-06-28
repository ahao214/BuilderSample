using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 恶魔角色建造者，充当具体建造者
    /// </summary>
    class DevilBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "黑衣";
        }

        public override void BuildFace()
        {
            actor.Face = "丑陋";
        }

        public override void BuildHairstyle()
        {
            actor.HairStyle = "光头";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "恶魔";
        }
    }
}
