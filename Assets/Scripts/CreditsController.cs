using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
   [SerializeField] private GameObject made;
   [SerializeField] private GameObject sound;
   [SerializeField] private GameObject assetsHead;
   [SerializeField] private GameObject assets_1;
   [SerializeField] private GameObject assets_2;
   private async void OnEnable()
   {
      while (isActiveAndEnabled)
      {
         assetsHead.SetActive(false);
         assets_2.SetActive(false);
         made.SetActive(true);
         await Task.Delay(5000);
         made.SetActive(false);
         sound.SetActive(true);
         await Task.Delay(5000);
         sound.SetActive(false);
         assetsHead.SetActive(true);
         assets_1.SetActive(true);
         await Task.Delay(5000);
         assets_1.SetActive(false);
         assets_2.SetActive(true);
         await Task.Delay(5000);
      }
   }
}
