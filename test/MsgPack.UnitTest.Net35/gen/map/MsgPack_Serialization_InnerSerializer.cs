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
    public class MsgPack_Serialization_InnerSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Inner> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InnerSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>>(3);
            packOperationTable["A"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>(this.PackValueOfA);
            packOperationTable["Bytes"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>(this.PackValueOfBytes);
            packOperationTable["C"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Inner>(this.PackValueOfC);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfA);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfBytes);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfC);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>>(3);
            unpackOperationTable["A"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfA);
            unpackOperationTable["Bytes"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfBytes);
            unpackOperationTable["C"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Inner, int>(this.UnpackValueOfC);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "A",
                    "Bytes",
                    "C"};
        }
        
        private void PackValueOfA(MsgPack.Packer packer, MsgPack.Serialization.Inner objectTree) {
            this._serializer0.PackTo(packer, objectTree.A);
        }
        
        private void PackValueOfBytes(MsgPack.Packer packer, MsgPack.Serialization.Inner objectTree) {
            this._serializer1.PackTo(packer, objectTree.Bytes);
        }
        
        private void PackValueOfC(MsgPack.Packer packer, MsgPack.Serialization.Inner objectTree) {
            this._serializer0.PackTo(packer, objectTree.C);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.Inner objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfA(MsgPack.Unpacker unpacker, MsgPack.Serialization.Inner unpackingContext, int indexOfItem) {
            string nullable = default(string);
            nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Inner), "A");
            if (((nullable == null) 
                        == false)) {
                unpackingContext.A = nullable;
            }
        }
        
        private void UnpackValueOfBytes(MsgPack.Unpacker unpacker, MsgPack.Serialization.Inner unpackingContext, int indexOfItem) {
            byte[] nullable0 = default(byte[]);
            nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.Inner), "Bytes");
            if (((nullable0 == null) 
                        == false)) {
                unpackingContext.Bytes = nullable0;
            }
        }
        
        private void UnpackValueOfC(MsgPack.Unpacker unpacker, MsgPack.Serialization.Inner unpackingContext, int indexOfItem) {
            string nullable1 = default(string);
            nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Inner), "C");
            if (((nullable1 == null) 
                        == false)) {
                unpackingContext.C = nullable1;
            }
        }
        
        protected internal override MsgPack.Serialization.Inner UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.Inner result = default(MsgPack.Serialization.Inner);
            result = new MsgPack.Serialization.Inner();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Inner>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Inner>(), this._unpackOperationTable);
            }
        }
    }
}