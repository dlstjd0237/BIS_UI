using BIS.Runtime.Shared;
using BIS.Runtime.Utility;

namespace BIS.Runtime.Scene
{
    public class SceneUI : InitBase, IScene
    {
        public EScene SceneType { get; set; } = EScene.Unknown;

        public override bool Init()
        {
            if (base.Init() == false)
                return false;


            return true;
        }
    }
}
