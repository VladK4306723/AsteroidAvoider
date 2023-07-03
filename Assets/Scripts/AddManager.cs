// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Advertisements;
//
// public class AddManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
// {
//     public static AddManager Instance;
//
//     private void Awake()
//     {
//         if (Instance != null && Instance != this)
//         {
//             Destroy(gameObject);
//         }
//         else
//         {
//             Instance = this;
//             DontDestroyOnLoad(gameObject);
//             
//             Advertisement.Initialize(gameId, testMode, this);
//         }
//     }
//
//     public void OnInitializationComplete()
//     {
//         Debug.Log("Unity ads initialization complete.");
//     }
//
//     public void OnInitializationFailed(UnityAdsInitializationError error, string message)
//     {
//         Debug.Log($"Unity ads initialization failed: {error} - {message}");
//     }
//
//     public void OnUnityAdsAdLoaded(string placementId)
//     {
//         throw new NotImplementedException();
//     }
//
//     public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
//     {
//         throw new NotImplementedException();
//     }
//
//     public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
//     {
//         throw new NotImplementedException();
//     }
//
//     public void OnUnityAdsShowStart(string placementId)
//     {
//         throw new NotImplementedException();
//     }
//
//     public void OnUnityAdsShowClick(string placementId)
//     {
//         throw new NotImplementedException();
//     }
//
//     public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
//     {
//         throw new NotImplementedException();
//     }
// }
