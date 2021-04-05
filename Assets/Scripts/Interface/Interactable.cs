using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool _isFocused;
    Player _player;
    bool _hasInteracted;
    [SerializeField] float _interactionDistance;
    public float StoppingDistance { get { return _interactionDistance; } }

    public void OnFocus(Player player)
    {
        _isFocused = true;
        _player = player;
    }

    public void OnUnfocus()
    {
        _hasInteracted = false;
    }
    public void Update()
    {
        if(_player != null && _isFocused)
        if (!_hasInteracted && Vector3.Distance(transform.position, _player.transform.position) <= _interactionDistance)
        {
            Interact();
        }
    }


    public void Interact()
    {
        _hasInteracted = true;
        Debug.Log("Interected" + gameObject);
    }

   
}
