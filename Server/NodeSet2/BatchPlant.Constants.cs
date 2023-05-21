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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BatchPlant
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint BatchPlantType_StartProcess = 323;

        /// <remarks />
        public const uint BatchPlantType_StopProcess = 324;

        /// <remarks />
        public const uint BatchPlant1_StartProcess = 452;

        /// <remarks />
        public const uint BatchPlant1_StopProcess = 453;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator = 79;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve = 87;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator = 101;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve = 109;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator = 123;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve = 131;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter = 145;

        /// <remarks />
        public const uint MixerType_MixerMotor = 159;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve = 166;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator = 180;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor = 189;

        /// <remarks />
        public const uint BatchPlantType_Silo1 = 197;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator = 198;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve = 206;

        /// <remarks />
        public const uint BatchPlantType_Silo1_DischargeValve = 219;

        /// <remarks />
        public const uint BatchPlantType_Silo2 = 221;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator = 222;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve = 230;

        /// <remarks />
        public const uint BatchPlantType_Silo2_DischargeValve = 243;

        /// <remarks />
        public const uint BatchPlantType_Silo3 = 245;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator = 246;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve = 254;

        /// <remarks />
        public const uint BatchPlantType_Silo3_DischargeValve = 267;

        /// <remarks />
        public const uint BatchPlantType_Mixer = 269;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter = 270;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor = 284;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve = 291;

        /// <remarks />
        public const uint BatchPlantType_Mixer_DischargeValve = 304;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit = 306;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = 307;

        /// <remarks />
        public const uint BatchPlantType_Conveyor = 315;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor = 316;

        /// <remarks />
        public const uint BatchPlant1 = 325;

        /// <remarks />
        public const uint BatchPlant1_Silo1 = 326;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator = 327;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve = 335;

        /// <remarks />
        public const uint BatchPlant1_Silo1_DischargeValve = 348;

        /// <remarks />
        public const uint BatchPlant1_Silo2 = 350;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator = 351;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve = 359;

        /// <remarks />
        public const uint BatchPlant1_Silo2_DischargeValve = 372;

        /// <remarks />
        public const uint BatchPlant1_Silo3 = 374;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator = 375;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve = 383;

        /// <remarks />
        public const uint BatchPlant1_Silo3_DischargeValve = 396;

        /// <remarks />
        public const uint BatchPlant1_Mixer = 398;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter = 399;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor = 413;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve = 420;

        /// <remarks />
        public const uint BatchPlant1_Mixer_DischargeValve = 433;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit = 435;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = 436;

        /// <remarks />
        public const uint BatchPlant1_Conveyor = 444;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor = 445;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericSensorType = 1;

        /// <remarks />
        public const uint GenericActuatorType = 9;

        /// <remarks />
        public const uint GenericMotorType = 22;

        /// <remarks />
        public const uint LevelIndicatorType = 29;

        /// <remarks />
        public const uint LoadcellTransmitterType = 37;

        /// <remarks />
        public const uint ValveType = 51;

        /// <remarks />
        public const uint MixerMotorType = 64;

        /// <remarks />
        public const uint ConveyorMotorType = 71;

        /// <remarks />
        public const uint Silo1Type = 78;

        /// <remarks />
        public const uint Silo2Type = 100;

        /// <remarks />
        public const uint Silo3Type = 122;

        /// <remarks />
        public const uint MixerType = 144;

        /// <remarks />
        public const uint PackagingUnitType = 179;

        /// <remarks />
        public const uint ConveyorType = 188;

        /// <remarks />
        public const uint BatchPlantType = 196;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericSensorType_Output = 2;

        /// <remarks />
        public const uint GenericSensorType_Output_EURange = 6;

        /// <remarks />
        public const uint GenericSensorType_Units = 8;

        /// <remarks />
        public const uint GenericActuatorType_Input = 10;

        /// <remarks />
        public const uint GenericActuatorType_Input_EURange = 14;

        /// <remarks />
        public const uint GenericActuatorType_Output = 16;

        /// <remarks />
        public const uint GenericActuatorType_Output_EURange = 20;

        /// <remarks />
        public const uint GenericMotorType_Speed = 23;

        /// <remarks />
        public const uint GenericMotorType_Speed_EURange = 27;

        /// <remarks />
        public const uint LevelIndicatorType_Output_EURange = 34;

        /// <remarks />
        public const uint LoadcellTransmitterType_Output_EURange = 42;

        /// <remarks />
        public const uint LoadcellTransmitterType_ExcitationVoltage = 45;

        /// <remarks />
        public const uint LoadcellTransmitterType_ExcitationVoltage_EURange = 49;

        /// <remarks />
        public const uint ValveType_Input_EURange = 56;

        /// <remarks />
        public const uint ValveType_Output_EURange = 62;

        /// <remarks />
        public const uint MixerMotorType_Speed_EURange = 69;

        /// <remarks />
        public const uint ConveyorMotorType_Speed_EURange = 76;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Output = 80;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Output_EURange = 84;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Units = 86;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Input = 88;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Input_EURange = 92;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Output = 94;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Output_EURange = 98;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Output = 102;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Output_EURange = 106;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Units = 108;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Input = 110;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Input_EURange = 114;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Output = 116;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Output_EURange = 120;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Output = 124;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Output_EURange = 128;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Units = 130;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Input = 132;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Input_EURange = 136;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Output = 138;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Output_EURange = 142;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Output = 146;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Output_EURange = 150;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Units = 152;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage = 153;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = 157;

        /// <remarks />
        public const uint MixerType_MixerMotor_Speed = 160;

        /// <remarks />
        public const uint MixerType_MixerMotor_Speed_EURange = 164;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Input = 167;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Input_EURange = 171;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Output = 173;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Output_EURange = 177;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output = 181;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = 185;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Units = 187;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor_Speed = 190;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor_Speed_EURange = 194;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output = 199;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = 203;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Units = 205;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input = 207;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = 211;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output = 213;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = 217;

        /// <remarks />
        public const uint BatchPlantType_Silo1_DischargeValve_Input = 220;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output = 223;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = 227;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Units = 229;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input = 231;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = 235;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output = 237;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = 241;

        /// <remarks />
        public const uint BatchPlantType_Silo2_DischargeValve_Input = 244;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output = 247;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = 251;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Units = 253;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input = 255;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = 259;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output = 261;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = 265;

        /// <remarks />
        public const uint BatchPlantType_Silo3_DischargeValve_Input = 268;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output = 271;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = 275;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Units = 277;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = 278;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 282;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor_Speed = 285;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor_Speed_EURange = 289;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input = 292;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = 296;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output = 298;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = 302;

        /// <remarks />
        public const uint BatchPlantType_Mixer_DischargeValve_Input = 305;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = 308;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 312;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = 314;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed = 317;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = 321;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output = 328;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = 332;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Units = 334;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input = 336;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = 340;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output = 342;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = 346;

        /// <remarks />
        public const uint BatchPlant1_Silo1_DischargeValve_Input = 349;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output = 352;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = 356;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Units = 358;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input = 360;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = 364;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output = 366;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = 370;

        /// <remarks />
        public const uint BatchPlant1_Silo2_DischargeValve_Input = 373;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output = 376;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = 380;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Units = 382;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input = 384;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = 388;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output = 390;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = 394;

        /// <remarks />
        public const uint BatchPlant1_Silo3_DischargeValve_Input = 397;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output = 400;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = 404;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Units = 406;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = 407;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 411;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor_Speed = 414;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor_Speed_EURange = 418;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input = 421;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = 425;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output = 427;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = 431;

        /// <remarks />
        public const uint BatchPlant1_Mixer_DischargeValve_Input = 434;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = 437;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 441;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = 443;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed = 446;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = 450;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StopProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StopProcess, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.MixerType_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.PackagingUnitType_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.ConveyorType_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType = new ExpandedNodeId(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType = new ExpandedNodeId(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType = new ExpandedNodeId(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LevelIndicatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string BatchPlant1 = "Batch Plant #1";

        /// <remarks />
        public const string BatchPlantType = "BatchPlantType";

        /// <remarks />
        public const string Conveyor = "ConveyorX001";

        /// <remarks />
        public const string ConveyorMotor = "Motor02";

        /// <remarks />
        public const string ConveyorMotorType = "ConveyorMotorType";

        /// <remarks />
        public const string ConveyorType = "ConveyorType";

        /// <remarks />
        public const string ExcitationVoltage = "ExcitationVoltage";

        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";

        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <remarks />
        public const string LoadcellTransmitter = "LT001";

        /// <remarks />
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";

        /// <remarks />
        public const string Mixer = "MixerX001";

        /// <remarks />
        public const string MixerDischargeValve = "Valve004";

        /// <remarks />
        public const string MixerMotor = "Motor01";

        /// <remarks />
        public const string MixerMotorType = "MixerMotorType";

        /// <remarks />
        public const string MixerType = "MixerType";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string PackagingUnit = "PackagingUnitX001";

        /// <remarks />
        public const string PackagingUnitLevelIndicator = "LI004";

        /// <remarks />
        public const string PackagingUnitType = "PackagingUnitType";

        /// <remarks />
        public const string Silo1 = "SiloX001";

        /// <remarks />
        public const string Silo1DischargeValve = "Valve001";

        /// <remarks />
        public const string Silo1LevelIndicator = "LI001";

        /// <remarks />
        public const string Silo1Type = "Silo1Type";

        /// <remarks />
        public const string Silo2 = "SiloX002";

        /// <remarks />
        public const string Silo2DischargeValve = "Valve002";

        /// <remarks />
        public const string Silo2LevelIndicator = "LI002";

        /// <remarks />
        public const string Silo2Type = "Silo2Type";

        /// <remarks />
        public const string Silo3 = "SiloX003";

        /// <remarks />
        public const string Silo3DischargeValve = "Valve003";

        /// <remarks />
        public const string Silo3LevelIndicator = "LI003";

        /// <remarks />
        public const string Silo3Type = "Silo3Type";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string StopProcess = "StopProcess";

        /// <remarks />
        public const string Units = "Units";

        /// <remarks />
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the BatchPlant namespace (.NET code namespace is 'BatchPlant').
        /// </summary>
        public const string BatchPlant = "http://opcfoundation.org/BatchPlant";
    }
    #endregion
}