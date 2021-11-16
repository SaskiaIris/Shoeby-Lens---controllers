using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationController : MonoBehaviour
{
    [SerializeField]
    private XRController leftTeleportRay;

    [SerializeField]
    private XRController rightTeleportRay;

    [SerializeField]
    private InputHelpers.Button teleportActivationButton;

    [SerializeField]
    private float activationThreshold = 0.1f;

    void Update()
    {
        if(leftTeleportRay && !rightTeleportRay && !rightTeleportRay.gameObject.activeSelf) {
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        } else if(rightTeleportRay && !leftTeleportRay && !leftTeleportRay.gameObject.activeSelf) {
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller) {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}