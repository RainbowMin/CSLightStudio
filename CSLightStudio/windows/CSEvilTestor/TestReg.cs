﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSEvilTestor
{
    class TestReg
    {
        public static void Reg(CSLE.ICLS_Environment env)
        {
            env.RegType(new CSLE.RegHelper_Type(typeof(Debug)));

            env.RegType(new CSLE.RegHelper_Type(typeof(TestDele)));
            env.RegType(new CSLE.RegHelper_Type(typeof(Program)));

            env.RegDeleType(new CSLE.RegHelper_DeleAction("Action"));
            env.RegDeleType(new CSLE.RegHelper_DeleAction<int>("Action<int>"));
            env.RegDeleType(new CSLE.RegHelper_DeleAction<int,string>("Action<int,string>"));


            env.RegType(new CSLE.RegHelper_Type(typeof(List<string>),"List<string>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(List<int>), "List<int>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(List<List<int>>), "List<List<int>>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(List<List<List<double>>>), "List<List<List<double>>>"));
            env.RegType(new CSLE.RegHelper_Type(typeof(List<List<List<int>>>), "List<List<List<int>>>"));


        }
    }
}
