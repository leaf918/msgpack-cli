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
    public class MsgPack_Serialization_InterfaceListItemKnownTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.InterfaceListItemKnownType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemKnownType>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InterfaceListItemKnownTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> itemsSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            itemsSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            itemsSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.FileEntry));
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry), itemsSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemKnownType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemKnownType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemKnownType>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemKnownType>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemKnownType, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.InterfaceListItemKnownType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.InterfaceListItemKnownType objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.InterfaceListItemKnownType unpackingContext, int indexOfItem) {
            System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry> nullable = default(System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Value", unpacker);
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
                unpackingContext.Value = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.InterfaceListItemKnownType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.InterfaceListItemKnownType result = default(MsgPack.Serialization.InterfaceListItemKnownType);
            result = new MsgPack.Serialization.InterfaceListItemKnownType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceListItemKnownType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceListItemKnownType>(), this._unpackOperationTable);
            }
        }
    }
}