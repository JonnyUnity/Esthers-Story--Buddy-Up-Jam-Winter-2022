using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Camera _camera;
    private bool _facingRight = true;
    private SpriteRenderer _spriteRenderer;

    private GameObject _highlightedObj;
    private GameObject _highlightedAnchor;

    private GameObject _objectToShrink;
    private GameObject _objectToEnlarge;
    private GameObject _shrinkAnchor;
    private GameObject _enlargeAnchor;

    [SerializeField] private float _moveSpeed;
    private Vector2 _movementDirection;

    private Rigidbody2D _rigidBody;
    private Transform _transform;

    [SerializeField] private GameObject _cursorObj;
    [SerializeField] private GameObject _cursorPivot;
    private Transform _cursorPivotTransform;
    [SerializeField] private Transform _cursorTransform;

    private InteractWith _interactObj;
    private DropObject _dropObj;
    private GameObject _pickUpObj;
    private GameObject _heldObject;
    [SerializeField] private GameObject _heldObjectPosition;
    private Transform _heldObjectTransform;
    private Vector3 _heldObjectOffset = new Vector3(0.35f, 1.25f, 0);
    private Vector3 _heldObjectOffsetRight = new Vector3(-0.35f, 1.25f, 0);

    private bool _isFirstMove = true;
    [SerializeField] private Interaction[] _firstMoveCouplets;
    [SerializeField] private Interaction[] _firstWandInHallwayCouplets;
    [SerializeField] private Interaction[] _firstStorybookCouplets;

    private PlayerStatesEnum State;

    private UnityEvent<Vector2> onMoveEvent = new UnityEvent<Vector2>();
    private UnityEvent onStopMovingEvent = new UnityEvent();

    [SerializeField] private Animator _animator;
    [SerializeField] private Animator _wandAnimator;

    public UnityEvent<Vector2> OnMoveEvent => onMoveEvent;
    public UnityEvent OnStopMovingEvent => onStopMovingEvent;

    private void Awake()
    {
        _camera = Camera.main;
        _transform = transform;
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _cursorPivotTransform = _cursorPivot.transform;
        _heldObjectTransform = _heldObjectPosition.transform;

        State = PlayerStatesEnum.IDLE;

    }

    private void Start()
    {
        //_cursorRenderer = _cursorObj.GetComponent<Renderer>();
        //_cursorRenderer.material.color = GameManager.Instance.GetCursorColour();

        OnMoveEvent.AddListener(Move);
        OnStopMovingEvent.AddListener(StopMoving);
    }

    public void OnPauseGame(InputValue value)
    {
        GameManager.Instance.ShowHidePauseMenu();
    }

    public void OnMove(InputValue value)
    {
        if (State == PlayerStatesEnum.INTERACTING || State == PlayerStatesEnum.STORYBOOK || State == PlayerStatesEnum.NARRATION)
            return;

        if (_isFirstMove)
        {
            StartCoroutine(GameManager.Instance.OpenDialogue(_firstMoveCouplets));
            _isFirstMove = false;
        }
        else
        {
            Vector2 move = value.Get<Vector2>().normalized;
            if (move.x > 0)
            {
                _spriteRenderer.flipX = false;
                _heldObjectTransform.localPosition = _heldObjectOffset;
            }
            else if (move.x < 0)
            {
                _spriteRenderer.flipX = true;
                _heldObjectTransform.localPosition = _heldObjectOffsetRight;
            }

            OnMoveEvent.Invoke(move);
        }
    }

    #region State functions

    public void ChangeState(PlayerStatesEnum newState)
    {
        State = newState;
        StopMoving();
    }

    public bool IsResizing()
    {
        return (State == PlayerStatesEnum.RESIZING);
    }

    public bool IsInteracting()
    {
        return (State == PlayerStatesEnum.INTERACTING);
    }

    #endregion

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        if (!(newAim.normalized == newAim))
        {
            Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);

            float distanceToCursor = (worldPos - (Vector2)_cursorPivotTransform.position).sqrMagnitude;
            newAim = (worldPos - (Vector2)_cursorPivotTransform.position).normalized;
            Vector2 cursorVector = newAim;

            if (distanceToCursor < 1.5f * 1.5f)
            {
                cursorVector *= 1.5f;
                _cursorTransform.position = (Vector2)_cursorPivotTransform.position + cursorVector;
            }
            else if (distanceToCursor > 3f * 3f)
            {
                cursorVector *= 3f;
                _cursorTransform.position = (Vector2)_cursorPivotTransform.position + cursorVector;
            }
            else
            {
                _cursorTransform.position = worldPos;
            }
        }
    }

    public void OnSelectObject(InputValue value)
    {
        if (State == PlayerStatesEnum.RESIZING || State == PlayerStatesEnum.INTERACTING || State == PlayerStatesEnum.NARRATION)
            return;
        
        if (_highlightedObj == null)
            return;

        _wandAnimator.SetTrigger("UseWand");
        GameManager.Instance.CheckFirstUseInSecondLevel(1); // wand

        var newColor = GameManager.Instance.SetSelection(_highlightedObj, _highlightedAnchor);

        var renderer = _highlightedObj.GetComponent<Renderer>();

        renderer.material.SetColor("_HighlightColour", newColor);
        renderer.material.SetFloat("_ShowHighlight", 1f);

        AudioManager.Instance.PlayUseWandClip();

    }


    public void SetInteractableObject(InteractWith interactObject)
    {
        _interactObj = interactObject;
    }

    

    public void UnsetInteractableObject()
    {
        _interactObj = null;
    }

    public void SetDropObject(DropObject dropObject)
    {
        _dropObj = dropObject;
    }

    public void UnsetDropObject()
    {
        _dropObj = null;
    }

    public void SetPickableObject(GameObject obj)
    {
        _pickUpObj = obj;
    }    

    public void UnsetPickableObject()
    {
        _pickUpObj = null;
    }

    public bool IsHoldingObject()
    {
        return (_heldObject != null);
    }

    public GameObject HeldObject()
    {
        return _heldObject;
    }


    public void OnInteract(InputValue value)
    {
        if (State == PlayerStatesEnum.NARRATION)
        {
            return;
        }

        _animator.SetBool("IsMoving", false);

        if (_heldObject != null)
        {
            _heldObject.transform.parent = null;
            
            if (_dropObj != null)
            {
                _dropObj.DoDrop(_heldObject);
            }
            else
            {
                if (_heldObject.TryGetComponent(out PickUp pickup))
                {
                    pickup.DropObject(null);
                }
            }

            _heldObject = null;
        }    
        else
        {
            if (_interactObj != null)
            {
                State = PlayerStatesEnum.NARRATION;
                _pickUpObj = _interactObj.DoInteraction();
            }

            if (_pickUpObj != null)
            {
                State = PlayerStatesEnum.NARRATION;

                if (_pickUpObj.CompareTag("WandPickup"))
                {
                    // State = PlayerStatesEnum.NARRATION;
                    //StartCoroutine(GameManager.Instance.PickupWand());
                    AudioManager.Instance.PlayVersionTrack(0);
                    GainWand();

                    Destroy(_pickUpObj);
                    _pickUpObj = null;
                }
                else if (_pickUpObj.CompareTag("StorybookPickup"))
                {
                    //State = PlayerStatesEnum.NARRATION;
                    //StartCoroutine(GameManager.Instance.PickupStoryBook());
                    GameManager.Instance.PickupStoryBook();
                    Destroy(_pickUpObj);
                    _pickUpObj = null;
                }
                else
                {
                    if (_pickUpObj.TryGetComponent(out PickUp pickup))
                    {
                        bool noDialogue = pickup.PickUpObject();
                        if (noDialogue) // else the dialogue handler will set the player state back - MESSY URG!
                        {
                            State = PlayerStatesEnum.IDLE;
                        }
                    }
                                        
                    _heldObject = _pickUpObj;
                    _heldObject.SetActive(true);
                    _heldObject.transform.parent = _heldObjectPosition.transform;
                    _heldObject.transform.position = _heldObjectPosition.transform.position;
                }
                
            }
        }

    }

    public void GainWand()
    {
        _cursorObj.SetActive(true);
    }

    public void SetHighlightedObject(GameObject highlightedObject, GameObject objectAnchor)
    {
        _highlightedObj = highlightedObject;
        _highlightedAnchor = objectAnchor;
    }

    public void UnsetHighlightedObject()
    {
        _highlightedObj = null;
        _highlightedAnchor = null;
    }


    public void Move(Vector2 direction)
    {

        if (direction == Vector2.zero)
        {
            _animator.SetBool("IsMoving", false);
            AudioManager.Instance.PauseWalkingAudio();
        }
        else
        {
            _animator.SetBool("IsMoving", true);
            AudioManager.Instance.PlayWalkingAudio();
        }
        
        _movementDirection = direction;
    }

    public void StopMoving()
    {
        _animator.SetBool("IsMoving", false);
        AudioManager.Instance.PauseWalkingAudio();
        _movementDirection = Vector2.zero;

    }


    private void FixedUpdate()
    {

        if (_movementDirection == Vector2.zero)
            return;

        Vector2 movement = Vector2.zero;
        if (_movementDirection.x != 0)
        {
            movement.x = _movementDirection.x;
        }
        else if (_movementDirection.y != 0)
        {
            movement.y = _movementDirection.y;
        }

        movement = _moveSpeed * Time.deltaTime * movement.normalized;
        _rigidBody.MovePosition(_rigidBody.position + movement);
    }


    public void OnSwapSize()
    {
        if (State == PlayerStatesEnum.INTERACTING || State == PlayerStatesEnum.NARRATION)
            return;

        State = PlayerStatesEnum.RESIZING;

        GameManager.Instance.DoSwapSize();

        //_cursorRenderer.material.color = GameManager.Instance.GetCursorColour();

        State = PlayerStatesEnum.IDLE;

    }

}

public enum PlayerStatesEnum
{
    IDLE,
    WALKING,
    USING_WAND,
    INTERACTING,
    NARRATION,
    RESIZING,
    STORYBOOK
}
