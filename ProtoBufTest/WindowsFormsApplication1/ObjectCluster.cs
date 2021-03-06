// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ObjectCluster.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace com.shimmerresearch.datastructure {

  /// <summary>Holder for reflection information generated from ObjectCluster.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ObjectClusterReflection {

    #region Descriptor
    /// <summary>File descriptor for ObjectCluster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ObjectClusterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNPYmplY3RDbHVzdGVyLnByb3RvEgh0dXRvcmlhbCLPBAoOT2JqZWN0Q2x1",
            "c3RlcjISDAoEbmFtZRgBIAEoCRIYChBibHVldG9vdGhBZGRyZXNzGAIgASgJ",
            "EhIKCnN5c3RlbVRpbWUYAyABKAMSRQoRY29tbXVuaWNhdGlvblR5cGUYBCAB",
            "KA4yKi50dXRvcmlhbC5PYmplY3RDbHVzdGVyMi5Db21tdW5pY2F0aW9uVHlw",
            "ZRI2CgdkYXRhTWFwGAUgAygLMiUudHV0b3JpYWwuT2JqZWN0Q2x1c3RlcjIu",
            "RGF0YU1hcEVudHJ5Gu8BCg5Gb3JtYXRDbHVzdGVyMhJJCglmb3JtYXRNYXAY",
            "ASADKAsyNi50dXRvcmlhbC5PYmplY3RDbHVzdGVyMi5Gb3JtYXRDbHVzdGVy",
            "Mi5Gb3JtYXRNYXBFbnRyeRoqCgxEYXRhQ2x1c3RlcjISDAoEdW5pdBgBIAEo",
            "CRIMCgRkYXRhGAIgASgBGmYKDkZvcm1hdE1hcEVudHJ5EgsKA2tleRgBIAEo",
            "CRJDCgV2YWx1ZRgCIAEoCzI0LnR1dG9yaWFsLk9iamVjdENsdXN0ZXIyLkZv",
            "cm1hdENsdXN0ZXIyLkRhdGFDbHVzdGVyMjoCOAEaVwoMRGF0YU1hcEVudHJ5",
            "EgsKA2tleRgBIAEoCRI2CgV2YWx1ZRgCIAEoCzInLnR1dG9yaWFsLk9iamVj",
            "dENsdXN0ZXIyLkZvcm1hdENsdXN0ZXIyOgI4ASI3ChFDb21tdW5pY2F0aW9u",
            "VHlwZRIGCgJCVBAAEgYKAlNEEAESEgoOUmFkaW9fODAyXzE1XzQQAkJdCiFj",
            "b20uc2hpbW1lcnJlc2VhcmNoLmRhdGFzdHJ1Y3R1cmVCFFNoaW1tZXJPYmpl",
            "Y3RDbHVzdGVyqgIhY29tLnNoaW1tZXJyZXNlYXJjaC5kYXRhc3RydWN0dXJl",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::com.shimmerresearch.datastructure.ObjectCluster2), global::com.shimmerresearch.datastructure.ObjectCluster2.Parser, new[]{ "Name", "BluetoothAddress", "SystemTime", "CommunicationType", "DataMap" }, null, new[]{ typeof(global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType) }, new pbr::GeneratedCodeInfo[] { new pbr::GeneratedCodeInfo(typeof(global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2), global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Parser, new[]{ "FormatMap" }, null, null, new pbr::GeneratedCodeInfo[] { new pbr::GeneratedCodeInfo(typeof(global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2), global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2.Parser, new[]{ "Unit", "Data" }, null, null, null),
            null, }),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ObjectCluster2 : pb::IMessage<ObjectCluster2> {
    private static readonly pb::MessageParser<ObjectCluster2> _parser = new pb::MessageParser<ObjectCluster2>(() => new ObjectCluster2());
    public static pb::MessageParser<ObjectCluster2> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::com.shimmerresearch.datastructure.ObjectClusterReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ObjectCluster2() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ObjectCluster2(ObjectCluster2 other) : this() {
      name_ = other.name_;
      bluetoothAddress_ = other.bluetoothAddress_;
      systemTime_ = other.systemTime_;
      communicationType_ = other.communicationType_;
      dataMap_ = other.dataMap_.Clone();
    }

    public ObjectCluster2 Clone() {
      return new ObjectCluster2(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bluetoothAddress" field.</summary>
    public const int BluetoothAddressFieldNumber = 2;
    private string bluetoothAddress_ = "";
    public string BluetoothAddress {
      get { return bluetoothAddress_; }
      set {
        bluetoothAddress_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "systemTime" field.</summary>
    public const int SystemTimeFieldNumber = 3;
    private long systemTime_;
    public long SystemTime {
      get { return systemTime_; }
      set {
        systemTime_ = value;
      }
    }

    /// <summary>Field number for the "communicationType" field.</summary>
    public const int CommunicationTypeFieldNumber = 4;
    private global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType communicationType_ = global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType.BT;
    public global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType CommunicationType {
      get { return communicationType_; }
      set {
        communicationType_ = value;
      }
    }

    /// <summary>Field number for the "dataMap" field.</summary>
    public const int DataMapFieldNumber = 5;
    private static readonly pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2>.Codec _map_dataMap_codec
        = new pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Parser), 42);
    private readonly pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2> dataMap_ = new pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2>();
    public pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2> DataMap {
      get { return dataMap_; }
    }

    public override bool Equals(object other) {
      return Equals(other as ObjectCluster2);
    }

    public bool Equals(ObjectCluster2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (BluetoothAddress != other.BluetoothAddress) return false;
      if (SystemTime != other.SystemTime) return false;
      if (CommunicationType != other.CommunicationType) return false;
      if (!DataMap.Equals(other.DataMap)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (BluetoothAddress.Length != 0) hash ^= BluetoothAddress.GetHashCode();
      if (SystemTime != 0L) hash ^= SystemTime.GetHashCode();
      if (CommunicationType != global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType.BT) hash ^= CommunicationType.GetHashCode();
      hash ^= DataMap.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (BluetoothAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BluetoothAddress);
      }
      if (SystemTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SystemTime);
      }
      if (CommunicationType != global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType.BT) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CommunicationType);
      }
      dataMap_.WriteTo(output, _map_dataMap_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (BluetoothAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BluetoothAddress);
      }
      if (SystemTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SystemTime);
      }
      if (CommunicationType != global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType.BT) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CommunicationType);
      }
      size += dataMap_.CalculateSize(_map_dataMap_codec);
      return size;
    }

    public void MergeFrom(ObjectCluster2 other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.BluetoothAddress.Length != 0) {
        BluetoothAddress = other.BluetoothAddress;
      }
      if (other.SystemTime != 0L) {
        SystemTime = other.SystemTime;
      }
      if (other.CommunicationType != global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType.BT) {
        CommunicationType = other.CommunicationType;
      }
      dataMap_.Add(other.dataMap_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            BluetoothAddress = input.ReadString();
            break;
          }
          case 24: {
            SystemTime = input.ReadInt64();
            break;
          }
          case 32: {
            communicationType_ = (global::com.shimmerresearch.datastructure.ObjectCluster2.Types.CommunicationType) input.ReadEnum();
            break;
          }
          case 42: {
            dataMap_.AddEntriesFrom(input, _map_dataMap_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ObjectCluster2 message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum CommunicationType {
        BT = 0,
        SD = 1,
        Radio_802_15_4 = 2,
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class FormatCluster2 : pb::IMessage<FormatCluster2> {
        private static readonly pb::MessageParser<FormatCluster2> _parser = new pb::MessageParser<FormatCluster2>(() => new FormatCluster2());
        public static pb::MessageParser<FormatCluster2> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::com.shimmerresearch.datastructure.ObjectCluster2.Descriptor.NestedTypes[0]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public FormatCluster2() {
          OnConstruction();
        }

        partial void OnConstruction();

        public FormatCluster2(FormatCluster2 other) : this() {
          formatMap_ = other.formatMap_.Clone();
        }

        public FormatCluster2 Clone() {
          return new FormatCluster2(this);
        }

        /// <summary>Field number for the "formatMap" field.</summary>
        public const int FormatMapFieldNumber = 1;
        private static readonly pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2>.Codec _map_formatMap_codec
            = new pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2.Parser), 10);
        private readonly pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2> formatMap_ = new pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2>();
        public pbc::MapField<string, global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Types.DataCluster2> FormatMap {
          get { return formatMap_; }
        }

        public override bool Equals(object other) {
          return Equals(other as FormatCluster2);
        }

        public bool Equals(FormatCluster2 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!FormatMap.Equals(other.FormatMap)) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          hash ^= FormatMap.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          formatMap_.WriteTo(output, _map_formatMap_codec);
        }

        public int CalculateSize() {
          int size = 0;
          size += formatMap_.CalculateSize(_map_formatMap_codec);
          return size;
        }

        public void MergeFrom(FormatCluster2 other) {
          if (other == null) {
            return;
          }
          formatMap_.Add(other.formatMap_);
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                formatMap_.AddEntriesFrom(input, _map_formatMap_codec);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the FormatCluster2 message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types {
          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
          public sealed partial class DataCluster2 : pb::IMessage<DataCluster2> {
            private static readonly pb::MessageParser<DataCluster2> _parser = new pb::MessageParser<DataCluster2>(() => new DataCluster2());
            public static pb::MessageParser<DataCluster2> Parser { get { return _parser; } }

            public static pbr::MessageDescriptor Descriptor {
              get { return global::com.shimmerresearch.datastructure.ObjectCluster2.Types.FormatCluster2.Descriptor.NestedTypes[0]; }
            }

            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            public DataCluster2() {
              OnConstruction();
            }

            partial void OnConstruction();

            public DataCluster2(DataCluster2 other) : this() {
              unit_ = other.unit_;
              data_ = other.data_;
            }

            public DataCluster2 Clone() {
              return new DataCluster2(this);
            }

            /// <summary>Field number for the "unit" field.</summary>
            public const int UnitFieldNumber = 1;
            private string unit_ = "";
            public string Unit {
              get { return unit_; }
              set {
                unit_ = pb::Preconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "data" field.</summary>
            public const int DataFieldNumber = 2;
            private double data_;
            public double Data {
              get { return data_; }
              set {
                data_ = value;
              }
            }

            public override bool Equals(object other) {
              return Equals(other as DataCluster2);
            }

            public bool Equals(DataCluster2 other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Unit != other.Unit) return false;
              if (Data != other.Data) return false;
              return true;
            }

            public override int GetHashCode() {
              int hash = 1;
              if (Unit.Length != 0) hash ^= Unit.GetHashCode();
              if (Data != 0D) hash ^= Data.GetHashCode();
              return hash;
            }

            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            public void WriteTo(pb::CodedOutputStream output) {
              if (Unit.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Unit);
              }
              if (Data != 0D) {
                output.WriteRawTag(17);
                output.WriteDouble(Data);
              }
            }

            public int CalculateSize() {
              int size = 0;
              if (Unit.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Unit);
              }
              if (Data != 0D) {
                size += 1 + 8;
              }
              return size;
            }

            public void MergeFrom(DataCluster2 other) {
              if (other == null) {
                return;
              }
              if (other.Unit.Length != 0) {
                Unit = other.Unit;
              }
              if (other.Data != 0D) {
                Data = other.Data;
              }
            }

            public void MergeFrom(pb::CodedInputStream input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    input.SkipLastField();
                    break;
                  case 10: {
                    Unit = input.ReadString();
                    break;
                  }
                  case 17: {
                    Data = input.ReadDouble();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
