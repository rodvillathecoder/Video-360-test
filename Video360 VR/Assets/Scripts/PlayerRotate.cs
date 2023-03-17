using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    Quaternion _Qstart, _Qend;
    [SerializeField]float _angle, _timer;
    

    private void Awake()
    {
        enabled = false;
        
    }

    /*private void OnEnable()
    {
        StartRotationWithAngle(90);
    }
    */


    
    void Update()
    {
        _timer += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(_Qstart, _Qend, _timer);

        if (_timer >= 1)
            enabled = false;

    }

    public bool StartRotationWithAngle(float angle)
    {
        if (enabled) return false;


        _angle = angle;
        _timer = 0;
        _Qstart = transform.rotation;
        Vector3 rotation = _Qstart.eulerAngles;
        _Qend = Quaternion.Euler(rotation + Vector3.up * _angle);

        enabled = true;

        return true;
    }

    public void SetRotation(Quaternion rotation)
    {
        transform.rotation = rotation;
    }


}
