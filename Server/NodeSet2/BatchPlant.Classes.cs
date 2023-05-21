/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BatchPlant
{
    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AEdlbmVyaWNTZW5zb3JUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////AgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQECAAAvAQBACQIAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEG" +
           "AAAuAEQGAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBCAAALgBECAAAAAAM" +
           "/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case BatchPlant.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_units;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGwAA" +
           "AEdlbmVyaWNBY3R1YXRvclR5cGVJbnN0YW5jZQEBCQABAQkACQAAAP////8CAAAAFWCJCgIAAAABAAUA" +
           "AABJbnB1dAEBCgAALwEAQAkKAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "DgAALgBEDgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEQAAAvAQBACRAA" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEUAAAuAEQUAAAAAQB0A/////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }

                case BatchPlant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericMotorState Class
    #if (!OPCUA_EXCLUDE_GenericMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGAAA" +
           "AEdlbmVyaWNNb3RvclR5cGVJbnN0YW5jZQEBFgABARYAFgAAAP////8BAAAAFWCJCgIAAAABAAUAAABT" +
           "cGVlZAEBFwAALwEAQAkXAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBGwAA" +
           "LgBEGwAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_speed;
        #endregion
    }
    #endif
    #endregion

    #region LevelIndicatorState Class
    #if (!OPCUA_EXCLUDE_LevelIndicatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelIndicatorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public LevelIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGgAA" +
           "AExldmVsSW5kaWNhdG9yVHlwZUluc3RhbmNlAQEdAAEBHQAdAAAA/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBHgAALwEAQAkeAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "IgAALgBEIgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBASQAAC4ARCQAAAAA" +
           "DP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadcellTransmitterState Class
    #if (!OPCUA_EXCLUDE_LoadcellTransmitterState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadcellTransmitterState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public LoadcellTransmitterState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAHwAA" +
           "AExvYWRjZWxsVHJhbnNtaXR0ZXJUeXBlSW5zdGFuY2UBASUAAQElACUAAAD/////AwAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AQEmAAAvAQBACSYAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEqAAAuAEQqAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBLAAALgBE" +
           "LAAAAAAM/////wMD/////wAAAAAVYIkKAgAAAAEAEQAAAEV4Y2l0YXRpb25Wb2x0YWdlAQEtAAAvAQBA" +
           "CS0AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQExAAAuAEQxAAAAAQB0A///" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> ExcitationVoltage
        {
            get
            {
                return m_excitationVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_excitationVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_excitationVoltage = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_excitationVoltage != null)
            {
                children.Add(m_excitationVoltage);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.ExcitationVoltage:
                {
                    if (createOrReplace)
                    {
                        if (ExcitationVoltage == null)
                        {
                            if (replacement == null)
                            {
                                ExcitationVoltage = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ExcitationVoltage = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ExcitationVoltage;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_excitationVoltage;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFZhbHZlVHlwZUluc3RhbmNlAQEzAAEBMwAzAAAA/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQE0" +
           "AAAvAQBACTQAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE4AAAuAEQ4AAAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAToAAC8BAEAJOgAAAAAL/////wMD" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAT4AAC4ARD4AAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MixerMotorState Class
    #if (!OPCUA_EXCLUDE_MixerMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public MixerMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFgAA" +
           "AE1peGVyTW90b3JUeXBlSW5zdGFuY2UBAUAAAQFAAEAAAAD/////AQAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBAUEAAC8BAEAJQQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUUAAC4A" +
           "REUAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConveyorMotorState Class
    #if (!OPCUA_EXCLUDE_ConveyorMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public ConveyorMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AENvbnZleW9yTW90b3JUeXBlSW5zdGFuY2UBAUcAAQFHAEcAAAD/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "U3BlZWQBAUgAAC8BAEAJSAAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUwA" +
           "AC4AREwAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Silo1State Class
    #if (!OPCUA_EXCLUDE_Silo1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo1State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8xVHlwZUluc3RhbmNlAQFOAAEBTgBOAAAAAQAAAAAwAAEBTwACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzFMZXZlbEluZGljYXRvcgEABQAAAExJMDAxAQFPAAAvAQEdAE8AAAABAQAAAAAwAQEBTgACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAVAAAC8BAEAJUAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAVQAAC4ARFQAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFW" +
           "AAAuAERWAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8xRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMQEBVwAALwEBMwBXAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBWAAALwEA" +
           "QAlYAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBXAAALgBEXAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFeAAAvAQBACV4AAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFiAAAuAERiAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo1LevelIndicator
        {
            get
            {
                return m_silo1LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo1DischargeValve
        {
            get
            {
                return m_silo1DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo1LevelIndicator != null)
            {
                children.Add(m_silo1LevelIndicator);
            }

            if (m_silo1DischargeValve != null)
            {
                children.Add(m_silo1DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo1LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo1LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo1LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo1LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo1LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo1DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo1DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo1DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo1DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo1DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo1LevelIndicator;
        private ValveState m_silo1DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Silo2State Class
    #if (!OPCUA_EXCLUDE_Silo2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo2State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8yVHlwZUluc3RhbmNlAQFkAAEBZABkAAAAAQAAAAAwAAEBZQACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzJMZXZlbEluZGljYXRvcgEABQAAAExJMDAyAQFlAAAvAQEdAGUAAAABAQAAAAAwAQEBZAACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAWYAAC8BAEAJZgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAWoAAC4ARGoAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFs" +
           "AAAuAERsAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8yRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMgEBbQAALwEBMwBtAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBbgAALwEA" +
           "QAluAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBcgAALgBEcgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQF0AAAvAQBACXQAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQF4AAAuAER4AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo2LevelIndicator
        {
            get
            {
                return m_silo2LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo2DischargeValve
        {
            get
            {
                return m_silo2DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo2LevelIndicator != null)
            {
                children.Add(m_silo2LevelIndicator);
            }

            if (m_silo2DischargeValve != null)
            {
                children.Add(m_silo2DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo2LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo2LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo2LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo2LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo2LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo2DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo2DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo2DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo2DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo2DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo2LevelIndicator;
        private ValveState m_silo2DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Silo3State Class
    #if (!OPCUA_EXCLUDE_Silo3State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo3State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo3State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8zVHlwZUluc3RhbmNlAQF6AAEBegB6AAAAAQAAAAAwAAEBewACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAzAQF7AAAvAQEdAHsAAAABAQAAAAAwAQEBegACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAXwAAC8BAEAJfAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAYAAAC4ARIAAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQGC" +
           "AAAuAESCAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMwEBgwAALwEBMwCDAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBhAAALwEA" +
           "QAmEAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiAAALgBEiAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGKAAAvAQBACYoAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGOAAAuAESOAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo3LevelIndicator
        {
            get
            {
                return m_silo3LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo3DischargeValve
        {
            get
            {
                return m_silo3DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo3LevelIndicator != null)
            {
                children.Add(m_silo3LevelIndicator);
            }

            if (m_silo3DischargeValve != null)
            {
                children.Add(m_silo3DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo3LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo3LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo3LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo3LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo3LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo3DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo3DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo3DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo3DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo3DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo3LevelIndicator;
        private ValveState m_silo3DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region MixerState Class
    #if (!OPCUA_EXCLUDE_MixerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MixerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AE1peGVyVHlwZUluc3RhbmNlAQGQAAEBkACQAAAAAQAAAAAwAAEBkQADAAAAhGDACgEAAAATAAAATG9h" +
           "ZGNlbGxUcmFuc21pdHRlcgEABQAAAExUMDAxAQGRAAAvAQElAJEAAAABAQAAAAAwAQEBkAADAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAZIAAC8BAEAJkgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAZYAAC4ARJYAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQGY" +
           "AAAuAESYAAAAAAz/////AwP/////AAAAABVgiQoCAAAAAQARAAAARXhjaXRhdGlvblZvbHRhZ2UBAZkA" +
           "AC8BAEAJmQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ0AAC4ARJ0AAAAB" +
           "AHQD/////wEB/////wAAAACEYMAKAQAAAAoAAABNaXhlck1vdG9yAQAHAAAATW90b3IwMQEBnwAALwEB" +
           "QACfAAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBoAAALwEAQAmgAAAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpAAALgBEpAAAAAEAdAP/////AQH/////AAAAAIRgwAoB" +
           "AAAAEwAAAE1peGVyRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwNAEBpgAALwEBMwCmAAAAAf////8C" +
           "AAAAFWCJCgIAAAABAAUAAABJbnB1dAEBpwAALwEAQAmnAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBqwAALgBEqwAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGtAAAvAQBACa0AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGxAAAu" +
           "AESxAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LoadcellTransmitterState LoadcellTransmitter
        {
            get
            {
                return m_loadcellTransmitter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_loadcellTransmitter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_loadcellTransmitter = value;
            }
        }

        /// <remarks />
        public MixerMotorState MixerMotor
        {
            get
            {
                return m_mixerMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixerMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixerMotor = value;
            }
        }

        /// <remarks />
        public ValveState MixerDischargeValve
        {
            get
            {
                return m_mixerDischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixerDischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixerDischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_loadcellTransmitter != null)
            {
                children.Add(m_loadcellTransmitter);
            }

            if (m_mixerMotor != null)
            {
                children.Add(m_mixerMotor);
            }

            if (m_mixerDischargeValve != null)
            {
                children.Add(m_mixerDischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.LoadcellTransmitter:
                {
                    if (createOrReplace)
                    {
                        if (LoadcellTransmitter == null)
                        {
                            if (replacement == null)
                            {
                                LoadcellTransmitter = new LoadcellTransmitterState(this);
                            }
                            else
                            {
                                LoadcellTransmitter = (LoadcellTransmitterState)replacement;
                            }
                        }
                    }

                    instance = LoadcellTransmitter;
                    break;
                }

                case BatchPlant.BrowseNames.MixerMotor:
                {
                    if (createOrReplace)
                    {
                        if (MixerMotor == null)
                        {
                            if (replacement == null)
                            {
                                MixerMotor = new MixerMotorState(this);
                            }
                            else
                            {
                                MixerMotor = (MixerMotorState)replacement;
                            }
                        }
                    }

                    instance = MixerMotor;
                    break;
                }

                case BatchPlant.BrowseNames.MixerDischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (MixerDischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                MixerDischargeValve = new ValveState(this);
                            }
                            else
                            {
                                MixerDischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = MixerDischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LoadcellTransmitterState m_loadcellTransmitter;
        private MixerMotorState m_mixerMotor;
        private ValveState m_mixerDischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region PackagingUnitState Class
    #if (!OPCUA_EXCLUDE_PackagingUnitState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PackagingUnitState : FolderState
    {
        #region Constructors
        /// <remarks />
        public PackagingUnitState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AFBhY2thZ2luZ1VuaXRUeXBlSW5zdGFuY2UBAbMAAQGzALMAAAABAAAAADAAAQG0AAEAAACEYMAKAQAA" +
           "ABsAAABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBtAAALwEBHQC0AAAAAQEA" +
           "AAAAMAEBAbMAAgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQG1AAAvAQBACbUAAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQG5AAAuAES5AAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAUAAABVbml0cwEBuwAALgBEuwAAAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState PackagingUnitLevelIndicator
        {
            get
            {
                return m_packagingUnitLevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnitLevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnitLevelIndicator = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_packagingUnitLevelIndicator != null)
            {
                children.Add(m_packagingUnitLevelIndicator);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.PackagingUnitLevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnitLevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnitLevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                PackagingUnitLevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnitLevelIndicator;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_packagingUnitLevelIndicator;
        #endregion
    }
    #endif
    #endregion

    #region ConveyorState Class
    #if (!OPCUA_EXCLUDE_ConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorState : FolderState
    {
        #region Constructors
        /// <remarks />
        public ConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFAAA" +
           "AENvbnZleW9yVHlwZUluc3RhbmNlAQG8AAEBvAC8AAAAAQAAAAAwAAEBvQABAAAAhGDACgEAAAANAAAA" +
           "Q29udmV5b3JNb3RvcgEABwAAAE1vdG9yMDIBAb0AAC8BAUcAvQAAAAEBAAAAADABAQG8AAEAAAAVYIkK" +
           "AgAAAAEABQAAAFNwZWVkAQG+AAAvAQBACb4AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHCAAAuAETCAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ConveyorMotorState ConveyorMotor
        {
            get
            {
                return m_conveyorMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyorMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyorMotor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_conveyorMotor != null)
            {
                children.Add(m_conveyorMotor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.ConveyorMotor:
                {
                    if (createOrReplace)
                    {
                        if (ConveyorMotor == null)
                        {
                            if (replacement == null)
                            {
                                ConveyorMotor = new ConveyorMotorState(this);
                            }
                            else
                            {
                                ConveyorMotor = (ConveyorMotorState)replacement;
                            }
                        }
                    }

                    instance = ConveyorMotor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ConveyorMotorState m_conveyorMotor;
        #endregion
    }
    #endif
    #endregion

    #region BatchPlantState Class
    #if (!OPCUA_EXCLUDE_BatchPlantState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BatchPlantState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BatchPlantState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////+EYIACAQAAAAEAFgAA" +
           "AEJhdGNoUGxhbnRUeXBlSW5zdGFuY2UBAcQAAQHEAMQAAAABBgAAAAAwAAEBxQAAMAABAd0AADAAAQH1" +
           "AAAwAAEBDQEAMAABATIBADAAAQE7AQgAAACEYMAKAQAAAAUAAABTaWxvMQEACAAAAFNpbG9YMDAxAQHF" +
           "AAAvAQFOAMUAAAABAgAAAAAwAQEBxAAAMAABAcYAAwAAAIRgwAoBAAAAEwAAAFNpbG8xTGV2ZWxJbmRp" +
           "Y2F0b3IBAAUAAABMSTAwMQEBxgAALwEBHQDGAAAAAQEAAAAAMAEBAcUAAgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQHHAAAvAQBACccAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHL" +
           "AAAuAETLAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBzQAALgBEzQAAAAAM" +
           "/////wMD/////wAAAACEYMAKAQAAABMAAABTaWxvMURpc2NoYXJnZVZhbHZlAQAIAAAAVmFsdmUwMDEB" +
           "Ac4AAC8BATMAzgAAAAH/////AgAAABVgiQoCAAAAAQAFAAAASW5wdXQBAc8AAC8BAEAJzwAAAAAL////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdMAAC4ARNMAAAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEB1QAALwEAQAnVAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB2QAALgBE2QAAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAQAOAAAARGlz" +
           "Y2hhcmdlVmFsdmUBAdsAAC8AOtsAAAD/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAdwAAC8AP9wA" +
           "AAAAGP////8BAf////8AAAAAhGDACgEAAAAFAAAAU2lsbzIBAAgAAABTaWxvWDAwMgEB3QAALwEBZADd" +
           "AAAAAQIAAAAAMAEBAcQAADAAAQHeAAMAAACEYMAKAQAAABMAAABTaWxvMkxldmVsSW5kaWNhdG9yAQAF" +
           "AAAATEkwMDIBAd4AAC8BAR0A3gAAAAEBAAAAADABAQHdAAIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "3wAALwEAQAnfAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4wAALgBE4wAA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAeUAAC4AROUAAAAADP////8DA///" +
           "//8AAAAAhGDACgEAAAATAAAAU2lsbzJEaXNjaGFyZ2VWYWx2ZQEACAAAAFZhbHZlMDAyAQHmAAAvAQEz" +
           "AOYAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQHnAAAvAQBACecAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHrAAAuAETrAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAe0AAC8BAEAJ7QAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAfEAAC4ARPEAAAABAHQD/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAERpc2NoYXJnZVZh" +
           "bHZlAQHzAAAvADrzAAAA/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQH0AAAvAD/0AAAAABj/////" +
           "AQH/////AAAAAIRgwAoBAAAABQAAAFNpbG8zAQAIAAAAU2lsb1gwMDMBAfUAAC8BAXoA9QAAAAECAAAA" +
           "ADABAQHEAAAwAAEB9gADAAAAhGDACgEAAAATAAAAU2lsbzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAz" +
           "AQH2AAAvAQEdAPYAAAABAQAAAAAwAQEB9QACAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAfcAAC8BAEAJ" +
           "9wAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAfsAAC4ARPsAAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQH9AAAuAET9AAAAAAz/////AwP/////AAAAAIRg" +
           "wAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwMwEB/gAALwEBMwD+AAAAAf//" +
           "//8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB/wAALwEAQAn/AAAAAAv/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBAwEALgBEAwEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQEFAQAvAQBACQUBAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEJ" +
           "AQAuAEQJAQAAAQB0A/////8BAf////8AAAAABGCACgEAAAABAA4AAABEaXNjaGFyZ2VWYWx2ZQEBCwEA" +
           "LwA6CwEAAP////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBDAEALwA/DAEAAAAY/////wEB/////wAA" +
           "AACEYMAKAQAAAAUAAABNaXhlcgEACQAAAE1peGVyWDAwMQEBDQEALwEBkAANAQAAAQIAAAAAMAEBAcQA" +
           "ADAAAQEOAQQAAACEYMAKAQAAABMAAABMb2FkY2VsbFRyYW5zbWl0dGVyAQAFAAAATFQwMDEBAQ4BAC8B" +
           "ASUADgEAAAEBAAAAADABAQENAQMAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBDwEALwEAQAkPAQAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBEwEALgBEEwEAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBARUBAC4ARBUBAAAADP////8DA/////8AAAAAFWCJCgIAAAAB" +
           "ABEAAABFeGNpdGF0aW9uVm9sdGFnZQEBFgEALwEAQAkWAQAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBGgEALgBEGgEAAAEAdAP/////AQH/////AAAAAIRgwAoBAAAACgAAAE1peGVy" +
           "TW90b3IBAAcAAABNb3RvcjAxAQEcAQAvAQFAABwBAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFNwZWVk" +
           "AQEdAQAvAQBACR0BAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEhAQAuAEQh" +
           "AQAAAQB0A/////8BAf////8AAAAAhGDACgEAAAATAAAATWl4ZXJEaXNjaGFyZ2VWYWx2ZQEACAAAAFZh" +
           "bHZlMDA0AQEjAQAvAQEzACMBAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQEkAQAvAQBACSQB" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEoAQAuAEQoAQAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBASoBAC8BAEAJKgEAAAAL/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAS4BAC4ARC4BAAABAHQD/////wEB/////wAAAAAEYIAKAQAAAAEA" +
           "DgAAAERpc2NoYXJnZVZhbHZlAQEwAQAvADowAQAA/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQEx" +
           "AQAvAD8xAQAAABj/////AQH/////AAAAAIRgwAoBAAAADQAAAFBhY2thZ2luZ1VuaXQBABEAAABQYWNr" +
           "YWdpbmdVbml0WDAwMQEBMgEALwEBswAyAQAAAQIAAAAAMAEBAcQAADAAAQEzAQEAAACEYMAKAQAAABsA" +
           "AABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBMwEALwEBHQAzAQAAAQEAAAAA" +
           "MAEBATIBAgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQE0AQAvAQBACTQBAAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQE4AQAuAEQ4AQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAUAAABVbml0cwEBOgEALgBEOgEAAAAM/////wMD/////wAAAACEYMAKAQAAAAgAAABDb252ZXlvcgEA" +
           "DAAAAENvbnZleW9yWDAwMQEBOwEALwEBvAA7AQAAAQIAAAAAMAEBAcQAADAAAQE8AQEAAACEYMAKAQAA" +
           "AA0AAABDb252ZXlvck1vdG9yAQAHAAAATW90b3IwMgEBPAEALwEBRwA8AQAAAQEAAAAAMAEBATsBAQAA" +
           "ABVgiQoCAAAAAQAFAAAAU3BlZWQBAT0BAC8BAEAJPQEAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAUEBAC4AREEBAAABAHQD/////wEB/////wAAAAAEYYIKBAAAAAEADAAAAFN0YXJ0" +
           "UHJvY2VzcwEBQwEALwEBQwFDAQAAAQH/////AAAAAARhggoEAAAAAQALAAAAU3RvcFByb2Nlc3MBAUQB" +
           "AC8BAUQBRAEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public Silo1State Silo1
        {
            get
            {
                return m_silo1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1 = value;
            }
        }

        /// <remarks />
        public Silo2State Silo2
        {
            get
            {
                return m_silo2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2 = value;
            }
        }

        /// <remarks />
        public Silo3State Silo3
        {
            get
            {
                return m_silo3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3 = value;
            }
        }

        /// <remarks />
        public MixerState Mixer
        {
            get
            {
                return m_mixer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixer = value;
            }
        }

        /// <remarks />
        public PackagingUnitState PackagingUnit
        {
            get
            {
                return m_packagingUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnit = value;
            }
        }

        /// <remarks />
        public ConveyorState Conveyor
        {
            get
            {
                return m_conveyor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyor = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo1 != null)
            {
                children.Add(m_silo1);
            }

            if (m_silo2 != null)
            {
                children.Add(m_silo2);
            }

            if (m_silo3 != null)
            {
                children.Add(m_silo3);
            }

            if (m_mixer != null)
            {
                children.Add(m_mixer);
            }

            if (m_packagingUnit != null)
            {
                children.Add(m_packagingUnit);
            }

            if (m_conveyor != null)
            {
                children.Add(m_conveyor);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo1:
                {
                    if (createOrReplace)
                    {
                        if (Silo1 == null)
                        {
                            if (replacement == null)
                            {
                                Silo1 = new Silo1State(this);
                            }
                            else
                            {
                                Silo1 = (Silo1State)replacement;
                            }
                        }
                    }

                    instance = Silo1;
                    break;
                }

                case BatchPlant.BrowseNames.Silo2:
                {
                    if (createOrReplace)
                    {
                        if (Silo2 == null)
                        {
                            if (replacement == null)
                            {
                                Silo2 = new Silo2State(this);
                            }
                            else
                            {
                                Silo2 = (Silo2State)replacement;
                            }
                        }
                    }

                    instance = Silo2;
                    break;
                }

                case BatchPlant.BrowseNames.Silo3:
                {
                    if (createOrReplace)
                    {
                        if (Silo3 == null)
                        {
                            if (replacement == null)
                            {
                                Silo3 = new Silo3State(this);
                            }
                            else
                            {
                                Silo3 = (Silo3State)replacement;
                            }
                        }
                    }

                    instance = Silo3;
                    break;
                }

                case BatchPlant.BrowseNames.Mixer:
                {
                    if (createOrReplace)
                    {
                        if (Mixer == null)
                        {
                            if (replacement == null)
                            {
                                Mixer = new MixerState(this);
                            }
                            else
                            {
                                Mixer = (MixerState)replacement;
                            }
                        }
                    }

                    instance = Mixer;
                    break;
                }

                case BatchPlant.BrowseNames.PackagingUnit:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnit == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnit = new PackagingUnitState(this);
                            }
                            else
                            {
                                PackagingUnit = (PackagingUnitState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnit;
                    break;
                }

                case BatchPlant.BrowseNames.Conveyor:
                {
                    if (createOrReplace)
                    {
                        if (Conveyor == null)
                        {
                            if (replacement == null)
                            {
                                Conveyor = new ConveyorState(this);
                            }
                            else
                            {
                                Conveyor = (ConveyorState)replacement;
                            }
                        }
                    }

                    instance = Conveyor;
                    break;
                }

                case BatchPlant.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case BatchPlant.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private Silo1State m_silo1;
        private Silo2State m_silo2;
        private Silo3State m_silo3;
        private MixerState m_mixer;
        private PackagingUnitState m_packagingUnit;
        private ConveyorState m_conveyor;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}