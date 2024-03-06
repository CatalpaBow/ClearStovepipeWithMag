using FistVR;
using HarmonyLib;
using Stovepipe;
using Stovepipe.StovepipePatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace plugin.src.Patches
{
    public class StovepipeBasePatches
    {
        [HarmonyPatch(typeof(StovepipeBase), "StartStovepipe")]
        [HarmonyPostfix]
        private static void AddClearncerComponent(StovepipeData data) {
            Debug.Log("Injected!");
            GameObject fireArm = data.ejectedRound.transform.parent.gameObject;
            var clearancer = fireArm.AddComponent<ClearStovepipeWithMag>();
            clearancer.Intialize(data, fireArm.GetComponent<Rigidbody>());
        }
    }


    public class ClearStovepipeWithMag : MonoBehaviour{
        public StovepipeData data;
        public Rigidbody wepRb;

        public void Intialize(StovepipeData _data, Rigidbody _wepRb) {
            data = _data;
            wepRb = _wepRb;
        }

        void OnCollisionEnter(Collision collision) {
            Debug.Log("CollisionDetected!");
            foreach (var con in collision.contacts) {
                bool isArmRound = con.thisCollider.GetComponentInParent<FVRFireArmRound>();
                bool isMagazine = con.otherCollider.attachedRigidbody.GetComponent<FVRFireArmMagazine>() ;
                //Debug.Log("isArmRound:" + isArmRound + "isMagazine:" + isMagazine);
                //Debug.Log(con.thisCollider.gameObject.name);
                if(!(isArmRound && isMagazine)) {
                    return;
                }
                //Debug.Log("DoClearStovepipe");
                StovepipeBase.UnStovepipe(data, true, wepRb);
                
                break;
            }
            Destroy(this);
        }
    }
}
