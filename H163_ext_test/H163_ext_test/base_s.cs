using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using H163_ext_test;
using Swed64;
namespace Shoto_tyt_esti
{
    public static class base_s
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        public static IntPtr getdatamodel()
        {
            var fakeahhdm = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.FakeDataModelPointer);//FakeDataModelPointer
            return local.ReadPointer(fakeahhdm + offsets.FakeDataModelToDataModel);//FakeDataModelToDataModel
        }
        public static instance GT()
        {
            IntPtr datamodel = getdatamodel();
            var dt = new instance(datamodel);
            return dt;
        }
        public static instance _workspace()
        {
            var datamodel = getdatamodel();
            var dt = new instance(datamodel);
            var workspace = dt.findfirstchild("Workspace");
            return workspace;
        }
        public static IntPtr Camera()
        {
            return local.ReadPointer(_workspace().address + Offsets.Workspace.CurrentCamera);
        }
    }

}

