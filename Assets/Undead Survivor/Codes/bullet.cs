using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
  public float damage;
  public int per;

  public void OnServerInitialized(float damage, int per) 
  {  
     this.damage = damage;
     this.per = per;
  }
}
