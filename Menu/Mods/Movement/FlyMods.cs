using easyInputs;
using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Maximility.Menu.Mods.Movement
{
    public class FlyMods
    {
        public static void ExcelFly()
        {
            if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightHandTransform.right / 2f;
            }

            if (EasyInputs.GetPrimaryButtonDown(EasyHand.LeftHand))
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftHandTransform.right / 2f;
            }
        }

        public static void TFly()
        {
            if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.leftHandTransform.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
            }
        }
    }
}
