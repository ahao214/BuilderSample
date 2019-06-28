﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 天使角色建造者，充当具体建造者
    /// </summary>
    class AngelBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "白裙";
        }

        public override void BuildFace()
        {
            actor.Face = "漂亮";
        }

        public override void BuildHairstyle()
        {
            actor.HairStyle = "披肩长发";
        }

        public override void BuildSex()
        {
            actor.Sex = "女";
        }

        public override void BuildType()
        {
            actor.Type = "天使";
        }
    }
}
