﻿using doCore.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_ImageView.extdefine
{
    public abstract class image_MAbstract : doUIModule
    {
        protected image_MAbstract():base()
        {
            
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();
            //注册属性
        }
    }
}
