using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    public GameObject _player;
    public GameObject _arrow;
    public float rotationSpeed;
    public float rotationModifier;
    public float moveSpeed;
    public bool outScreen;
    public bool onScreen;

    void Update()
        {
            if(outScreen == true && onScreen == false)    
            {
                Debug.Log("Out ");
                _arrow.SetActive(true);
            }
            else
            {
                _arrow.SetActive(false);
            }

            Move();
        }


    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (_player != null)
        {
            Vector3 vectorToTarget = _player.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
        }
    }
}
