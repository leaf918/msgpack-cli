﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = null;
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = null;
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = null;
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema3TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema3TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            tupleItemSchema3TypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema3TypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema3TypeMap0);
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = null;
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = null;
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = null;
            tupleItemsSchema0[6] = tupleItemSchema6;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>>(1);
            packOperationTable["Tuple7MidPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>(this.PackValueOfTuple7MidPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple7MidPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(1);
            unpackOperationTable["Tuple7MidPolymorphic"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple7MidPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple7MidPolymorphic"};
        }
        
        private void PackValueOfTuple7MidPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple7MidPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor(unpackingContext.Tuple7MidPolymorphic);
            return result;
        }
        
        private void UnpackValueOfTuple7MidPolymorphic(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string> nullable = default(System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Tuple7MidPolymorphic", unpacker);
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
                unpackingContext.Tuple7MidPolymorphic = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string> ctorArg0 = default(System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7MidPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string> Tuple7MidPolymorphic;
            
            public UnpackingContext(System.Tuple<string, string, string, MsgPack.Serialization.FileSystemEntry, string, string, string> Tuple7MidPolymorphic) {
                this.Tuple7MidPolymorphic = Tuple7MidPolymorphic;
            }
        }
    }
}