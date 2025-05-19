using System;

using UnityEngine;

namespace BIS.Runtime.Shared
{
    public interface IPopupUI
    {
        GameObject PopupGO { get;}

        bool Init();

        void ClosePopup(Action callBack = null);

        void OpenPopup();
    }
}
