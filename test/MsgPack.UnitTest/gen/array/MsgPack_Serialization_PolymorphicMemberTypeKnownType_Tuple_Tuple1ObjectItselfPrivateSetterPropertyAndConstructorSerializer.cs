﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>> _packOperationList;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            this._serializer0 = context.GetSerializer<object>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor).GetMethod("set_Tuple1ObjectItself", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(object)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>>(1);
            unpackOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple1ObjectItself"};
        }
        
        private void PackValueOfTuple1ObjectItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1ObjectItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfTuple1ObjectItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem) {
            object nullable = default(object);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Tuple1ObjectItself", unpacker);
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
                this._methodBasePolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0.Invoke(unpackingContext, new object[] {
                            nullable});
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._unpackOperationTable);
            }
        }
    }
}