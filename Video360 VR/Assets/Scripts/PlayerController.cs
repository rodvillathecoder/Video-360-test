using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerRotate _player;
    [SerializeField] VideoManager _manager;
    public List<TimeEvents> _angles = new List<TimeEvents>();

    //float _timer;

    // Start is called before the first frame update
    void Start()
    {
        Init(); 
    }

    public void Init() 
    {
        //_timer = 0;
        _angles.Clear();
        TimeEvents[] scriptables = Resources.LoadAll<TimeEvents>("Data");

        for (int i = 0; i < scriptables.Length; i++)
        {
            _angles.Add(scriptables[i]);
        }

        _angles.Sort(SortByTime);


    }

    private int SortByTime(TimeEvents tE1, TimeEvents tE2)
    {
        return tE1.time.CompareTo(tE2.time);
    }





    // Update is called once per frame
    void Update()
    {
        //_timer += Time.deltaTime;
        if (_angles[0].time < _manager.Time)
        {
           if(_player.StartRotationWithAngle(_angles[0].angle))
            {
                _angles.RemoveAt(0);
                if (_angles.Count == 0)
                    enabled = false;
            }
            
        }
    }

    public void ResetRotation()
    {
        _player.SetRotation(Quaternion.identity);
    }


}
