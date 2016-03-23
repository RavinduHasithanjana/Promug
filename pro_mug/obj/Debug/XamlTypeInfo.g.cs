﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace pro_mug
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace pro_mug.pro_mug_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[19];
            _typeNameTable[0] = "pro_mug.BlankPage2";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "Microsoft.Xaml.Interactivity.Interaction";
            _typeNameTable[4] = "Object";
            _typeNameTable[5] = "Microsoft.Xaml.Interactivity.BehaviorCollection";
            _typeNameTable[6] = "Windows.UI.Xaml.DependencyObjectCollection";
            _typeNameTable[7] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[8] = "Microsoft.Xaml.Interactions.Core.EventTriggerBehavior";
            _typeNameTable[9] = "Microsoft.Xaml.Interactivity.ActionCollection";
            _typeNameTable[10] = "String";
            _typeNameTable[11] = "Microsoft.Xaml.Interactions.Media.PlaySoundAction";
            _typeNameTable[12] = "Double";
            _typeNameTable[13] = "pro_mug.Login";
            _typeNameTable[14] = "pro_mug.MainMenu";
            _typeNameTable[15] = "pro_mug.MainPage";
            _typeNameTable[16] = "pro_mug.Register";
            _typeNameTable[17] = "pro_mug.RegisterPart2";
            _typeNameTable[18] = "pro_mug.BlankPage1";

            _typeTable = new global::System.Type[19];
            _typeTable[0] = typeof(global::pro_mug.BlankPage2);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::Microsoft.Xaml.Interactivity.Interaction);
            _typeTable[4] = typeof(global::System.Object);
            _typeTable[5] = typeof(global::Microsoft.Xaml.Interactivity.BehaviorCollection);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.DependencyObjectCollection);
            _typeTable[7] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[8] = typeof(global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior);
            _typeTable[9] = typeof(global::Microsoft.Xaml.Interactivity.ActionCollection);
            _typeTable[10] = typeof(global::System.String);
            _typeTable[11] = typeof(global::Microsoft.Xaml.Interactions.Media.PlaySoundAction);
            _typeTable[12] = typeof(global::System.Double);
            _typeTable[13] = typeof(global::pro_mug.Login);
            _typeTable[14] = typeof(global::pro_mug.MainMenu);
            _typeTable[15] = typeof(global::pro_mug.MainPage);
            _typeTable[16] = typeof(global::pro_mug.Register);
            _typeTable[17] = typeof(global::pro_mug.RegisterPart2);
            _typeTable[18] = typeof(global::pro_mug.BlankPage1);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_BlankPage2() { return new global::pro_mug.BlankPage2(); }
        private object Activate_5_BehaviorCollection() { return new global::Microsoft.Xaml.Interactivity.BehaviorCollection(); }
        private object Activate_8_EventTriggerBehavior() { return new global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior(); }
        private object Activate_9_ActionCollection() { return new global::Microsoft.Xaml.Interactivity.ActionCollection(); }
        private object Activate_11_PlaySoundAction() { return new global::Microsoft.Xaml.Interactions.Media.PlaySoundAction(); }
        private object Activate_13_Login() { return new global::pro_mug.Login(); }
        private object Activate_14_MainMenu() { return new global::pro_mug.MainMenu(); }
        private object Activate_15_MainPage() { return new global::pro_mug.MainPage(); }
        private object Activate_16_Register() { return new global::pro_mug.Register(); }
        private object Activate_17_RegisterPart2() { return new global::pro_mug.RegisterPart2(); }
        private object Activate_18_BlankPage1() { return new global::pro_mug.BlankPage1(); }
        private void VectorAdd_5_BehaviorCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Windows.UI.Xaml.DependencyObject>)instance;
            var newItem = (global::Windows.UI.Xaml.DependencyObject)item;
            collection.Add(newItem);
        }
        private void VectorAdd_9_ActionCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Windows.UI.Xaml.DependencyObject>)instance;
            var newItem = (global::Windows.UI.Xaml.DependencyObject)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  pro_mug.BlankPage2
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_BlankPage2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Microsoft.Xaml.Interactivity.Interaction
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("Behaviors");
                xamlType = userType;
                break;

            case 4:   //  Object
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Microsoft.Xaml.Interactivity.BehaviorCollection
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObjectCollection"));
                userType.CollectionAdd = VectorAdd_5_BehaviorCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 6:   //  Windows.UI.Xaml.DependencyObjectCollection
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Microsoft.Xaml.Interactions.Core.EventTriggerBehavior
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.Activator = Activate_8_EventTriggerBehavior;
                userType.SetContentPropertyName("Microsoft.Xaml.Interactions.Core.EventTriggerBehavior.Actions");
                userType.AddMemberName("Actions");
                userType.AddMemberName("EventName");
                userType.AddMemberName("SourceObject");
                userType.AddMemberName("AssociatedObject");
                xamlType = userType;
                break;

            case 9:   //  Microsoft.Xaml.Interactivity.ActionCollection
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObjectCollection"));
                userType.CollectionAdd = VectorAdd_9_ActionCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 10:   //  String
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Microsoft.Xaml.Interactions.Media.PlaySoundAction
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.Activator = Activate_11_PlaySoundAction;
                userType.AddMemberName("Source");
                userType.AddMemberName("Volume");
                xamlType = userType;
                break;

            case 12:   //  Double
                xamlType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  pro_mug.Login
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Login;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  pro_mug.MainMenu
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_MainMenu;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  pro_mug.MainPage
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  pro_mug.Register
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_Register;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  pro_mug.RegisterPart2
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_RegisterPart2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  pro_mug.BlankPage1
                userType = new global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_BlankPage1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_Interaction_Behaviors(object instance)
        {
            return global::Microsoft.Xaml.Interactivity.Interaction.GetBehaviors((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_0_Interaction_Behaviors(object instance, object Value)
        {
            global::Microsoft.Xaml.Interactivity.Interaction.SetBehaviors((global::Windows.UI.Xaml.DependencyObject)instance, (global::Microsoft.Xaml.Interactivity.BehaviorCollection)Value);
        }
        private object get_1_EventTriggerBehavior_Actions(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            return that.Actions;
        }
        private object get_2_EventTriggerBehavior_EventName(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            return that.EventName;
        }
        private void set_2_EventTriggerBehavior_EventName(object instance, object Value)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            that.EventName = (global::System.String)Value;
        }
        private object get_3_EventTriggerBehavior_SourceObject(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            return that.SourceObject;
        }
        private void set_3_EventTriggerBehavior_SourceObject(object instance, object Value)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            that.SourceObject = (global::System.Object)Value;
        }
        private object get_4_EventTriggerBehavior_AssociatedObject(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Core.EventTriggerBehavior)instance;
            return that.AssociatedObject;
        }
        private object get_5_PlaySoundAction_Source(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Media.PlaySoundAction)instance;
            return that.Source;
        }
        private void set_5_PlaySoundAction_Source(object instance, object Value)
        {
            var that = (global::Microsoft.Xaml.Interactions.Media.PlaySoundAction)instance;
            that.Source = (global::System.String)Value;
        }
        private object get_6_PlaySoundAction_Volume(object instance)
        {
            var that = (global::Microsoft.Xaml.Interactions.Media.PlaySoundAction)instance;
            return that.Volume;
        }
        private void set_6_PlaySoundAction_Volume(object instance, object Value)
        {
            var that = (global::Microsoft.Xaml.Interactions.Media.PlaySoundAction)instance;
            that.Volume = (global::System.Double)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::pro_mug.pro_mug_XamlTypeInfo.XamlMember xamlMember = null;
            global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Microsoft.Xaml.Interactivity.Interaction.Behaviors":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactivity.Interaction");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "Behaviors", "Microsoft.Xaml.Interactivity.BehaviorCollection");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_0_Interaction_Behaviors;
                xamlMember.Setter = set_0_Interaction_Behaviors;
                break;
            case "Microsoft.Xaml.Interactions.Core.EventTriggerBehavior.Actions":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Core.EventTriggerBehavior");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "Actions", "Microsoft.Xaml.Interactivity.ActionCollection");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_EventTriggerBehavior_Actions;
                xamlMember.SetIsReadOnly();
                break;
            case "Microsoft.Xaml.Interactions.Core.EventTriggerBehavior.EventName":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Core.EventTriggerBehavior");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "EventName", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_EventTriggerBehavior_EventName;
                xamlMember.Setter = set_2_EventTriggerBehavior_EventName;
                break;
            case "Microsoft.Xaml.Interactions.Core.EventTriggerBehavior.SourceObject":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Core.EventTriggerBehavior");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "SourceObject", "Object");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_EventTriggerBehavior_SourceObject;
                xamlMember.Setter = set_3_EventTriggerBehavior_SourceObject;
                break;
            case "Microsoft.Xaml.Interactions.Core.EventTriggerBehavior.AssociatedObject":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Core.EventTriggerBehavior");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "AssociatedObject", "Windows.UI.Xaml.DependencyObject");
                xamlMember.Getter = get_4_EventTriggerBehavior_AssociatedObject;
                xamlMember.SetIsReadOnly();
                break;
            case "Microsoft.Xaml.Interactions.Media.PlaySoundAction.Source":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Media.PlaySoundAction");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "Source", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_5_PlaySoundAction_Source;
                xamlMember.Setter = set_5_PlaySoundAction_Source;
                break;
            case "Microsoft.Xaml.Interactions.Media.PlaySoundAction.Volume":
                userType = (global::pro_mug.pro_mug_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Xaml.Interactions.Media.PlaySoundAction");
                xamlMember = new global::pro_mug.pro_mug_XamlTypeInfo.XamlMember(this, "Volume", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_6_PlaySoundAction_Volume;
                xamlMember.Setter = set_6_PlaySoundAction_Volume;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::pro_mug.pro_mug_XamlTypeInfo.XamlSystemBaseType
    {
        global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::pro_mug.pro_mug_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


