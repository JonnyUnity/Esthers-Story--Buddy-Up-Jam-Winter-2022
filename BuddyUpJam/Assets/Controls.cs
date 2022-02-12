//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Esther"",
            ""id"": ""a7918788-8b50-47a9-a43c-6eb737a7a557"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""976114ba-7a1b-4b20-81f9-9f403d5257cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""cb18edff-5d7b-479d-a188-45e3d19abe14"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwapSize"",
                    ""type"": ""Button"",
                    ""id"": ""9f3cfe16-5e18-4a9f-be78-c38a9aa94994"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectObject"",
                    ""type"": ""Button"",
                    ""id"": ""035d7e34-e441-4cb4-adfa-f6119a919ba8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""4623b0b2-e4fb-44ea-9fb0-49a78df1dba1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b68c783a-6859-44c1-b81b-850f4f2bf0c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""bba03bbf-0130-4bb4-931c-0c9bc8d88f0e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""071cec38-597c-47ab-b855-b75758caa79e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fdd505c2-e42c-4d2d-96f2-6f647b50acf2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""369211c9-9ac9-4ead-b4aa-6142e009dec9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1786146a-60f6-4a31-bf4f-4d9747df501d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""9b3efde1-0a74-427d-88fb-f401fc1f621c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c66e3bd9-9964-4dde-b677-9826e0806184"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fb09c770-328d-4aed-86af-60d56d70ba76"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb1030fe-b7c6-4937-b253-650a40ef5432"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""09d088a5-a6a6-4543-90d7-99dbc5fefe1c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2a4cd88e-feab-4d1f-ad4c-5fe1242e3a58"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30455ce4-f2b4-488e-a96a-6e97f8c80f7d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwapSize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d913f0e-73f2-48a1-b3cb-1a3daa22815a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2034d2fe-c6c6-4104-aa45-507e0db27573"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a12a43a2-42e1-4cff-a9cf-37b3d5e53614"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Esther
        m_Esther = asset.FindActionMap("Esther", throwIfNotFound: true);
        m_Esther_Move = m_Esther.FindAction("Move", throwIfNotFound: true);
        m_Esther_Look = m_Esther.FindAction("Look", throwIfNotFound: true);
        m_Esther_SwapSize = m_Esther.FindAction("SwapSize", throwIfNotFound: true);
        m_Esther_SelectObject = m_Esther.FindAction("SelectObject", throwIfNotFound: true);
        m_Esther_PauseGame = m_Esther.FindAction("PauseGame", throwIfNotFound: true);
        m_Esther_Interact = m_Esther.FindAction("Interact", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Esther
    private readonly InputActionMap m_Esther;
    private IEstherActions m_EstherActionsCallbackInterface;
    private readonly InputAction m_Esther_Move;
    private readonly InputAction m_Esther_Look;
    private readonly InputAction m_Esther_SwapSize;
    private readonly InputAction m_Esther_SelectObject;
    private readonly InputAction m_Esther_PauseGame;
    private readonly InputAction m_Esther_Interact;
    public struct EstherActions
    {
        private @Controls m_Wrapper;
        public EstherActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Esther_Move;
        public InputAction @Look => m_Wrapper.m_Esther_Look;
        public InputAction @SwapSize => m_Wrapper.m_Esther_SwapSize;
        public InputAction @SelectObject => m_Wrapper.m_Esther_SelectObject;
        public InputAction @PauseGame => m_Wrapper.m_Esther_PauseGame;
        public InputAction @Interact => m_Wrapper.m_Esther_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Esther; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EstherActions set) { return set.Get(); }
        public void SetCallbacks(IEstherActions instance)
        {
            if (m_Wrapper.m_EstherActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnLook;
                @SwapSize.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnSwapSize;
                @SwapSize.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnSwapSize;
                @SwapSize.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnSwapSize;
                @SelectObject.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnSelectObject;
                @SelectObject.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnSelectObject;
                @SelectObject.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnSelectObject;
                @PauseGame.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnPauseGame;
                @Interact.started -= m_Wrapper.m_EstherActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_EstherActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_EstherActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_EstherActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @SwapSize.started += instance.OnSwapSize;
                @SwapSize.performed += instance.OnSwapSize;
                @SwapSize.canceled += instance.OnSwapSize;
                @SelectObject.started += instance.OnSelectObject;
                @SelectObject.performed += instance.OnSelectObject;
                @SelectObject.canceled += instance.OnSelectObject;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public EstherActions @Esther => new EstherActions(this);
    public interface IEstherActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSwapSize(InputAction.CallbackContext context);
        void OnSelectObject(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
