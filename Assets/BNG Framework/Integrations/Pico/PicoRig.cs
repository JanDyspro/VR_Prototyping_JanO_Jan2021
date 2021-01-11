using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG {

    public class PicoRig : MonoBehaviour {

        Pvr_UnitySDKEyeManager picoEyeManager;
        Pvr_UnitySDKEye centerEye;
        Camera leftEye;
        Camera rightEye;

        void Awake() {
            // Make sure Pico is enabled
            InputBridge.Instance.InputSource = XRInputSource.Pico;

            // Init Head Tracking
            Pvr_UnitySDKHeadTrack headTrack = this.transform.GetComponentInChildren<Pvr_UnitySDKHeadTrack>();
            if(headTrack == null) {
                headTrack = Camera.main.gameObject.AddComponent<Pvr_UnitySDKHeadTrack>();
                headTrack.trackRotation = true;
                headTrack.trackPosition = true;
            }

            // Init Pico Center Eye Configuration
            Pvr_UnitySDKEye centerEye = this.transform.GetComponentInChildren<Pvr_UnitySDKEye>();
            if (centerEye == null) {
                centerEye = Camera.main.gameObject.AddComponent<Pvr_UnitySDKEye>();
                centerEye.eyeSide = Pvr_UnitySDKAPI.Eye.BothEye;
            }

            picoEyeManager = GetComponentInChildren<Pvr_UnitySDKEyeManager>();
            if(picoEyeManager) {
                // picoEyeManager.BothEyeCamera = Camera.main;
            }
        }

        // Update is called once per frame
        void Update() {
            string debugText = "";
            debugText += "Right Trigger : " + InputBridge.Instance.RightTrigger.ToString("0.00") + "\n";
            debugText += "Left Trigger : " + InputBridge.Instance.LeftTrigger.ToString("0.00") + "\n";

            debugText += "A Button : " + InputBridge.Instance.AButton + "\n";
            debugText += "B Button : " + InputBridge.Instance.BButton + "\n";
            debugText += "X Button : " + InputBridge.Instance.XButton + "\n";
            debugText += "Y Button : " + InputBridge.Instance.YButton + "\n";

            debugText += "Left Grip : " + InputBridge.Instance.LeftGrip + "\n";
            debugText += "Right Grip : " + InputBridge.Instance.RightGrip + "\n";

            GameObject.Find("DebugText").GetComponent<UnityEngine.UI.Text>().text = debugText;
        }
    }
}

