using System;
using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         Debug.Log("Game Over"); // 게임 종료 이벤트
      }
   }
}