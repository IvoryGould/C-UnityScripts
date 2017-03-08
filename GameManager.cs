using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    CursorLockMode wantedMode;

    void Start() {

        wantedMode = CursorLockMode.Locked;

    }


    void Update() {

        SetCursorState();

    }

    void SetCursorState() {

        Cursor.lockState = wantedMode;

    }
}
