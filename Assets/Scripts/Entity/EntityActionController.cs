using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class EntityActionController 
{
    [SerializeField] private Entity _entity;
    private ActionType _currentAction;

    public EntityActionController(Entity entity)
    {
        _entity = entity;
        _entity.ServiceManager.DestroyHandler += OnDestroy;
        _entity.ServiceManager.UpdateHandler += OnUpdate;
    }

    protected virtual void Move(Vector3 destination, float stoppingDistance = 1f)
    {
        _entity.NavMeshAgent.destination = destination;
        _entity.NavMeshAgent.stoppingDistance = stoppingDistance;
        ChangeAction(ActionType.Run);
    }

    protected virtual void ChangeAction(ActionType action) 
    {
        ResetAction();
        _currentAction = action;
        if (_currentAction != ActionType.None)
        {
            _entity.Animator.SetBool(_currentAction.ToString(), true);
        }
    }

    private void ResetAction()
    {
        if(_currentAction != ActionType.None)
        {
            _entity.Animator.SetBool(_currentAction.ToString(), false);
        }
        _currentAction = ActionType.None;
    }

    private void OnUpdate()
    {
        if(Vector3.Distance(_entity.transform.position, _entity.NavMeshAgent.destination) <= _entity.NavMeshAgent.stoppingDistance)
        {
            ChangeAction(ActionType.None);
            _entity.NavMeshAgent.destination = _entity.transform.position;
        }
    }

    protected virtual void OnDestroy()
    {
        _entity.ServiceManager.DestroyHandler -= OnDestroy;
        _entity.ServiceManager.UpdateHandler -= OnUpdate;
    }
}

public enum ActionType
{
    None,
    Idle,
    Walk,
    Run,
    Attack1,
    Attack2,
    GetHit,
    Die
}