using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Jayden Saelee Chao
 * Contols mouse movement
 * 4/23/2025
 */

public class MouseController : MonoBehaviour
{
    public float mouseSensitivity = 250f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;

    private bool _isControllerActive = true;

    // Update is called once per frame
    void Update()
    {
        if (!_isControllerActive)
        {
            return; // Exit if controller is disabled
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
    
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainGame")
        {
            Cursor.lockState = CursorLockMode.Locked;
            _isControllerActive = true; // enable in menu scene
        }
        else
        {
            _isControllerActive = false; // disable in other scenes
            Cursor.visible = true;
        }
    }

}
