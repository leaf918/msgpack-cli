﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, object>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty> this_PackValueOfDictStaticKeyAndObjectItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, System.Collections.Generic.IDictionary<string, object>> this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int> this_UnpackValueOfDictStaticKeyAndObjectItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, object>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, object>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>(this.PackValueOfDictStaticKeyAndObjectItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>>(1);
            packOperationTable["DictStaticKeyAndObjectItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>(this.PackValueOfDictStaticKeyAndObjectItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>(this.UnpackValueOfDictStaticKeyAndObjectItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>>(1);
            unpackOperationTable["DictStaticKeyAndObjectItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>(this.UnpackValueOfDictStaticKeyAndObjectItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictStaticKeyAndObjectItem"};
            this.this_PackValueOfDictStaticKeyAndObjectItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>(this.PackValueOfDictStaticKeyAndObjectItem);
            this.this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, System.Collections.Generic.IDictionary<string, object>>(this.SetUnpackedValueOfDictStaticKeyAndObjectItem);
            this.this_UnpackValueOfDictStaticKeyAndObjectItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty, int, int>(this.UnpackValueOfDictStaticKeyAndObjectItem);
        }
        
        private void PackValueOfDictStaticKeyAndObjectItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndObjectItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfDictStaticKeyAndObjectItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty unpackingContext, System.Collections.Generic.IDictionary<string, object> unpackedValue) {
            unpackingContext.DictStaticKeyAndObjectItem = unpackedValue;
        }
        
        private void UnpackValueOfDictStaticKeyAndObjectItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, object>), "DictStaticKeyAndObjectItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}