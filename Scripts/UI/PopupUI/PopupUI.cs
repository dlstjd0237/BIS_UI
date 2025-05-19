using System;

using UnityEngine;

using BIS.Runtime.Shared;
using BIS.Runtime.Manager;
using BIS.Runtime.Utility;

namespace BIS.Runtime.UI.Popup
{
    public abstract class PopupUI : UIBase, IPopupUI
    {
        public GameObject PopupGO => gameObject;

        public override bool Init()
        {
            if (base.Init() == false)
                return false;


            Managers.UI.SetCanvas(gameObject);
            return true;
        }

        public virtual void ClosePopup(Action callBack = null)
        {
            Util.UIFadeOut(gameObject, true, 0.2f, callBack);
        }

        public virtual void OpenPopup()
        {
            Util.UIFadeOut(gameObject, false);
        }
    }
}
