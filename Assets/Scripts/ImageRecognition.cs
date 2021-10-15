using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;

    void Awake() {
        // この記法は慣れないなぁ
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable() {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable() {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args){
        foreach(var trackedImage in args.added){
            Debug.Log(trackedImage.name);
        }
    }

    void Start() {
        
    }

    
    void Update() {
        
    }
}
