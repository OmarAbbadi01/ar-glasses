using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class TrackedImageManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject objectToPlace;

    //private GameObject newARObject;

    private ARTrackedImageManager trackedImageManager;

   // private Vector3 scaleFactor = new Vector3(0.1f, 0.1f, 0.1f);

    void Awake()
    {
        trackedImageManager = GetComponent<ARTrackedImageManager>();

        //newARObject = Instantiate(objectToPlace, Vector3.zero, Quaternion.identity);
    }

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            //UpdateARImage(trackedImage);
        }

        // foreach (ARTrackedImage trackedImage in eventArgs.updated)
        // {
        //     UpdateARImage(trackedImage);
        // }
        //
        // foreach (ARTrackedImage trackedImage in eventArgs.removed)
        // {
        //     newARObject.SetActive(false);
        // }
    }

    // void UpdateARImage(ARTrackedImage trackedImage)
    // {
    //     AssignGameObject(trackedImage.transform.position);
    // }

    // void AssignGameObject(Vector3 position)
    // {
    //     if (objectToPlace != null)
    //     {
    //         newARObject.SetActive(true);
    //         newARObject.transform.position = position;
    //         newARObject.transform.localPosition = scaleFactor;
    //     }
    // }
}