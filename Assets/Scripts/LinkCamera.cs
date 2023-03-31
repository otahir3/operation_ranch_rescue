using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class LinkCamera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera room1Cam;
    [SerializeField] CinemachineVirtualCamera room2Cam;
    [SerializeField] CinemachineVirtualCamera room3Cam;
    [SerializeField] CinemachineVirtualCamera room4Cam;
    [SerializeField] CinemachineVirtualCamera room5Cam;
    [SerializeField] CinemachineVirtualCamera room6Cam;
    [SerializeField] CinemachineVirtualCamera room7Cam;
    [SerializeField] CinemachineVirtualCamera room8Cam;
    [SerializeField] CinemachineVirtualCamera room9Cam;

    private int prevRoomNum = 1;

    // When the player stop touching the trigger
    // Use the tag of the trigger and the previous room the player is at to determine where the main camera should move to
    private void OnTriggerExit2D(Collider2D collision) {

        // If the player stop touching the trigger between room 1 and 2
        if (collision.gameObject.CompareTag("R1R2Trigger")) {

            // If the player was previously at room 1
            // main camera will switch to virutal camera at room 2
            // and update prevRoomNum to 2
            if (prevRoomNum == 1) {
                CameraSwitcher.SwitchCamera(room2Cam);
                prevRoomNum = 2;
            }

            // Otherwise meaning the player was previously at room 2
            // main camera will switch to virutal camera at room 1
            else {
                CameraSwitcher.SwitchCamera(room1Cam);
                prevRoomNum = 1;
            }
        }

        else if (collision.gameObject.CompareTag("R2R3Trigger")) {
            if (prevRoomNum == 2) {
                CameraSwitcher.SwitchCamera(room3Cam);
                prevRoomNum = 3;
            }
            else {
                CameraSwitcher.SwitchCamera(room2Cam);
                prevRoomNum = 2;
            }
        }

        else if (collision.gameObject.CompareTag("R3R4Trigger")) {
            if (prevRoomNum == 3) {
                CameraSwitcher.SwitchCamera(room4Cam);
                prevRoomNum = 4;
            }
            else {
                CameraSwitcher.SwitchCamera(room3Cam);
                prevRoomNum = 3;
            }
        }

        else if (collision.gameObject.CompareTag("R4R5Trigger")) {
            if (prevRoomNum == 4) {
                CameraSwitcher.SwitchCamera(room5Cam);
                prevRoomNum = 5;
            }
            else {
                CameraSwitcher.SwitchCamera(room4Cam);
                prevRoomNum = 4;
            }
        }

        else if (collision.gameObject.CompareTag("R5R6Trigger")) {
            if (prevRoomNum == 5) {
                CameraSwitcher.SwitchCamera(room6Cam);
                prevRoomNum = 6;
            }
            else {
                CameraSwitcher.SwitchCamera(room5Cam);
                prevRoomNum = 5;
            }
        }

        else if (collision.gameObject.CompareTag("R5R8Trigger")) {
            if (prevRoomNum == 5) {
                CameraSwitcher.SwitchCamera(room8Cam);
                prevRoomNum = 8;
            }
            else {
                CameraSwitcher.SwitchCamera(room5Cam);
                prevRoomNum = 5;
            }
        }

        else if (collision.gameObject.CompareTag("R6R7Trigger")) {
            if (prevRoomNum == 6) {
                CameraSwitcher.SwitchCamera(room7Cam);
                prevRoomNum = 7;
            }
            else {
                CameraSwitcher.SwitchCamera(room6Cam);
                prevRoomNum = 6;
            }
        }

        else if (collision.gameObject.CompareTag("R1R6Trigger")) {
            if (prevRoomNum == 1) {
                CameraSwitcher.SwitchCamera(room6Cam);
                prevRoomNum = 6;
            }
            else {
                CameraSwitcher.SwitchCamera(room1Cam);
                prevRoomNum = 1;
            }
        }

    }


    // register all virtual camera when player is moving
    private void OnEnable() {
        CameraSwitcher.Register(room1Cam);
        CameraSwitcher.Register(room2Cam);
        CameraSwitcher.Register(room3Cam);
        CameraSwitcher.Register(room4Cam);
        CameraSwitcher.Register(room5Cam);
        CameraSwitcher.Register(room6Cam);
        CameraSwitcher.Register(room7Cam);
        CameraSwitcher.Register(room8Cam);
        CameraSwitcher.Register(room9Cam);

    }

    private void OnDisable() {
        CameraSwitcher.Unregister(room1Cam);
        CameraSwitcher.Unregister(room2Cam);
        CameraSwitcher.Unregister(room3Cam);
        CameraSwitcher.Unregister(room4Cam);
        CameraSwitcher.Unregister(room5Cam);
        CameraSwitcher.Unregister(room6Cam);
        CameraSwitcher.Unregister(room7Cam);
        CameraSwitcher.Unregister(room8Cam);
        CameraSwitcher.Unregister(room9Cam);

    }
}
