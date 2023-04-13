using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson_6.Animals
{
    public class Wolf : HostileAnimal
    {
        private Vector3 _startPosition; // The starting position of the object
        private float _angle = 0f; // The current angle of _startPosition

        void Start()
        {
            _startPosition = transform.position;
        }

        protected void Update()
        {
            Vector3 end = new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), Random.Range(0f, 10f));

            transform.position = Vector3.Lerp(transform.position, end, Mathf.PingPong(Time.time * speed, 1.0f));
        }
    }
}