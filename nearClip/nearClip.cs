using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;



namespace nearClipS
{
    public class nearClip : MelonMod
    {

        public override void OnLevelWasLoaded(int level)
        {
            switch (level)
            {
                case 0: //App
                case 1: //ui
                    break;
                default:
                    MelonCoroutines.Start(setNearClipPlane(30, 0.01f));
                    break;
                    
            }
        }


        System.Collections.IEnumerator setNearClipPlane(int secs, float nc)
        {
            while (secs > 0)
            {
                yield return new WaitForSecondsRealtime(1);
                VRCVrCamera vrCamera = VRCVrCamera.field_Private_Static_VRCVrCamera_0;
                if (!vrCamera)
                    yield break;
                Camera screenCamera = vrCamera.screenCamera;
                if (!screenCamera)
                    yield break;
                screenCamera.nearClipPlane = nc;
                //MelonModLogger.Log("Overrode nearClipPlane!");
                secs--;
            }
            
        }

    }
}
