using System.Collections;
using System.Collections.Generic;
using GeoCoordinatePortable;
using UnityEngine;
using Mapbox.Utils;
using Mapbox.Examples;
using TMPro;

public class EventPointer : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50f;
    [SerializeField] private float _amplitude = 2f;
    [SerializeField] private float _frequency = 0.5f;
    [SerializeField] private ValueAdd _value;
    
    private LocationStatus playerlocation;

    public Vector2d EventPos; 
    // Start is called before the first frame update
    void Start()
    {
        CheckLocation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FloatAndRotatePoint();
        CheckLocation();
    }

    private void FloatAndRotatePoint()
    {
        transform.Rotate(Vector3.up, _rotationSpeed* Time.deltaTime);
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.fixedTime * Mathf.PI * _frequency)* _amplitude)+ 15, transform.position.z);
    }

    public void CheckLocation()
    {
        playerlocation = GameObject.Find("Canvas").GetComponent<LocationStatus>();
        var currentplayerloc =
            new GeoCoordinatePortable.GeoCoordinate(playerlocation.GetLocationLat(), playerlocation.GetLocationLong());
        var eventloc = new GeoCoordinatePortable.GeoCoordinate(EventPos[0], EventPos[1]);
        var distance = currentplayerloc.GetDistanceTo(eventloc);
        if (distance < 50)
        {
            _value.AddScore();
            this.gameObject.SetActive(false);
        }
        
    }
}
