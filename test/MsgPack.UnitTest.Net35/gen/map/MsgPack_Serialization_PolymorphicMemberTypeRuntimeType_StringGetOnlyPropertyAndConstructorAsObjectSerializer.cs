﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>>(1);
            packOperationTable["String"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.PackValueOfString);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfString);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(1);
            unpackOperationTable["String"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfString);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "String"};
        }
        
        private void PackValueOfString(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree) {
            this._serializer0.PackTo(packer, objectTree.String);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject(unpackingContext.String);
            return result;
        }
        
        private void UnpackValueOfString(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            object nullable = default(object);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "String", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable = this._serializer0.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                disposable = unpacker.ReadSubtree();
                try {
                    nullable = this._serializer0.UnpackFrom(disposable);
                }
                finally {
                    if (((disposable == null) 
                                == false)) {
                        disposable.Dispose();
                    }
                }
            }
            if (((nullable == null) 
                        == false)) {
                unpackingContext.String = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            object ctorArg0 = default(object);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public object String;
            
            public UnpackingContext(object String) {
                this.String = String;
            }
        }
    }
}