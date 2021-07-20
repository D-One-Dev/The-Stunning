// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""10d061a4-b94b-4615-b3ab-48e507aa7ba4"",
            ""actions"": [
                {
                    ""name"": ""AnyKey"",
                    ""type"": ""Button"",
                    ""id"": ""707f6120-e0cf-4a6c-af87-66f7479d4290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StringUp"",
                    ""type"": ""Button"",
                    ""id"": ""6776322c-3597-47e3-ac16-1e93b7f69242"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StringDown"",
                    ""type"": ""Button"",
                    ""id"": ""742e969e-6e3d-4634-b4fd-a655fbced03a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""c12b6af5-0791-40dc-b6da-fb19e1e87da5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StringLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3914330a-89c3-4b95-8f72-167df615a454"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StringRight"",
                    ""type"": ""Button"",
                    ""id"": ""3bbe210f-0090-411c-b05e-ef32223504e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95964dfb-4595-4419-8ad1-07fd24e23025"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a42c3bc-5aaa-4cc8-95da-cd22bff2a069"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""758b88f4-3457-48da-a1fc-c533a39ecde0"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8671c495-9fa6-4b8a-a128-7a5d7b78c506"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36d5e222-842f-4f9b-b5dd-68e28737d2eb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""095e787c-e021-479e-965b-76b128709d5d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebd06367-df7e-4d41-b9f6-8f1567aa456f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0588fd0-69bc-4dfc-a4ce-f43bdca53923"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3571e99c-aa26-467e-b680-1a2914bcb248"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""588d6f54-66fb-4b6a-a3da-ab2ac9eb3794"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e7c2f4e-5fd6-4653-87e9-886f30ec0350"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f636a593-25b4-4eb6-9952-b5e81eb39598"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StringUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7a30207-d778-4826-b0ed-dcc8da55df96"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StringUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3be03bf9-3123-446a-84a4-d6f61ff1a18b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StringDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2cb4061-1781-457e-8fc9-bb0ba1d0bf65"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StringDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f21ed59-eca0-4277-a7bb-470e61e4a76e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31fa7193-15f9-4381-afdb-afe7c4440ee9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d269190-f890-4f8f-a1d6-f1ae6a1ed0c7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StringLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d1b17be-2450-45e0-a765-a8e261aeb052"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StringLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fba022eb-4554-4b4c-ad9d-66a43936a042"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StringRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""961e22b4-0fc0-4bcf-8a7e-17f0fb051650"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StringRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_AnyKey = m_Menu.FindAction("AnyKey", throwIfNotFound: true);
        m_Menu_StringUp = m_Menu.FindAction("StringUp", throwIfNotFound: true);
        m_Menu_StringDown = m_Menu.FindAction("StringDown", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        m_Menu_StringLeft = m_Menu.FindAction("StringLeft", throwIfNotFound: true);
        m_Menu_StringRight = m_Menu.FindAction("StringRight", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_AnyKey;
    private readonly InputAction m_Menu_StringUp;
    private readonly InputAction m_Menu_StringDown;
    private readonly InputAction m_Menu_Select;
    private readonly InputAction m_Menu_StringLeft;
    private readonly InputAction m_Menu_StringRight;
    public struct MenuActions
    {
        private @PlayerInput m_Wrapper;
        public MenuActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AnyKey => m_Wrapper.m_Menu_AnyKey;
        public InputAction @StringUp => m_Wrapper.m_Menu_StringUp;
        public InputAction @StringDown => m_Wrapper.m_Menu_StringDown;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputAction @StringLeft => m_Wrapper.m_Menu_StringLeft;
        public InputAction @StringRight => m_Wrapper.m_Menu_StringRight;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @AnyKey.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnyKey;
                @AnyKey.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnyKey;
                @AnyKey.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnyKey;
                @StringUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringUp;
                @StringUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringUp;
                @StringUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringUp;
                @StringDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringDown;
                @StringDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringDown;
                @StringDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringDown;
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @StringLeft.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringLeft;
                @StringLeft.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringLeft;
                @StringLeft.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringLeft;
                @StringRight.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringRight;
                @StringRight.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringRight;
                @StringRight.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStringRight;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AnyKey.started += instance.OnAnyKey;
                @AnyKey.performed += instance.OnAnyKey;
                @AnyKey.canceled += instance.OnAnyKey;
                @StringUp.started += instance.OnStringUp;
                @StringUp.performed += instance.OnStringUp;
                @StringUp.canceled += instance.OnStringUp;
                @StringDown.started += instance.OnStringDown;
                @StringDown.performed += instance.OnStringDown;
                @StringDown.canceled += instance.OnStringDown;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @StringLeft.started += instance.OnStringLeft;
                @StringLeft.performed += instance.OnStringLeft;
                @StringLeft.canceled += instance.OnStringLeft;
                @StringRight.started += instance.OnStringRight;
                @StringRight.performed += instance.OnStringRight;
                @StringRight.canceled += instance.OnStringRight;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnAnyKey(InputAction.CallbackContext context);
        void OnStringUp(InputAction.CallbackContext context);
        void OnStringDown(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnStringLeft(InputAction.CallbackContext context);
        void OnStringRight(InputAction.CallbackContext context);
    }
}
