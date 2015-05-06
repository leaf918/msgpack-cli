﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Collections.Generic;

// ReSharper disable InconsistentNaming
// ReSharper disable RedundantNameQualifier

namespace MsgPack.Serialization
{
	partial class AotHelper
	{
		private static Dictionary<RuntimeTypeHandle, object> InitializeEqualityComparerTable()
		{
			var result = new Dictionary<RuntimeTypeHandle, object>( 181 );
			result.Add( typeof( System.StringSplitOptions ).TypeHandle, new System_StringSplitOptionsEqualityComparer() );
			result.Add( typeof( System.StringComparison ).TypeHandle, new System_StringComparisonEqualityComparer() );
			result.Add( typeof( System.DateTime ).TypeHandle, new System_DateTimeEqualityComparer() );
			result.Add( typeof( System.DateTimeKind ).TypeHandle, new System_DateTimeKindEqualityComparer() );
			result.Add( typeof( System.DateTimeOffset ).TypeHandle, new System_DateTimeOffsetEqualityComparer() );
			result.Add( typeof( System.AppDomainManagerInitializationOptions ).TypeHandle, new System_AppDomainManagerInitializationOptionsEqualityComparer() );
			result.Add( typeof( System.LoaderOptimization ).TypeHandle, new System_LoaderOptimizationEqualityComparer() );
			result.Add( typeof( System.AttributeTargets ).TypeHandle, new System_AttributeTargetsEqualityComparer() );
			result.Add( typeof( System.Boolean ).TypeHandle, new System_BooleanEqualityComparer() );
			result.Add( typeof( System.Byte ).TypeHandle, new System_ByteEqualityComparer() );
			result.Add( typeof( System.Char ).TypeHandle, new System_CharEqualityComparer() );
			result.Add( typeof( System.ConsoleColor ).TypeHandle, new System_ConsoleColorEqualityComparer() );
			result.Add( typeof( System.ConsoleKey ).TypeHandle, new System_ConsoleKeyEqualityComparer() );
			result.Add( typeof( System.ConsoleKeyInfo ).TypeHandle, new System_ConsoleKeyInfoEqualityComparer() );
			result.Add( typeof( System.ConsoleModifiers ).TypeHandle, new System_ConsoleModifiersEqualityComparer() );
			result.Add( typeof( System.ConsoleSpecialKey ).TypeHandle, new System_ConsoleSpecialKeyEqualityComparer() );
			result.Add( typeof( System.Base64FormattingOptions ).TypeHandle, new System_Base64FormattingOptionsEqualityComparer() );
			result.Add( typeof( System.DayOfWeek ).TypeHandle, new System_DayOfWeekEqualityComparer() );
			result.Add( typeof( System.Decimal ).TypeHandle, new System_DecimalEqualityComparer() );
			result.Add( typeof( System.Double ).TypeHandle, new System_DoubleEqualityComparer() );
			result.Add( typeof( System.EnvironmentVariableTarget ).TypeHandle, new System_EnvironmentVariableTargetEqualityComparer() );
			result.Add( typeof( System.GCCollectionMode ).TypeHandle, new System_GCCollectionModeEqualityComparer() );
			result.Add( typeof( System.GCNotificationStatus ).TypeHandle, new System_GCNotificationStatusEqualityComparer() );
			result.Add( typeof( System.Guid ).TypeHandle, new System_GuidEqualityComparer() );
			result.Add( typeof( System.Int16 ).TypeHandle, new System_Int16EqualityComparer() );
			result.Add( typeof( System.Int32 ).TypeHandle, new System_Int32EqualityComparer() );
			result.Add( typeof( System.Int64 ).TypeHandle, new System_Int64EqualityComparer() );
			result.Add( typeof( System.IntPtr ).TypeHandle, new System_IntPtrEqualityComparer() );
			result.Add( typeof( System.MidpointRounding ).TypeHandle, new System_MidpointRoundingEqualityComparer() );
			result.Add( typeof( System.PlatformID ).TypeHandle, new System_PlatformIDEqualityComparer() );
			result.Add( typeof( System.RuntimeTypeHandle ).TypeHandle, new System_RuntimeTypeHandleEqualityComparer() );
			result.Add( typeof( System.RuntimeMethodHandle ).TypeHandle, new System_RuntimeMethodHandleEqualityComparer() );
			result.Add( typeof( System.RuntimeFieldHandle ).TypeHandle, new System_RuntimeFieldHandleEqualityComparer() );
			result.Add( typeof( System.ModuleHandle ).TypeHandle, new System_ModuleHandleEqualityComparer() );
			result.Add( typeof( System.SByte ).TypeHandle, new System_SByteEqualityComparer() );
			result.Add( typeof( System.Single ).TypeHandle, new System_SingleEqualityComparer() );
			result.Add( typeof( System.TimeSpan ).TypeHandle, new System_TimeSpanEqualityComparer() );
			result.Add( typeof( System.TypeCode ).TypeHandle, new System_TypeCodeEqualityComparer() );
			result.Add( typeof( System.UInt16 ).TypeHandle, new System_UInt16EqualityComparer() );
			result.Add( typeof( System.UInt32 ).TypeHandle, new System_UInt32EqualityComparer() );
			result.Add( typeof( System.UInt64 ).TypeHandle, new System_UInt64EqualityComparer() );
			result.Add( typeof( System.UIntPtr ).TypeHandle, new System_UIntPtrEqualityComparer() );
			result.Add( typeof( System.Threading.EventResetMode ).TypeHandle, new System_Threading_EventResetModeEqualityComparer() );
			result.Add( typeof( System.Threading.AsyncFlowControl ).TypeHandle, new System_Threading_AsyncFlowControlEqualityComparer() );
			result.Add( typeof( System.Threading.LockCookie ).TypeHandle, new System_Threading_LockCookieEqualityComparer() );
			result.Add( typeof( System.Threading.NativeOverlapped ).TypeHandle, new System_Threading_NativeOverlappedEqualityComparer() );
			result.Add( typeof( System.Threading.ThreadPriority ).TypeHandle, new System_Threading_ThreadPriorityEqualityComparer() );
			result.Add( typeof( System.Threading.ThreadState ).TypeHandle, new System_Threading_ThreadStateEqualityComparer() );
			result.Add( typeof( System.Threading.ApartmentState ).TypeHandle, new System_Threading_ApartmentStateEqualityComparer() );
			result.Add( typeof( System.Collections.DictionaryEntry ).TypeHandle, new System_Collections_DictionaryEntryEqualityComparer() );
			result.Add( typeof( System.Diagnostics.DebuggerBrowsableState ).TypeHandle, new System_Diagnostics_DebuggerBrowsableStateEqualityComparer() );
			result.Add( typeof( System.Diagnostics.SymbolStore.SymAddressKind ).TypeHandle, new System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer() );
			result.Add( typeof( System.Diagnostics.SymbolStore.SymbolToken ).TypeHandle, new System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer() );
			result.Add( typeof( System.Reflection.AssemblyNameFlags ).TypeHandle, new System_Reflection_AssemblyNameFlagsEqualityComparer() );
			result.Add( typeof( System.Reflection.ProcessorArchitecture ).TypeHandle, new System_Reflection_ProcessorArchitectureEqualityComparer() );
			result.Add( typeof( System.Reflection.BindingFlags ).TypeHandle, new System_Reflection_BindingFlagsEqualityComparer() );
			result.Add( typeof( System.Reflection.CallingConventions ).TypeHandle, new System_Reflection_CallingConventionsEqualityComparer() );
			result.Add( typeof( System.Reflection.CustomAttributeNamedArgument ).TypeHandle, new System_Reflection_CustomAttributeNamedArgumentEqualityComparer() );
			result.Add( typeof( System.Reflection.CustomAttributeTypedArgument ).TypeHandle, new System_Reflection_CustomAttributeTypedArgumentEqualityComparer() );
			result.Add( typeof( System.Reflection.EventAttributes ).TypeHandle, new System_Reflection_EventAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.FieldAttributes ).TypeHandle, new System_Reflection_FieldAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.GenericParameterAttributes ).TypeHandle, new System_Reflection_GenericParameterAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.InterfaceMapping ).TypeHandle, new System_Reflection_InterfaceMappingEqualityComparer() );
			result.Add( typeof( System.Reflection.ResourceLocation ).TypeHandle, new System_Reflection_ResourceLocationEqualityComparer() );
			result.Add( typeof( System.Reflection.MemberTypes ).TypeHandle, new System_Reflection_MemberTypesEqualityComparer() );
			result.Add( typeof( System.Reflection.MethodAttributes ).TypeHandle, new System_Reflection_MethodAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.MethodImplAttributes ).TypeHandle, new System_Reflection_MethodImplAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.PortableExecutableKinds ).TypeHandle, new System_Reflection_PortableExecutableKindsEqualityComparer() );
			result.Add( typeof( System.Reflection.ImageFileMachine ).TypeHandle, new System_Reflection_ImageFileMachineEqualityComparer() );
			result.Add( typeof( System.Reflection.ExceptionHandlingClauseOptions ).TypeHandle, new System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer() );
			result.Add( typeof( System.Reflection.ParameterAttributes ).TypeHandle, new System_Reflection_ParameterAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.ParameterModifier ).TypeHandle, new System_Reflection_ParameterModifierEqualityComparer() );
			result.Add( typeof( System.Reflection.PropertyAttributes ).TypeHandle, new System_Reflection_PropertyAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.ResourceAttributes ).TypeHandle, new System_Reflection_ResourceAttributesEqualityComparer() );
			result.Add( typeof( System.Reflection.TypeAttributes ).TypeHandle, new System_Reflection_TypeAttributesEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.SerializationEntry ).TypeHandle, new System_Runtime_Serialization_SerializationEntryEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.StreamingContext ).TypeHandle, new System_Runtime_Serialization_StreamingContextEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.StreamingContextStates ).TypeHandle, new System_Runtime_Serialization_StreamingContextStatesEqualityComparer() );
			result.Add( typeof( System.Globalization.CalendarAlgorithmType ).TypeHandle, new System_Globalization_CalendarAlgorithmTypeEqualityComparer() );
			result.Add( typeof( System.Globalization.CalendarWeekRule ).TypeHandle, new System_Globalization_CalendarWeekRuleEqualityComparer() );
			result.Add( typeof( System.Globalization.CompareOptions ).TypeHandle, new System_Globalization_CompareOptionsEqualityComparer() );
			result.Add( typeof( System.Globalization.CultureTypes ).TypeHandle, new System_Globalization_CultureTypesEqualityComparer() );
			result.Add( typeof( System.Globalization.DateTimeStyles ).TypeHandle, new System_Globalization_DateTimeStylesEqualityComparer() );
			result.Add( typeof( System.Globalization.DigitShapes ).TypeHandle, new System_Globalization_DigitShapesEqualityComparer() );
			result.Add( typeof( System.Globalization.GregorianCalendarTypes ).TypeHandle, new System_Globalization_GregorianCalendarTypesEqualityComparer() );
			result.Add( typeof( System.Globalization.NumberStyles ).TypeHandle, new System_Globalization_NumberStylesEqualityComparer() );
			result.Add( typeof( System.Globalization.UnicodeCategory ).TypeHandle, new System_Globalization_UnicodeCategoryEqualityComparer() );
			result.Add( typeof( System.Text.NormalizationForm ).TypeHandle, new System_Text_NormalizationFormEqualityComparer() );
			result.Add( typeof( System.Resources.UltimateResourceFallbackLocation ).TypeHandle, new System_Resources_UltimateResourceFallbackLocationEqualityComparer() );
			result.Add( typeof( System.Security.Policy.ApplicationVersionMatch ).TypeHandle, new System_Security_Policy_ApplicationVersionMatchEqualityComparer() );
			result.Add( typeof( System.Security.Policy.TrustManagerUIContext ).TypeHandle, new System_Security_Policy_TrustManagerUIContextEqualityComparer() );
			result.Add( typeof( System.Security.Policy.PolicyStatementAttribute ).TypeHandle, new System_Security_Policy_PolicyStatementAttributeEqualityComparer() );
			result.Add( typeof( System.Security.Principal.PrincipalPolicy ).TypeHandle, new System_Security_Principal_PrincipalPolicyEqualityComparer() );
			result.Add( typeof( System.Security.Principal.TokenAccessLevels ).TypeHandle, new System_Security_Principal_TokenAccessLevelsEqualityComparer() );
			result.Add( typeof( System.Security.Principal.TokenImpersonationLevel ).TypeHandle, new System_Security_Principal_TokenImpersonationLevelEqualityComparer() );
			result.Add( typeof( System.Security.Principal.WindowsAccountType ).TypeHandle, new System_Security_Principal_WindowsAccountTypeEqualityComparer() );
			result.Add( typeof( System.Security.Principal.WindowsBuiltInRole ).TypeHandle, new System_Security_Principal_WindowsBuiltInRoleEqualityComparer() );
			result.Add( typeof( System.Runtime.ConstrainedExecution.Consistency ).TypeHandle, new System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer() );
			result.Add( typeof( System.Runtime.ConstrainedExecution.Cer ).TypeHandle, new System_Runtime_ConstrainedExecution_CerEqualityComparer() );
			result.Add( typeof( System.IO.SearchOption ).TypeHandle, new System_IO_SearchOptionEqualityComparer() );
			result.Add( typeof( System.IO.DriveType ).TypeHandle, new System_IO_DriveTypeEqualityComparer() );
			result.Add( typeof( System.IO.FileAccess ).TypeHandle, new System_IO_FileAccessEqualityComparer() );
			result.Add( typeof( System.IO.FileMode ).TypeHandle, new System_IO_FileModeEqualityComparer() );
			result.Add( typeof( System.IO.FileOptions ).TypeHandle, new System_IO_FileOptionsEqualityComparer() );
			result.Add( typeof( System.IO.FileShare ).TypeHandle, new System_IO_FileShareEqualityComparer() );
			result.Add( typeof( System.IO.FileAttributes ).TypeHandle, new System_IO_FileAttributesEqualityComparer() );
			result.Add( typeof( System.IO.SeekOrigin ).TypeHandle, new System_IO_SeekOriginEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.WellKnownObjectMode ).TypeHandle, new System_Runtime_Remoting_WellKnownObjectModeEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.Activation.ActivatorLevel ).TypeHandle, new System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.Channels.ServerProcessing ).TypeHandle, new System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.Lifetime.LeaseState ).TypeHandle, new System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.Metadata.SoapOption ).TypeHandle, new System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.Metadata.XmlFieldOrderOption ).TypeHandle, new System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer() );
			result.Add( typeof( System.Runtime.Remoting.CustomErrorsModes ).TypeHandle, new System_Runtime_Remoting_CustomErrorsModesEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.Formatters.FormatterTypeStyle ).TypeHandle, new System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.Formatters.FormatterAssemblyStyle ).TypeHandle, new System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer() );
			result.Add( typeof( System.Runtime.Serialization.Formatters.TypeFilterLevel ).TypeHandle, new System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CipherMode ).TypeHandle, new System_Security_Cryptography_CipherModeEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.PaddingMode ).TypeHandle, new System_Security_Cryptography_PaddingModeEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.FromBase64TransformMode ).TypeHandle, new System_Security_Cryptography_FromBase64TransformModeEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CspProviderFlags ).TypeHandle, new System_Security_Cryptography_CspProviderFlagsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CryptoStreamMode ).TypeHandle, new System_Security_Cryptography_CryptoStreamModeEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.DSAParameters ).TypeHandle, new System_Security_Cryptography_DSAParametersEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.KeyNumber ).TypeHandle, new System_Security_Cryptography_KeyNumberEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.RSAParameters ).TypeHandle, new System_Security_Cryptography_RSAParametersEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.X509Certificates.X509ContentType ).TypeHandle, new System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.X509Certificates.X509KeyStorageFlags ).TypeHandle, new System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.InheritanceFlags ).TypeHandle, new System_Security_AccessControl_InheritanceFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.PropagationFlags ).TypeHandle, new System_Security_AccessControl_PropagationFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AuditFlags ).TypeHandle, new System_Security_AccessControl_AuditFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.SecurityInfos ).TypeHandle, new System_Security_AccessControl_SecurityInfosEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.ResourceType ).TypeHandle, new System_Security_AccessControl_ResourceTypeEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AccessControlSections ).TypeHandle, new System_Security_AccessControl_AccessControlSectionsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AccessControlActions ).TypeHandle, new System_Security_AccessControl_AccessControlActionsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AceType ).TypeHandle, new System_Security_AccessControl_AceTypeEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AceFlags ).TypeHandle, new System_Security_AccessControl_AceFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.CompoundAceType ).TypeHandle, new System_Security_AccessControl_CompoundAceTypeEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AceQualifier ).TypeHandle, new System_Security_AccessControl_AceQualifierEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.ObjectAceFlags ).TypeHandle, new System_Security_AccessControl_ObjectAceFlagsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.CryptoKeyRights ).TypeHandle, new System_Security_AccessControl_CryptoKeyRightsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.EventWaitHandleRights ).TypeHandle, new System_Security_AccessControl_EventWaitHandleRightsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.FileSystemRights ).TypeHandle, new System_Security_AccessControl_FileSystemRightsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.MutexRights ).TypeHandle, new System_Security_AccessControl_MutexRightsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AccessControlModification ).TypeHandle, new System_Security_AccessControl_AccessControlModificationEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.RegistryRights ).TypeHandle, new System_Security_AccessControl_RegistryRightsEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.AccessControlType ).TypeHandle, new System_Security_AccessControl_AccessControlTypeEqualityComparer() );
			result.Add( typeof( System.Security.AccessControl.ControlFlags ).TypeHandle, new System_Security_AccessControl_ControlFlagsEqualityComparer() );
			result.Add( typeof( System.Security.Principal.WellKnownSidType ).TypeHandle, new System_Security_Principal_WellKnownSidTypeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.EventDescriptor ).TypeHandle, new System_Diagnostics_Eventing_EventDescriptorEqualityComparer() );
			result.Add( typeof( System.Management.Instrumentation.ManagementHostingModel ).TypeHandle, new System_Management_Instrumentation_ManagementHostingModelEqualityComparer() );
			result.Add( typeof( System.Management.Instrumentation.ManagementConfigurationType ).TypeHandle, new System_Management_Instrumentation_ManagementConfigurationTypeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.EventLogType ).TypeHandle, new System_Diagnostics_Eventing_Reader_EventLogTypeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.EventLogIsolation ).TypeHandle, new System_Diagnostics_Eventing_Reader_EventLogIsolationEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.EventLogMode ).TypeHandle, new System_Diagnostics_Eventing_Reader_EventLogModeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.SessionAuthentication ).TypeHandle, new System_Diagnostics_Eventing_Reader_SessionAuthenticationEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.PathType ).TypeHandle, new System_Diagnostics_Eventing_Reader_PathTypeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.StandardEventLevel ).TypeHandle, new System_Diagnostics_Eventing_Reader_StandardEventLevelEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.StandardEventTask ).TypeHandle, new System_Diagnostics_Eventing_Reader_StandardEventTaskEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.StandardEventOpcode ).TypeHandle, new System_Diagnostics_Eventing_Reader_StandardEventOpcodeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.Eventing.Reader.StandardEventKeywords ).TypeHandle, new System_Diagnostics_Eventing_Reader_StandardEventKeywordsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngKeyHandleOpenOptions ).TypeHandle, new System_Security_Cryptography_CngKeyHandleOpenOptionsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngProperty ).TypeHandle, new System_Security_Cryptography_CngPropertyEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction ).TypeHandle, new System_Security_Cryptography_ECDiffieHellmanKeyDerivationFunctionEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.ECKeyXmlFormat ).TypeHandle, new System_Security_Cryptography_ECKeyXmlFormatEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngExportPolicies ).TypeHandle, new System_Security_Cryptography_CngExportPoliciesEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngKeyCreationOptions ).TypeHandle, new System_Security_Cryptography_CngKeyCreationOptionsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngKeyOpenOptions ).TypeHandle, new System_Security_Cryptography_CngKeyOpenOptionsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngKeyUsages ).TypeHandle, new System_Security_Cryptography_CngKeyUsagesEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngPropertyOptions ).TypeHandle, new System_Security_Cryptography_CngPropertyOptionsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.CngUIProtectionLevels ).TypeHandle, new System_Security_Cryptography_CngUIProtectionLevelsEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.SignatureVerificationResult ).TypeHandle, new System_Security_Cryptography_SignatureVerificationResultEqualityComparer() );
			result.Add( typeof( System.Security.Cryptography.X509Certificates.TrustStatus ).TypeHandle, new System_Security_Cryptography_X509Certificates_TrustStatusEqualityComparer() );
			result.Add( typeof( System.Diagnostics.TraceLogRetentionOption ).TypeHandle, new System_Diagnostics_TraceLogRetentionOptionEqualityComparer() );
			result.Add( typeof( System.Diagnostics.PerformanceData.CounterSetInstanceType ).TypeHandle, new System_Diagnostics_PerformanceData_CounterSetInstanceTypeEqualityComparer() );
			result.Add( typeof( System.Diagnostics.PerformanceData.CounterType ).TypeHandle, new System_Diagnostics_PerformanceData_CounterTypeEqualityComparer() );
			result.Add( typeof( System.IO.HandleInheritability ).TypeHandle, new System_IO_HandleInheritabilityEqualityComparer() );
			result.Add( typeof( System.IO.Pipes.PipeDirection ).TypeHandle, new System_IO_Pipes_PipeDirectionEqualityComparer() );
			result.Add( typeof( System.IO.Pipes.PipeTransmissionMode ).TypeHandle, new System_IO_Pipes_PipeTransmissionModeEqualityComparer() );
			result.Add( typeof( System.IO.Pipes.PipeOptions ).TypeHandle, new System_IO_Pipes_PipeOptionsEqualityComparer() );
			result.Add( typeof( System.IO.Pipes.PipeAccessRights ).TypeHandle, new System_IO_Pipes_PipeAccessRightsEqualityComparer() );
			result.Add( typeof( System.Threading.LockRecursionPolicy ).TypeHandle, new System_Threading_LockRecursionPolicyEqualityComparer() );
			return result;
		}


		private sealed class System_StringSplitOptionsEqualityComparer : IEqualityComparer<System.StringSplitOptions>
		{
			public System_StringSplitOptionsEqualityComparer() {}

			public bool Equals( System.StringSplitOptions left, System.StringSplitOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.StringSplitOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_StringComparisonEqualityComparer : IEqualityComparer<System.StringComparison>
		{
			public System_StringComparisonEqualityComparer() {}

			public bool Equals( System.StringComparison left, System.StringComparison right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.StringComparison obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DateTimeEqualityComparer : IEqualityComparer<System.DateTime>
		{
			public System_DateTimeEqualityComparer() {}

			public bool Equals( System.DateTime left, System.DateTime right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.DateTime obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DateTimeKindEqualityComparer : IEqualityComparer<System.DateTimeKind>
		{
			public System_DateTimeKindEqualityComparer() {}

			public bool Equals( System.DateTimeKind left, System.DateTimeKind right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.DateTimeKind obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DateTimeOffsetEqualityComparer : IEqualityComparer<System.DateTimeOffset>
		{
			public System_DateTimeOffsetEqualityComparer() {}

			public bool Equals( System.DateTimeOffset left, System.DateTimeOffset right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.DateTimeOffset obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer : IEqualityComparer<System.AppDomainManagerInitializationOptions>
		{
			public System_AppDomainManagerInitializationOptionsEqualityComparer() {}

			public bool Equals( System.AppDomainManagerInitializationOptions left, System.AppDomainManagerInitializationOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.AppDomainManagerInitializationOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_LoaderOptimizationEqualityComparer : IEqualityComparer<System.LoaderOptimization>
		{
			public System_LoaderOptimizationEqualityComparer() {}

			public bool Equals( System.LoaderOptimization left, System.LoaderOptimization right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.LoaderOptimization obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_AttributeTargetsEqualityComparer : IEqualityComparer<System.AttributeTargets>
		{
			public System_AttributeTargetsEqualityComparer() {}

			public bool Equals( System.AttributeTargets left, System.AttributeTargets right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.AttributeTargets obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_BooleanEqualityComparer : IEqualityComparer<System.Boolean>
		{
			public System_BooleanEqualityComparer() {}

			public bool Equals( System.Boolean left, System.Boolean right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Boolean obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ByteEqualityComparer : IEqualityComparer<System.Byte>
		{
			public System_ByteEqualityComparer() {}

			public bool Equals( System.Byte left, System.Byte right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Byte obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_CharEqualityComparer : IEqualityComparer<System.Char>
		{
			public System_CharEqualityComparer() {}

			public bool Equals( System.Char left, System.Char right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Char obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ConsoleColorEqualityComparer : IEqualityComparer<System.ConsoleColor>
		{
			public System_ConsoleColorEqualityComparer() {}

			public bool Equals( System.ConsoleColor left, System.ConsoleColor right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ConsoleColor obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ConsoleKeyEqualityComparer : IEqualityComparer<System.ConsoleKey>
		{
			public System_ConsoleKeyEqualityComparer() {}

			public bool Equals( System.ConsoleKey left, System.ConsoleKey right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ConsoleKey obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ConsoleKeyInfoEqualityComparer : IEqualityComparer<System.ConsoleKeyInfo>
		{
			public System_ConsoleKeyInfoEqualityComparer() {}

			public bool Equals( System.ConsoleKeyInfo left, System.ConsoleKeyInfo right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ConsoleKeyInfo obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ConsoleModifiersEqualityComparer : IEqualityComparer<System.ConsoleModifiers>
		{
			public System_ConsoleModifiersEqualityComparer() {}

			public bool Equals( System.ConsoleModifiers left, System.ConsoleModifiers right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ConsoleModifiers obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ConsoleSpecialKeyEqualityComparer : IEqualityComparer<System.ConsoleSpecialKey>
		{
			public System_ConsoleSpecialKeyEqualityComparer() {}

			public bool Equals( System.ConsoleSpecialKey left, System.ConsoleSpecialKey right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ConsoleSpecialKey obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Base64FormattingOptionsEqualityComparer : IEqualityComparer<System.Base64FormattingOptions>
		{
			public System_Base64FormattingOptionsEqualityComparer() {}

			public bool Equals( System.Base64FormattingOptions left, System.Base64FormattingOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Base64FormattingOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DayOfWeekEqualityComparer : IEqualityComparer<System.DayOfWeek>
		{
			public System_DayOfWeekEqualityComparer() {}

			public bool Equals( System.DayOfWeek left, System.DayOfWeek right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.DayOfWeek obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DecimalEqualityComparer : IEqualityComparer<System.Decimal>
		{
			public System_DecimalEqualityComparer() {}

			public bool Equals( System.Decimal left, System.Decimal right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Decimal obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_DoubleEqualityComparer : IEqualityComparer<System.Double>
		{
			public System_DoubleEqualityComparer() {}

			public bool Equals( System.Double left, System.Double right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Double obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_EnvironmentVariableTargetEqualityComparer : IEqualityComparer<System.EnvironmentVariableTarget>
		{
			public System_EnvironmentVariableTargetEqualityComparer() {}

			public bool Equals( System.EnvironmentVariableTarget left, System.EnvironmentVariableTarget right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.EnvironmentVariableTarget obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_GCCollectionModeEqualityComparer : IEqualityComparer<System.GCCollectionMode>
		{
			public System_GCCollectionModeEqualityComparer() {}

			public bool Equals( System.GCCollectionMode left, System.GCCollectionMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.GCCollectionMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_GCNotificationStatusEqualityComparer : IEqualityComparer<System.GCNotificationStatus>
		{
			public System_GCNotificationStatusEqualityComparer() {}

			public bool Equals( System.GCNotificationStatus left, System.GCNotificationStatus right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.GCNotificationStatus obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_GuidEqualityComparer : IEqualityComparer<System.Guid>
		{
			public System_GuidEqualityComparer() {}

			public bool Equals( System.Guid left, System.Guid right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Guid obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Int16EqualityComparer : IEqualityComparer<System.Int16>
		{
			public System_Int16EqualityComparer() {}

			public bool Equals( System.Int16 left, System.Int16 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Int16 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Int32EqualityComparer : IEqualityComparer<System.Int32>
		{
			public System_Int32EqualityComparer() {}

			public bool Equals( System.Int32 left, System.Int32 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Int32 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Int64EqualityComparer : IEqualityComparer<System.Int64>
		{
			public System_Int64EqualityComparer() {}

			public bool Equals( System.Int64 left, System.Int64 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Int64 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IntPtrEqualityComparer : IEqualityComparer<System.IntPtr>
		{
			public System_IntPtrEqualityComparer() {}

			public bool Equals( System.IntPtr left, System.IntPtr right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IntPtr obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_MidpointRoundingEqualityComparer : IEqualityComparer<System.MidpointRounding>
		{
			public System_MidpointRoundingEqualityComparer() {}

			public bool Equals( System.MidpointRounding left, System.MidpointRounding right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.MidpointRounding obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_PlatformIDEqualityComparer : IEqualityComparer<System.PlatformID>
		{
			public System_PlatformIDEqualityComparer() {}

			public bool Equals( System.PlatformID left, System.PlatformID right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.PlatformID obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_RuntimeTypeHandleEqualityComparer : IEqualityComparer<System.RuntimeTypeHandle>
		{
			public System_RuntimeTypeHandleEqualityComparer() {}

			public bool Equals( System.RuntimeTypeHandle left, System.RuntimeTypeHandle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.RuntimeTypeHandle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_RuntimeMethodHandleEqualityComparer : IEqualityComparer<System.RuntimeMethodHandle>
		{
			public System_RuntimeMethodHandleEqualityComparer() {}

			public bool Equals( System.RuntimeMethodHandle left, System.RuntimeMethodHandle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.RuntimeMethodHandle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_RuntimeFieldHandleEqualityComparer : IEqualityComparer<System.RuntimeFieldHandle>
		{
			public System_RuntimeFieldHandleEqualityComparer() {}

			public bool Equals( System.RuntimeFieldHandle left, System.RuntimeFieldHandle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.RuntimeFieldHandle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_ModuleHandleEqualityComparer : IEqualityComparer<System.ModuleHandle>
		{
			public System_ModuleHandleEqualityComparer() {}

			public bool Equals( System.ModuleHandle left, System.ModuleHandle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.ModuleHandle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_SByteEqualityComparer : IEqualityComparer<System.SByte>
		{
			public System_SByteEqualityComparer() {}

			public bool Equals( System.SByte left, System.SByte right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.SByte obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_SingleEqualityComparer : IEqualityComparer<System.Single>
		{
			public System_SingleEqualityComparer() {}

			public bool Equals( System.Single left, System.Single right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Single obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_TimeSpanEqualityComparer : IEqualityComparer<System.TimeSpan>
		{
			public System_TimeSpanEqualityComparer() {}

			public bool Equals( System.TimeSpan left, System.TimeSpan right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.TimeSpan obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_TypeCodeEqualityComparer : IEqualityComparer<System.TypeCode>
		{
			public System_TypeCodeEqualityComparer() {}

			public bool Equals( System.TypeCode left, System.TypeCode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.TypeCode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_UInt16EqualityComparer : IEqualityComparer<System.UInt16>
		{
			public System_UInt16EqualityComparer() {}

			public bool Equals( System.UInt16 left, System.UInt16 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.UInt16 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_UInt32EqualityComparer : IEqualityComparer<System.UInt32>
		{
			public System_UInt32EqualityComparer() {}

			public bool Equals( System.UInt32 left, System.UInt32 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.UInt32 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_UInt64EqualityComparer : IEqualityComparer<System.UInt64>
		{
			public System_UInt64EqualityComparer() {}

			public bool Equals( System.UInt64 left, System.UInt64 right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.UInt64 obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_UIntPtrEqualityComparer : IEqualityComparer<System.UIntPtr>
		{
			public System_UIntPtrEqualityComparer() {}

			public bool Equals( System.UIntPtr left, System.UIntPtr right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.UIntPtr obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_EventResetModeEqualityComparer : IEqualityComparer<System.Threading.EventResetMode>
		{
			public System_Threading_EventResetModeEqualityComparer() {}

			public bool Equals( System.Threading.EventResetMode left, System.Threading.EventResetMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.EventResetMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_AsyncFlowControlEqualityComparer : IEqualityComparer<System.Threading.AsyncFlowControl>
		{
			public System_Threading_AsyncFlowControlEqualityComparer() {}

			public bool Equals( System.Threading.AsyncFlowControl left, System.Threading.AsyncFlowControl right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.AsyncFlowControl obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_LockCookieEqualityComparer : IEqualityComparer<System.Threading.LockCookie>
		{
			public System_Threading_LockCookieEqualityComparer() {}

			public bool Equals( System.Threading.LockCookie left, System.Threading.LockCookie right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.LockCookie obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_NativeOverlappedEqualityComparer : IEqualityComparer<System.Threading.NativeOverlapped>
		{
			public System_Threading_NativeOverlappedEqualityComparer() {}

			public bool Equals( System.Threading.NativeOverlapped left, System.Threading.NativeOverlapped right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.NativeOverlapped obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_ThreadPriorityEqualityComparer : IEqualityComparer<System.Threading.ThreadPriority>
		{
			public System_Threading_ThreadPriorityEqualityComparer() {}

			public bool Equals( System.Threading.ThreadPriority left, System.Threading.ThreadPriority right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.ThreadPriority obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_ThreadStateEqualityComparer : IEqualityComparer<System.Threading.ThreadState>
		{
			public System_Threading_ThreadStateEqualityComparer() {}

			public bool Equals( System.Threading.ThreadState left, System.Threading.ThreadState right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.ThreadState obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_ApartmentStateEqualityComparer : IEqualityComparer<System.Threading.ApartmentState>
		{
			public System_Threading_ApartmentStateEqualityComparer() {}

			public bool Equals( System.Threading.ApartmentState left, System.Threading.ApartmentState right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.ApartmentState obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Collections_DictionaryEntryEqualityComparer : IEqualityComparer<System.Collections.DictionaryEntry>
		{
			public System_Collections_DictionaryEntryEqualityComparer() {}

			public bool Equals( System.Collections.DictionaryEntry left, System.Collections.DictionaryEntry right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Collections.DictionaryEntry obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer : IEqualityComparer<System.Diagnostics.DebuggerBrowsableState>
		{
			public System_Diagnostics_DebuggerBrowsableStateEqualityComparer() {}

			public bool Equals( System.Diagnostics.DebuggerBrowsableState left, System.Diagnostics.DebuggerBrowsableState right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.DebuggerBrowsableState obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer : IEqualityComparer<System.Diagnostics.SymbolStore.SymAddressKind>
		{
			public System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer() {}

			public bool Equals( System.Diagnostics.SymbolStore.SymAddressKind left, System.Diagnostics.SymbolStore.SymAddressKind right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.SymbolStore.SymAddressKind obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer : IEqualityComparer<System.Diagnostics.SymbolStore.SymbolToken>
		{
			public System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer() {}

			public bool Equals( System.Diagnostics.SymbolStore.SymbolToken left, System.Diagnostics.SymbolStore.SymbolToken right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.SymbolStore.SymbolToken obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer : IEqualityComparer<System.Reflection.AssemblyNameFlags>
		{
			public System_Reflection_AssemblyNameFlagsEqualityComparer() {}

			public bool Equals( System.Reflection.AssemblyNameFlags left, System.Reflection.AssemblyNameFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.AssemblyNameFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ProcessorArchitectureEqualityComparer : IEqualityComparer<System.Reflection.ProcessorArchitecture>
		{
			public System_Reflection_ProcessorArchitectureEqualityComparer() {}

			public bool Equals( System.Reflection.ProcessorArchitecture left, System.Reflection.ProcessorArchitecture right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ProcessorArchitecture obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_BindingFlagsEqualityComparer : IEqualityComparer<System.Reflection.BindingFlags>
		{
			public System_Reflection_BindingFlagsEqualityComparer() {}

			public bool Equals( System.Reflection.BindingFlags left, System.Reflection.BindingFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.BindingFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_CallingConventionsEqualityComparer : IEqualityComparer<System.Reflection.CallingConventions>
		{
			public System_Reflection_CallingConventionsEqualityComparer() {}

			public bool Equals( System.Reflection.CallingConventions left, System.Reflection.CallingConventions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.CallingConventions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer : IEqualityComparer<System.Reflection.CustomAttributeNamedArgument>
		{
			public System_Reflection_CustomAttributeNamedArgumentEqualityComparer() {}

			public bool Equals( System.Reflection.CustomAttributeNamedArgument left, System.Reflection.CustomAttributeNamedArgument right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.CustomAttributeNamedArgument obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer : IEqualityComparer<System.Reflection.CustomAttributeTypedArgument>
		{
			public System_Reflection_CustomAttributeTypedArgumentEqualityComparer() {}

			public bool Equals( System.Reflection.CustomAttributeTypedArgument left, System.Reflection.CustomAttributeTypedArgument right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.CustomAttributeTypedArgument obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_EventAttributesEqualityComparer : IEqualityComparer<System.Reflection.EventAttributes>
		{
			public System_Reflection_EventAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.EventAttributes left, System.Reflection.EventAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.EventAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_FieldAttributesEqualityComparer : IEqualityComparer<System.Reflection.FieldAttributes>
		{
			public System_Reflection_FieldAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.FieldAttributes left, System.Reflection.FieldAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.FieldAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_GenericParameterAttributesEqualityComparer : IEqualityComparer<System.Reflection.GenericParameterAttributes>
		{
			public System_Reflection_GenericParameterAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.GenericParameterAttributes left, System.Reflection.GenericParameterAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.GenericParameterAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_InterfaceMappingEqualityComparer : IEqualityComparer<System.Reflection.InterfaceMapping>
		{
			public System_Reflection_InterfaceMappingEqualityComparer() {}

			public bool Equals( System.Reflection.InterfaceMapping left, System.Reflection.InterfaceMapping right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.InterfaceMapping obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ResourceLocationEqualityComparer : IEqualityComparer<System.Reflection.ResourceLocation>
		{
			public System_Reflection_ResourceLocationEqualityComparer() {}

			public bool Equals( System.Reflection.ResourceLocation left, System.Reflection.ResourceLocation right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ResourceLocation obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_MemberTypesEqualityComparer : IEqualityComparer<System.Reflection.MemberTypes>
		{
			public System_Reflection_MemberTypesEqualityComparer() {}

			public bool Equals( System.Reflection.MemberTypes left, System.Reflection.MemberTypes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.MemberTypes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_MethodAttributesEqualityComparer : IEqualityComparer<System.Reflection.MethodAttributes>
		{
			public System_Reflection_MethodAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.MethodAttributes left, System.Reflection.MethodAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.MethodAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_MethodImplAttributesEqualityComparer : IEqualityComparer<System.Reflection.MethodImplAttributes>
		{
			public System_Reflection_MethodImplAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.MethodImplAttributes left, System.Reflection.MethodImplAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.MethodImplAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_PortableExecutableKindsEqualityComparer : IEqualityComparer<System.Reflection.PortableExecutableKinds>
		{
			public System_Reflection_PortableExecutableKindsEqualityComparer() {}

			public bool Equals( System.Reflection.PortableExecutableKinds left, System.Reflection.PortableExecutableKinds right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.PortableExecutableKinds obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ImageFileMachineEqualityComparer : IEqualityComparer<System.Reflection.ImageFileMachine>
		{
			public System_Reflection_ImageFileMachineEqualityComparer() {}

			public bool Equals( System.Reflection.ImageFileMachine left, System.Reflection.ImageFileMachine right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ImageFileMachine obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer : IEqualityComparer<System.Reflection.ExceptionHandlingClauseOptions>
		{
			public System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer() {}

			public bool Equals( System.Reflection.ExceptionHandlingClauseOptions left, System.Reflection.ExceptionHandlingClauseOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ExceptionHandlingClauseOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ParameterAttributesEqualityComparer : IEqualityComparer<System.Reflection.ParameterAttributes>
		{
			public System_Reflection_ParameterAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.ParameterAttributes left, System.Reflection.ParameterAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ParameterAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ParameterModifierEqualityComparer : IEqualityComparer<System.Reflection.ParameterModifier>
		{
			public System_Reflection_ParameterModifierEqualityComparer() {}

			public bool Equals( System.Reflection.ParameterModifier left, System.Reflection.ParameterModifier right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ParameterModifier obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_PropertyAttributesEqualityComparer : IEqualityComparer<System.Reflection.PropertyAttributes>
		{
			public System_Reflection_PropertyAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.PropertyAttributes left, System.Reflection.PropertyAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.PropertyAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_ResourceAttributesEqualityComparer : IEqualityComparer<System.Reflection.ResourceAttributes>
		{
			public System_Reflection_ResourceAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.ResourceAttributes left, System.Reflection.ResourceAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.ResourceAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Reflection_TypeAttributesEqualityComparer : IEqualityComparer<System.Reflection.TypeAttributes>
		{
			public System_Reflection_TypeAttributesEqualityComparer() {}

			public bool Equals( System.Reflection.TypeAttributes left, System.Reflection.TypeAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Reflection.TypeAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer : IEqualityComparer<System.Runtime.Serialization.SerializationEntry>
		{
			public System_Runtime_Serialization_SerializationEntryEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.SerializationEntry left, System.Runtime.Serialization.SerializationEntry right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.SerializationEntry obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer : IEqualityComparer<System.Runtime.Serialization.StreamingContext>
		{
			public System_Runtime_Serialization_StreamingContextEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.StreamingContext left, System.Runtime.Serialization.StreamingContext right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.StreamingContext obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer : IEqualityComparer<System.Runtime.Serialization.StreamingContextStates>
		{
			public System_Runtime_Serialization_StreamingContextStatesEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.StreamingContextStates left, System.Runtime.Serialization.StreamingContextStates right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.StreamingContextStates obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer : IEqualityComparer<System.Globalization.CalendarAlgorithmType>
		{
			public System_Globalization_CalendarAlgorithmTypeEqualityComparer() {}

			public bool Equals( System.Globalization.CalendarAlgorithmType left, System.Globalization.CalendarAlgorithmType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.CalendarAlgorithmType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_CalendarWeekRuleEqualityComparer : IEqualityComparer<System.Globalization.CalendarWeekRule>
		{
			public System_Globalization_CalendarWeekRuleEqualityComparer() {}

			public bool Equals( System.Globalization.CalendarWeekRule left, System.Globalization.CalendarWeekRule right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.CalendarWeekRule obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_CompareOptionsEqualityComparer : IEqualityComparer<System.Globalization.CompareOptions>
		{
			public System_Globalization_CompareOptionsEqualityComparer() {}

			public bool Equals( System.Globalization.CompareOptions left, System.Globalization.CompareOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.CompareOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_CultureTypesEqualityComparer : IEqualityComparer<System.Globalization.CultureTypes>
		{
			public System_Globalization_CultureTypesEqualityComparer() {}

			public bool Equals( System.Globalization.CultureTypes left, System.Globalization.CultureTypes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.CultureTypes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_DateTimeStylesEqualityComparer : IEqualityComparer<System.Globalization.DateTimeStyles>
		{
			public System_Globalization_DateTimeStylesEqualityComparer() {}

			public bool Equals( System.Globalization.DateTimeStyles left, System.Globalization.DateTimeStyles right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.DateTimeStyles obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_DigitShapesEqualityComparer : IEqualityComparer<System.Globalization.DigitShapes>
		{
			public System_Globalization_DigitShapesEqualityComparer() {}

			public bool Equals( System.Globalization.DigitShapes left, System.Globalization.DigitShapes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.DigitShapes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer : IEqualityComparer<System.Globalization.GregorianCalendarTypes>
		{
			public System_Globalization_GregorianCalendarTypesEqualityComparer() {}

			public bool Equals( System.Globalization.GregorianCalendarTypes left, System.Globalization.GregorianCalendarTypes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.GregorianCalendarTypes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_NumberStylesEqualityComparer : IEqualityComparer<System.Globalization.NumberStyles>
		{
			public System_Globalization_NumberStylesEqualityComparer() {}

			public bool Equals( System.Globalization.NumberStyles left, System.Globalization.NumberStyles right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.NumberStyles obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Globalization_UnicodeCategoryEqualityComparer : IEqualityComparer<System.Globalization.UnicodeCategory>
		{
			public System_Globalization_UnicodeCategoryEqualityComparer() {}

			public bool Equals( System.Globalization.UnicodeCategory left, System.Globalization.UnicodeCategory right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Globalization.UnicodeCategory obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Text_NormalizationFormEqualityComparer : IEqualityComparer<System.Text.NormalizationForm>
		{
			public System_Text_NormalizationFormEqualityComparer() {}

			public bool Equals( System.Text.NormalizationForm left, System.Text.NormalizationForm right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Text.NormalizationForm obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer : IEqualityComparer<System.Resources.UltimateResourceFallbackLocation>
		{
			public System_Resources_UltimateResourceFallbackLocationEqualityComparer() {}

			public bool Equals( System.Resources.UltimateResourceFallbackLocation left, System.Resources.UltimateResourceFallbackLocation right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Resources.UltimateResourceFallbackLocation obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer : IEqualityComparer<System.Security.Policy.ApplicationVersionMatch>
		{
			public System_Security_Policy_ApplicationVersionMatchEqualityComparer() {}

			public bool Equals( System.Security.Policy.ApplicationVersionMatch left, System.Security.Policy.ApplicationVersionMatch right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Policy.ApplicationVersionMatch obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer : IEqualityComparer<System.Security.Policy.TrustManagerUIContext>
		{
			public System_Security_Policy_TrustManagerUIContextEqualityComparer() {}

			public bool Equals( System.Security.Policy.TrustManagerUIContext left, System.Security.Policy.TrustManagerUIContext right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Policy.TrustManagerUIContext obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer : IEqualityComparer<System.Security.Policy.PolicyStatementAttribute>
		{
			public System_Security_Policy_PolicyStatementAttributeEqualityComparer() {}

			public bool Equals( System.Security.Policy.PolicyStatementAttribute left, System.Security.Policy.PolicyStatementAttribute right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Policy.PolicyStatementAttribute obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer : IEqualityComparer<System.Security.Principal.PrincipalPolicy>
		{
			public System_Security_Principal_PrincipalPolicyEqualityComparer() {}

			public bool Equals( System.Security.Principal.PrincipalPolicy left, System.Security.Principal.PrincipalPolicy right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.PrincipalPolicy obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer : IEqualityComparer<System.Security.Principal.TokenAccessLevels>
		{
			public System_Security_Principal_TokenAccessLevelsEqualityComparer() {}

			public bool Equals( System.Security.Principal.TokenAccessLevels left, System.Security.Principal.TokenAccessLevels right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.TokenAccessLevels obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer : IEqualityComparer<System.Security.Principal.TokenImpersonationLevel>
		{
			public System_Security_Principal_TokenImpersonationLevelEqualityComparer() {}

			public bool Equals( System.Security.Principal.TokenImpersonationLevel left, System.Security.Principal.TokenImpersonationLevel right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.TokenImpersonationLevel obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer : IEqualityComparer<System.Security.Principal.WindowsAccountType>
		{
			public System_Security_Principal_WindowsAccountTypeEqualityComparer() {}

			public bool Equals( System.Security.Principal.WindowsAccountType left, System.Security.Principal.WindowsAccountType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.WindowsAccountType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer : IEqualityComparer<System.Security.Principal.WindowsBuiltInRole>
		{
			public System_Security_Principal_WindowsBuiltInRoleEqualityComparer() {}

			public bool Equals( System.Security.Principal.WindowsBuiltInRole left, System.Security.Principal.WindowsBuiltInRole right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.WindowsBuiltInRole obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer : IEqualityComparer<System.Runtime.ConstrainedExecution.Consistency>
		{
			public System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer() {}

			public bool Equals( System.Runtime.ConstrainedExecution.Consistency left, System.Runtime.ConstrainedExecution.Consistency right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.ConstrainedExecution.Consistency obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer : IEqualityComparer<System.Runtime.ConstrainedExecution.Cer>
		{
			public System_Runtime_ConstrainedExecution_CerEqualityComparer() {}

			public bool Equals( System.Runtime.ConstrainedExecution.Cer left, System.Runtime.ConstrainedExecution.Cer right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.ConstrainedExecution.Cer obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_SearchOptionEqualityComparer : IEqualityComparer<System.IO.SearchOption>
		{
			public System_IO_SearchOptionEqualityComparer() {}

			public bool Equals( System.IO.SearchOption left, System.IO.SearchOption right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.SearchOption obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_DriveTypeEqualityComparer : IEqualityComparer<System.IO.DriveType>
		{
			public System_IO_DriveTypeEqualityComparer() {}

			public bool Equals( System.IO.DriveType left, System.IO.DriveType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.DriveType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_FileAccessEqualityComparer : IEqualityComparer<System.IO.FileAccess>
		{
			public System_IO_FileAccessEqualityComparer() {}

			public bool Equals( System.IO.FileAccess left, System.IO.FileAccess right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.FileAccess obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_FileModeEqualityComparer : IEqualityComparer<System.IO.FileMode>
		{
			public System_IO_FileModeEqualityComparer() {}

			public bool Equals( System.IO.FileMode left, System.IO.FileMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.FileMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_FileOptionsEqualityComparer : IEqualityComparer<System.IO.FileOptions>
		{
			public System_IO_FileOptionsEqualityComparer() {}

			public bool Equals( System.IO.FileOptions left, System.IO.FileOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.FileOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_FileShareEqualityComparer : IEqualityComparer<System.IO.FileShare>
		{
			public System_IO_FileShareEqualityComparer() {}

			public bool Equals( System.IO.FileShare left, System.IO.FileShare right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.FileShare obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_FileAttributesEqualityComparer : IEqualityComparer<System.IO.FileAttributes>
		{
			public System_IO_FileAttributesEqualityComparer() {}

			public bool Equals( System.IO.FileAttributes left, System.IO.FileAttributes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.FileAttributes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_SeekOriginEqualityComparer : IEqualityComparer<System.IO.SeekOrigin>
		{
			public System_IO_SeekOriginEqualityComparer() {}

			public bool Equals( System.IO.SeekOrigin left, System.IO.SeekOrigin right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.SeekOrigin obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer : IEqualityComparer<System.Runtime.Remoting.WellKnownObjectMode>
		{
			public System_Runtime_Remoting_WellKnownObjectModeEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.WellKnownObjectMode left, System.Runtime.Remoting.WellKnownObjectMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.WellKnownObjectMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer : IEqualityComparer<System.Runtime.Remoting.Activation.ActivatorLevel>
		{
			public System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.Activation.ActivatorLevel left, System.Runtime.Remoting.Activation.ActivatorLevel right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.Activation.ActivatorLevel obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer : IEqualityComparer<System.Runtime.Remoting.Channels.ServerProcessing>
		{
			public System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.Channels.ServerProcessing left, System.Runtime.Remoting.Channels.ServerProcessing right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.Channels.ServerProcessing obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer : IEqualityComparer<System.Runtime.Remoting.Lifetime.LeaseState>
		{
			public System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.Lifetime.LeaseState left, System.Runtime.Remoting.Lifetime.LeaseState right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.Lifetime.LeaseState obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer : IEqualityComparer<System.Runtime.Remoting.Metadata.SoapOption>
		{
			public System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.Metadata.SoapOption left, System.Runtime.Remoting.Metadata.SoapOption right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.Metadata.SoapOption obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer : IEqualityComparer<System.Runtime.Remoting.Metadata.XmlFieldOrderOption>
		{
			public System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.Metadata.XmlFieldOrderOption left, System.Runtime.Remoting.Metadata.XmlFieldOrderOption right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.Metadata.XmlFieldOrderOption obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer : IEqualityComparer<System.Runtime.Remoting.CustomErrorsModes>
		{
			public System_Runtime_Remoting_CustomErrorsModesEqualityComparer() {}

			public bool Equals( System.Runtime.Remoting.CustomErrorsModes left, System.Runtime.Remoting.CustomErrorsModes right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Remoting.CustomErrorsModes obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer : IEqualityComparer<System.Runtime.Serialization.Formatters.FormatterTypeStyle>
		{
			public System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.Formatters.FormatterTypeStyle left, System.Runtime.Serialization.Formatters.FormatterTypeStyle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.Formatters.FormatterTypeStyle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer : IEqualityComparer<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle>
		{
			public System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.Formatters.FormatterAssemblyStyle left, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.Formatters.FormatterAssemblyStyle obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer : IEqualityComparer<System.Runtime.Serialization.Formatters.TypeFilterLevel>
		{
			public System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer() {}

			public bool Equals( System.Runtime.Serialization.Formatters.TypeFilterLevel left, System.Runtime.Serialization.Formatters.TypeFilterLevel right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Runtime.Serialization.Formatters.TypeFilterLevel obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CipherModeEqualityComparer : IEqualityComparer<System.Security.Cryptography.CipherMode>
		{
			public System_Security_Cryptography_CipherModeEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CipherMode left, System.Security.Cryptography.CipherMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CipherMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_PaddingModeEqualityComparer : IEqualityComparer<System.Security.Cryptography.PaddingMode>
		{
			public System_Security_Cryptography_PaddingModeEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.PaddingMode left, System.Security.Cryptography.PaddingMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.PaddingMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer : IEqualityComparer<System.Security.Cryptography.FromBase64TransformMode>
		{
			public System_Security_Cryptography_FromBase64TransformModeEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.FromBase64TransformMode left, System.Security.Cryptography.FromBase64TransformMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.FromBase64TransformMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CspProviderFlags>
		{
			public System_Security_Cryptography_CspProviderFlagsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CspProviderFlags left, System.Security.Cryptography.CspProviderFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CspProviderFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer : IEqualityComparer<System.Security.Cryptography.CryptoStreamMode>
		{
			public System_Security_Cryptography_CryptoStreamModeEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CryptoStreamMode left, System.Security.Cryptography.CryptoStreamMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CryptoStreamMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_DSAParametersEqualityComparer : IEqualityComparer<System.Security.Cryptography.DSAParameters>
		{
			public System_Security_Cryptography_DSAParametersEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.DSAParameters left, System.Security.Cryptography.DSAParameters right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.DSAParameters obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_KeyNumberEqualityComparer : IEqualityComparer<System.Security.Cryptography.KeyNumber>
		{
			public System_Security_Cryptography_KeyNumberEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.KeyNumber left, System.Security.Cryptography.KeyNumber right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.KeyNumber obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_RSAParametersEqualityComparer : IEqualityComparer<System.Security.Cryptography.RSAParameters>
		{
			public System_Security_Cryptography_RSAParametersEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.RSAParameters left, System.Security.Cryptography.RSAParameters right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.RSAParameters obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer : IEqualityComparer<System.Security.Cryptography.X509Certificates.X509ContentType>
		{
			public System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.X509Certificates.X509ContentType left, System.Security.Cryptography.X509Certificates.X509ContentType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.X509Certificates.X509ContentType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer : IEqualityComparer<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags>
		{
			public System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.X509Certificates.X509KeyStorageFlags left, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.X509Certificates.X509KeyStorageFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.InheritanceFlags>
		{
			public System_Security_AccessControl_InheritanceFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.InheritanceFlags left, System.Security.AccessControl.InheritanceFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.InheritanceFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.PropagationFlags>
		{
			public System_Security_AccessControl_PropagationFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.PropagationFlags left, System.Security.AccessControl.PropagationFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.PropagationFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.AuditFlags>
		{
			public System_Security_AccessControl_AuditFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AuditFlags left, System.Security.AccessControl.AuditFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AuditFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer : IEqualityComparer<System.Security.AccessControl.SecurityInfos>
		{
			public System_Security_AccessControl_SecurityInfosEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.SecurityInfos left, System.Security.AccessControl.SecurityInfos right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.SecurityInfos obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer : IEqualityComparer<System.Security.AccessControl.ResourceType>
		{
			public System_Security_AccessControl_ResourceTypeEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.ResourceType left, System.Security.AccessControl.ResourceType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.ResourceType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer : IEqualityComparer<System.Security.AccessControl.AccessControlSections>
		{
			public System_Security_AccessControl_AccessControlSectionsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AccessControlSections left, System.Security.AccessControl.AccessControlSections right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AccessControlSections obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer : IEqualityComparer<System.Security.AccessControl.AccessControlActions>
		{
			public System_Security_AccessControl_AccessControlActionsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AccessControlActions left, System.Security.AccessControl.AccessControlActions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AccessControlActions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AceTypeEqualityComparer : IEqualityComparer<System.Security.AccessControl.AceType>
		{
			public System_Security_AccessControl_AceTypeEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AceType left, System.Security.AccessControl.AceType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AceType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AceFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.AceFlags>
		{
			public System_Security_AccessControl_AceFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AceFlags left, System.Security.AccessControl.AceFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AceFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer : IEqualityComparer<System.Security.AccessControl.CompoundAceType>
		{
			public System_Security_AccessControl_CompoundAceTypeEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.CompoundAceType left, System.Security.AccessControl.CompoundAceType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.CompoundAceType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AceQualifierEqualityComparer : IEqualityComparer<System.Security.AccessControl.AceQualifier>
		{
			public System_Security_AccessControl_AceQualifierEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AceQualifier left, System.Security.AccessControl.AceQualifier right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AceQualifier obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.ObjectAceFlags>
		{
			public System_Security_AccessControl_ObjectAceFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.ObjectAceFlags left, System.Security.AccessControl.ObjectAceFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.ObjectAceFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer : IEqualityComparer<System.Security.AccessControl.CryptoKeyRights>
		{
			public System_Security_AccessControl_CryptoKeyRightsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.CryptoKeyRights left, System.Security.AccessControl.CryptoKeyRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.CryptoKeyRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer : IEqualityComparer<System.Security.AccessControl.EventWaitHandleRights>
		{
			public System_Security_AccessControl_EventWaitHandleRightsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.EventWaitHandleRights left, System.Security.AccessControl.EventWaitHandleRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.EventWaitHandleRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer : IEqualityComparer<System.Security.AccessControl.FileSystemRights>
		{
			public System_Security_AccessControl_FileSystemRightsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.FileSystemRights left, System.Security.AccessControl.FileSystemRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.FileSystemRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_MutexRightsEqualityComparer : IEqualityComparer<System.Security.AccessControl.MutexRights>
		{
			public System_Security_AccessControl_MutexRightsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.MutexRights left, System.Security.AccessControl.MutexRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.MutexRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer : IEqualityComparer<System.Security.AccessControl.AccessControlModification>
		{
			public System_Security_AccessControl_AccessControlModificationEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AccessControlModification left, System.Security.AccessControl.AccessControlModification right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AccessControlModification obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer : IEqualityComparer<System.Security.AccessControl.RegistryRights>
		{
			public System_Security_AccessControl_RegistryRightsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.RegistryRights left, System.Security.AccessControl.RegistryRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.RegistryRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer : IEqualityComparer<System.Security.AccessControl.AccessControlType>
		{
			public System_Security_AccessControl_AccessControlTypeEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.AccessControlType left, System.Security.AccessControl.AccessControlType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.AccessControlType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer : IEqualityComparer<System.Security.AccessControl.ControlFlags>
		{
			public System_Security_AccessControl_ControlFlagsEqualityComparer() {}

			public bool Equals( System.Security.AccessControl.ControlFlags left, System.Security.AccessControl.ControlFlags right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.AccessControl.ControlFlags obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer : IEqualityComparer<System.Security.Principal.WellKnownSidType>
		{
			public System_Security_Principal_WellKnownSidTypeEqualityComparer() {}

			public bool Equals( System.Security.Principal.WellKnownSidType left, System.Security.Principal.WellKnownSidType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Principal.WellKnownSidType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_EventDescriptorEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.EventDescriptor>
		{
			public System_Diagnostics_Eventing_EventDescriptorEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.EventDescriptor left, System.Diagnostics.Eventing.EventDescriptor right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.EventDescriptor obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Management_Instrumentation_ManagementHostingModelEqualityComparer : IEqualityComparer<System.Management.Instrumentation.ManagementHostingModel>
		{
			public System_Management_Instrumentation_ManagementHostingModelEqualityComparer() {}

			public bool Equals( System.Management.Instrumentation.ManagementHostingModel left, System.Management.Instrumentation.ManagementHostingModel right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Management.Instrumentation.ManagementHostingModel obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Management_Instrumentation_ManagementConfigurationTypeEqualityComparer : IEqualityComparer<System.Management.Instrumentation.ManagementConfigurationType>
		{
			public System_Management_Instrumentation_ManagementConfigurationTypeEqualityComparer() {}

			public bool Equals( System.Management.Instrumentation.ManagementConfigurationType left, System.Management.Instrumentation.ManagementConfigurationType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Management.Instrumentation.ManagementConfigurationType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_EventLogTypeEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.EventLogType>
		{
			public System_Diagnostics_Eventing_Reader_EventLogTypeEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.EventLogType left, System.Diagnostics.Eventing.Reader.EventLogType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.EventLogType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_EventLogIsolationEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.EventLogIsolation>
		{
			public System_Diagnostics_Eventing_Reader_EventLogIsolationEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.EventLogIsolation left, System.Diagnostics.Eventing.Reader.EventLogIsolation right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.EventLogIsolation obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_EventLogModeEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.EventLogMode>
		{
			public System_Diagnostics_Eventing_Reader_EventLogModeEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.EventLogMode left, System.Diagnostics.Eventing.Reader.EventLogMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.EventLogMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_SessionAuthenticationEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.SessionAuthentication>
		{
			public System_Diagnostics_Eventing_Reader_SessionAuthenticationEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.SessionAuthentication left, System.Diagnostics.Eventing.Reader.SessionAuthentication right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.SessionAuthentication obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_PathTypeEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.PathType>
		{
			public System_Diagnostics_Eventing_Reader_PathTypeEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.PathType left, System.Diagnostics.Eventing.Reader.PathType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.PathType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_StandardEventLevelEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.StandardEventLevel>
		{
			public System_Diagnostics_Eventing_Reader_StandardEventLevelEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.StandardEventLevel left, System.Diagnostics.Eventing.Reader.StandardEventLevel right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.StandardEventLevel obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_StandardEventTaskEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.StandardEventTask>
		{
			public System_Diagnostics_Eventing_Reader_StandardEventTaskEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.StandardEventTask left, System.Diagnostics.Eventing.Reader.StandardEventTask right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.StandardEventTask obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_StandardEventOpcodeEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.StandardEventOpcode>
		{
			public System_Diagnostics_Eventing_Reader_StandardEventOpcodeEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.StandardEventOpcode left, System.Diagnostics.Eventing.Reader.StandardEventOpcode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.StandardEventOpcode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_Eventing_Reader_StandardEventKeywordsEqualityComparer : IEqualityComparer<System.Diagnostics.Eventing.Reader.StandardEventKeywords>
		{
			public System_Diagnostics_Eventing_Reader_StandardEventKeywordsEqualityComparer() {}

			public bool Equals( System.Diagnostics.Eventing.Reader.StandardEventKeywords left, System.Diagnostics.Eventing.Reader.StandardEventKeywords right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.Eventing.Reader.StandardEventKeywords obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngKeyHandleOpenOptionsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngKeyHandleOpenOptions>
		{
			public System_Security_Cryptography_CngKeyHandleOpenOptionsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngKeyHandleOpenOptions left, System.Security.Cryptography.CngKeyHandleOpenOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngKeyHandleOpenOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngPropertyEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngProperty>
		{
			public System_Security_Cryptography_CngPropertyEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngProperty obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_ECDiffieHellmanKeyDerivationFunctionEqualityComparer : IEqualityComparer<System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction>
		{
			public System_Security_Cryptography_ECDiffieHellmanKeyDerivationFunctionEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction left, System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_ECKeyXmlFormatEqualityComparer : IEqualityComparer<System.Security.Cryptography.ECKeyXmlFormat>
		{
			public System_Security_Cryptography_ECKeyXmlFormatEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.ECKeyXmlFormat left, System.Security.Cryptography.ECKeyXmlFormat right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.ECKeyXmlFormat obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngExportPoliciesEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngExportPolicies>
		{
			public System_Security_Cryptography_CngExportPoliciesEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngExportPolicies left, System.Security.Cryptography.CngExportPolicies right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngExportPolicies obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngKeyCreationOptionsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngKeyCreationOptions>
		{
			public System_Security_Cryptography_CngKeyCreationOptionsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngKeyCreationOptions left, System.Security.Cryptography.CngKeyCreationOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngKeyCreationOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngKeyOpenOptionsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngKeyOpenOptions>
		{
			public System_Security_Cryptography_CngKeyOpenOptionsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngKeyOpenOptions left, System.Security.Cryptography.CngKeyOpenOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngKeyOpenOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngKeyUsagesEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngKeyUsages>
		{
			public System_Security_Cryptography_CngKeyUsagesEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngKeyUsages left, System.Security.Cryptography.CngKeyUsages right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngKeyUsages obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngPropertyOptionsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngPropertyOptions>
		{
			public System_Security_Cryptography_CngPropertyOptionsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngPropertyOptions left, System.Security.Cryptography.CngPropertyOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngPropertyOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_CngUIProtectionLevelsEqualityComparer : IEqualityComparer<System.Security.Cryptography.CngUIProtectionLevels>
		{
			public System_Security_Cryptography_CngUIProtectionLevelsEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.CngUIProtectionLevels left, System.Security.Cryptography.CngUIProtectionLevels right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.CngUIProtectionLevels obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_SignatureVerificationResultEqualityComparer : IEqualityComparer<System.Security.Cryptography.SignatureVerificationResult>
		{
			public System_Security_Cryptography_SignatureVerificationResultEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.SignatureVerificationResult left, System.Security.Cryptography.SignatureVerificationResult right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.SignatureVerificationResult obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Security_Cryptography_X509Certificates_TrustStatusEqualityComparer : IEqualityComparer<System.Security.Cryptography.X509Certificates.TrustStatus>
		{
			public System_Security_Cryptography_X509Certificates_TrustStatusEqualityComparer() {}

			public bool Equals( System.Security.Cryptography.X509Certificates.TrustStatus left, System.Security.Cryptography.X509Certificates.TrustStatus right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Security.Cryptography.X509Certificates.TrustStatus obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_TraceLogRetentionOptionEqualityComparer : IEqualityComparer<System.Diagnostics.TraceLogRetentionOption>
		{
			public System_Diagnostics_TraceLogRetentionOptionEqualityComparer() {}

			public bool Equals( System.Diagnostics.TraceLogRetentionOption left, System.Diagnostics.TraceLogRetentionOption right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.TraceLogRetentionOption obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_PerformanceData_CounterSetInstanceTypeEqualityComparer : IEqualityComparer<System.Diagnostics.PerformanceData.CounterSetInstanceType>
		{
			public System_Diagnostics_PerformanceData_CounterSetInstanceTypeEqualityComparer() {}

			public bool Equals( System.Diagnostics.PerformanceData.CounterSetInstanceType left, System.Diagnostics.PerformanceData.CounterSetInstanceType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.PerformanceData.CounterSetInstanceType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Diagnostics_PerformanceData_CounterTypeEqualityComparer : IEqualityComparer<System.Diagnostics.PerformanceData.CounterType>
		{
			public System_Diagnostics_PerformanceData_CounterTypeEqualityComparer() {}

			public bool Equals( System.Diagnostics.PerformanceData.CounterType left, System.Diagnostics.PerformanceData.CounterType right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Diagnostics.PerformanceData.CounterType obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_HandleInheritabilityEqualityComparer : IEqualityComparer<System.IO.HandleInheritability>
		{
			public System_IO_HandleInheritabilityEqualityComparer() {}

			public bool Equals( System.IO.HandleInheritability left, System.IO.HandleInheritability right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.HandleInheritability obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_Pipes_PipeDirectionEqualityComparer : IEqualityComparer<System.IO.Pipes.PipeDirection>
		{
			public System_IO_Pipes_PipeDirectionEqualityComparer() {}

			public bool Equals( System.IO.Pipes.PipeDirection left, System.IO.Pipes.PipeDirection right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.Pipes.PipeDirection obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer : IEqualityComparer<System.IO.Pipes.PipeTransmissionMode>
		{
			public System_IO_Pipes_PipeTransmissionModeEqualityComparer() {}

			public bool Equals( System.IO.Pipes.PipeTransmissionMode left, System.IO.Pipes.PipeTransmissionMode right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.Pipes.PipeTransmissionMode obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_Pipes_PipeOptionsEqualityComparer : IEqualityComparer<System.IO.Pipes.PipeOptions>
		{
			public System_IO_Pipes_PipeOptionsEqualityComparer() {}

			public bool Equals( System.IO.Pipes.PipeOptions left, System.IO.Pipes.PipeOptions right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.Pipes.PipeOptions obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer : IEqualityComparer<System.IO.Pipes.PipeAccessRights>
		{
			public System_IO_Pipes_PipeAccessRightsEqualityComparer() {}

			public bool Equals( System.IO.Pipes.PipeAccessRights left, System.IO.Pipes.PipeAccessRights right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.IO.Pipes.PipeAccessRights obj )
			{
				return obj.GetHashCode();
			}
		}

		private sealed class System_Threading_LockRecursionPolicyEqualityComparer : IEqualityComparer<System.Threading.LockRecursionPolicy>
		{
			public System_Threading_LockRecursionPolicyEqualityComparer() {}

			public bool Equals( System.Threading.LockRecursionPolicy left, System.Threading.LockRecursionPolicy right )
			{
				return left.Equals( right );
			}

			public int GetHashCode( System.Threading.LockRecursionPolicy obj )
			{
				return obj.GetHashCode();
			}
		}
	}
}