using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamJimJam : MonoBehaviour {

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture webcamTexture = new WebCamTexture();

        if (devices.Length > 0)
        {
            Debug.Log(devices[0].name);
            webcamTexture.deviceName = devices[0].name;
            webcamTexture.Play();
        }
    }
}
