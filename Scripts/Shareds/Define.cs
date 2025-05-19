using UnityEngine;

namespace BIS.Runtime.Shared
{
    public static class Define { }
    public enum EMainTabbar
    {
        MISSION,
        SKILL,
        APPEARANCE,
        PLAYGROUND,
        PROGRESSION
    }
    public enum EModelType
    {
        Int,
        Float,
        Bool
    }

    public enum EUIEvent
    {
        Click,
        PointerDown,
        PointerUp,
        Drag,
        PointerEnter,
        PointerExit
    }
    public enum EScene
    {
        Unknown,
        TitleScene,
        GameScene,
        Battlefield
    }
}

