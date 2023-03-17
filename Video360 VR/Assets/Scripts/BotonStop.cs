
using UnityEngine;

public class BotonStop : Interactable
{
    [SerializeField] VideoManager _manager;

    public override void OnPointerClick()
    {
        base.OnPointerClick();
        _manager.StopVideo();
    }
}
