﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimusBuilder
{
    public class ClBuildList
    {
        public List<string> bp { get; set; }
        public List<string> controller { get; set; }
        public List<string> animus { get; set; }
        public List<string> mod { get; set; }
        public List<string> output { get; set; }
        public ClBuildList()
        {
            bp = new List<string>();
            controller = new List<string>();
            animus = new List<string>();
            mod = new List<string>();
            output = new List<string>();

        }

        public static void BuildFromList(ClBuildList bl)
        {
            var obp = new List<ClBuildProfile>();
            var octrl = new List<ClController>();
            

            for (int i = 0; i < bl.bp.Count; i ++)
            {
                obp.Add(MdCore.Deserialize<ClBuildProfile>(MdConstant.profiles + MdConstant.pseparator + bl.bp[i]));
                octrl.Add(MdCore.Deserialize<ClController>(MdConstant.controllers + MdConstant.pseparator + bl.controller[i]));
                MdCore.BuildAnimus(obp[i], octrl[i], bl.animus[i], bl.mod[i], bl.output[i]);
            }
        }

        public static ClBuildList BuildAll()
        {
            var bl = new ClBuildList();
            bl.bp.Add("diverge-ii-master.ukbpr");
            bl.bp.Add("diverge-ii-slave.ukbpr");
            bl.bp.Add("diverge-tm-master.ukbpr");
            bl.bp.Add("diverge-tm-slave.ukbpr");
            bl.bp.Add("terminus-mini.ukbpr");
            bl.controller.Add("pro-micro.ukbct");
            bl.controller.Add("pro-micro.ukbct");
            bl.controller.Add("pro-micro.ukbct");
            bl.controller.Add("pro-micro.ukbct");
            bl.controller.Add("pro-micro.ukbct");
            bl.animus.Add(MdSetting.setting.animusPath);
            bl.animus.Add(MdSetting.setting.animusPath);
            bl.animus.Add(MdSetting.setting.animusPath);
            bl.animus.Add(MdSetting.setting.animusPath);
            bl.animus.Add(MdSetting.setting.animusPath);
            bl.mod.Add(MdSetting.setting.modPath);
            bl.mod.Add(MdSetting.setting.modPath);
            bl.mod.Add(MdSetting.setting.modPath);
            bl.mod.Add(MdSetting.setting.modPath);
            bl.mod.Add(MdSetting.setting.modPath);
            bl.output.Add(MdSetting.setting.outputPath + MdConstant.pseparator + "diverge-ii");
            bl.output.Add(MdSetting.setting.outputPath + MdConstant.pseparator + "diverge-ii");
            bl.output.Add(MdSetting.setting.outputPath + MdConstant.pseparator + "diverge-tm");
            bl.output.Add(MdSetting.setting.outputPath + MdConstant.pseparator + "diverge-tm");
            bl.output.Add(MdSetting.setting.outputPath);
            return bl;
        }

    }
}
