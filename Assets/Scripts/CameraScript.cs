using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   private Transform _transform;

   private void Awake()
   {
      _transform = GetComponent<Transform>();
   }

   private void LateUpdate()
   {
      _transform.position = new Vector3(_transform.position.x + Time.deltaTime*3, _transform.position.y, _transform.position.z);
   }
}
